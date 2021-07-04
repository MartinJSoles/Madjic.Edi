Public Class SegmentContainer(Of T As ISegment)
    Inherits List(Of T)
    Implements ITransactionSetItem, IValidate, IParanted

    Public Overrides Function ToString() As String
        Return $"SegmentContainer, T: {GetType(T).Name}, Count: {Count}, Table: {Table}, Position: {Position}, MaximumStorage: {MaximumStorage}, Parent: {If(Parent, "(null)")}"
    End Function

    Public ReadOnly Property Table As Char
    Public ReadOnly Property Position As String

    Public ReadOnly Property MaximumStorage As Integer

    Friend Sub New(maximumStorage As Integer, table As Char, position As String)
        MyBase.New()

        Me.MaximumStorage = maximumStorage
        Me.Table = table
        Me.Position = position
    End Sub

    Private ReadOnly Property _Segments As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Me
        End Get
    End Property

    Friend Overridable Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In Me
            Dim ch = TryCast(node, Segment)

            If ch IsNot Nothing Then
                Await ch.WriteAsync(writer, envelope)
            End If
        Next

        If clearAfterWrite Then
            Clear()
        End If
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each ch In Me
            If ch IsNot Nothing Then
                rval += 1
            End If
        Next

        Return rval
    End Function

    Public Overridable Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim e As New ValidationFailureResult With {.Source = Me}
        If MaximumStorage > 0 AndAlso MaximumStorage < Count Then
            e.Errors.Add("The segment container is currently holding too many segments.")
        End If

        'Look through each segment and ensure it is for the right table/position/area/sequence
        Dim s As Segment
        For Each seg In Me
            s = TryCast(seg, Segment)

            If s IsNot Nothing Then
                If s.SetTable <> Table OrElse s.SetPosition <> Position Then
                    e.Errors.Add(String.Format("This object contains an invalid segment: {0}", s.SegmentID))
                End If
            End If
        Next

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Public Overridable Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each node In Me
            Dim ch = TryCast(node, Segment)

            If ch IsNot Nothing Then
                ch.ValidateSegmentItself(results)
                ch.ValidateElements(results)
            End If
        Next
    End Sub

    Friend Sub SetImplementationRules(rules As IEnumerable(Of SyntaxRule))
        For Each child In Me
            Dim ch = TryCast(child, Segment)

            If ch IsNot Nothing Then
                ch.SetImplementationRules(rules)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

End Class