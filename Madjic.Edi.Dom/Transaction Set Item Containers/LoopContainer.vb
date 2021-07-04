Public Class LoopContainer(Of T As ILoop)
    Inherits List(Of T)
    Implements ITransactionSetItem, IValidate, IParanted

    Public Overrides Function ToString() As String
        Return String.Format("LoopContainer, T: {0}, Table: {1}, Position: {2}, Maximum Repetitions: {3}, Count: {4}, Parent: {5}", GetType(T).ToString, Table, Position, MaximumRepetitions, Count, If(Parent IsNot Nothing, Parent.ToString, "(null)"))
    End Function

    Public ReadOnly Property Table As Char

    Public ReadOnly Property Position As String

    Public Sub New(maximumRepetitions As Integer, table As Char, position As String)
        MyBase.New()
        Me.MaximumRepetitions = maximumRepetitions
        Me.Table = table
        Me.Position = position
    End Sub

    Public ReadOnly Property MaximumRepetitions As Integer

    Friend ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Me
        End Get
    End Property

    Friend Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In Me
            Await node.WriteAsync(writer, clearAfterWrite, envelope)
        Next
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each node In Me
            If node IsNot Nothing Then
                rval += node.WriteCount
            End If
        Next

        Return rval
    End Function

    Public Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim e As New ValidationFailureResult With {.Source = Me}

        If MaximumRepetitions > 0 AndAlso Count > MaximumRepetitions Then
            e.Errors.Add("The maximum number of repetitions for this loop has been exceeded.")
        End If

        For Each node In Me
            Dim n = TryCast(node, LoopBase)

            If n IsNot Nothing Then
                If n.SetTable <> Table OrElse n.SetPosition <> Position Then
                    e.Errors.Add(String.Format("The loop {0} with Table {1} and Position {2} is not valid.", n.LoopID, n.SetTable, n.SetPosition))
                End If
            End If
        Next

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Public Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        Dim TryItem As IValidate

        For Each node In Me
            TryItem = TryCast(node, IValidate)

            If TryItem IsNot Nothing Then
                TryItem.Validate(results)
                TryItem.ValidateChildren(results)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

End Class
