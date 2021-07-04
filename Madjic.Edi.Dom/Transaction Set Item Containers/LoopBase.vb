Public MustInherit Class LoopBase
    Inherits List(Of ITransactionSetItem)
    Implements ILoop, IValidate, IParanted

    Public Overrides Function ToString() As String
        Return String.Format("Loop {3}, Table: {0}, Position: {1}, Count: {2}", SetTable, SetPosition, Count, If(LoopID, "(null)"))
    End Function

    Public ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Me
        End Get
    End Property

    Friend Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In Me
            If node IsNot Nothing Then
                Await node.WriteAsync(writer, clearAfterWrite, envelope)
            End If
        Next
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each node In Me
            If node IsNot Nothing Then
                If TypeOf node Is Segment Then
                    rval += 1
                Else
                    rval += node.WriteCount
                End If
            End If
        Next

        Return rval
    End Function

    Public Overridable Sub Validate(results As ValidationResults) Implements IValidate.Validate

    End Sub

    Public Overridable Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        Dim TryValidate As IValidate

        For Each node In Me
            TryValidate = TryCast(node, IValidate)

            If TryValidate IsNot Nothing Then
                TryValidate.Validate(results)
                TryValidate.ValidateChildren(results)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

    'These are used to link the actual instances of loops to their appropriate collections.
    Friend Property SetArea As String Implements ILoop.SetArea
    Friend Property SetSequence As String Implements ILoop.SetSequence

    'These are the standard positions for loops.
    Friend Property SetTable As Char
    Friend Property SetPosition As String

    Private mLoop As String
    Public Property LoopID As String
        Get
            Return If(mLoop, String.Empty)
        End Get
        Friend Set(value As String)
            mLoop = value
        End Set
    End Property

    ''' <summary>
    ''' Reads the current loop from the supplied ReaderArgs object.
    ''' </summary>
    ''' <param name="args">An object that facilitates reading the transaction set.</param>
    Friend MustOverride Function ReadAsync(args As ReaderArgs) As Task

    ''' <summary>
    ''' Compares the given instance to the set of allowed options.
    ''' </summary>
    ''' <param name="instance">The specific expression to find in the set of allowed options.</param>
    ''' <param name="allowedOptions">A semicolon separated list of strings, with a leading and trailing semicolon to simplify the comparison.</param>
    ''' <returns>True, if the instance is in the set of allowed options, or the set of allowed options is empty. False otherwise.</returns>
    Protected Shared Function CompareKey(instance As String, allowedOptions As String) As Boolean
        If allowedOptions Is Nothing OrElse allowedOptions.Length = 0 Then
            Return True ' Just accept it as the allowed options is missing
        ElseIf instance Is Nothing OrElse instance.Length = 0 Then
            Return True
        Else
            Dim i = allowedOptions.IndexOf(instance, StringComparison.OrdinalIgnoreCase)

            Return i > 0 AndAlso i < allowedOptions.Length - 1 AndAlso allowedOptions(i - 1) = ";"c AndAlso allowedOptions(i + instance.Length) = ";"c
        End If
    End Function
End Class
