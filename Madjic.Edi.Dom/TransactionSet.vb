''' <summary>
''' Acts as a container of segments
''' </summary>
''' <remarks></remarks>
Public MustInherit Class TransactionSet
    Implements ITransactionSetItem, IValidate

    ''' <summary>
    ''' Creates a new instance of a Transaction Set.
    ''' </summary>
    ''' <param name="parentFunctionalGroupCode">Every transaction set can only be present in a specific functional group.</param>
    ''' <param name="versionCode">Every transaction set exposes a unique version control code.</param>
    ''' <remarks>This class must be inherited.</remarks>
    Protected Sub New(parentFunctionalGroupCode As String, versionCode As String)
        ParentFunctionGroupCode = parentFunctionalGroupCode
        Me.VersionCode = versionCode
    End Sub

    Private ReadOnly mChildren As New List(Of ITransactionSetItem)

    Public ReadOnly Property VersionCode As String

    Public ReadOnly Property ParentFunctionGroupCode As String

    Friend ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return mChildren
        End Get
    End Property

    Public Property TransactionSetIdCode As String
        Get
            EnsureStartSegment()
            Return CType(StartSegment.Elements(0), IdentifierElement).Value
        End Get
        Set(value As String)
            EnsureStartSegment()
            CType(StartSegment.Elements(0), IdentifierElement).Value = value
        End Set
    End Property

    Private ReadOnly Property StartSegment As Segment
        Get
            EnsureStartSegment()
            Return CType(mChildren(0), Segment)
        End Get
    End Property

    Private ReadOnly Property EndSegment As Segment
        Get
            EnsureEndSegment()
            Return CType(mChildren(mChildren.Count - 1), Segment)
        End Get
    End Property

    Private Sub EnsureStartSegment()
        If mChildren.Count = 0 OrElse Not (TypeOf mChildren(0) Is Segment) OrElse CType(mChildren(0), Segment).SegmentID <> "ST" Then
            Throw New InvalidOperationException("The first segment in a transaction set must be the ST segment.")
        End If
    End Sub

    Private Sub EnsureEndSegment()
        If mChildren.Count < 2 OrElse (TypeOf mChildren(mChildren.Count - 1) IsNot Segment) OrElse CType(mChildren(mChildren.Count - 1), Segment).SegmentID <> "SE" Then
            Throw New InvalidOperationException("The last segment in a transaction set must be the SE segment.")
        End If
    End Sub

    ''' <summary>
    ''' Reads the transaction set
    ''' </summary>
    ''' <param name="args">An object that facilitates reading the transaction set.</param>
    Friend MustOverride Function ReadAsync(args As ReaderArgs) As Task

    Friend Async Function WriteAsync(ByVal writer As IO.TextWriter, clearAfterWriting As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        EnsureStartSegment()
        EnsureEndSegment()

        'Set the number of segments in the transaction set.
        'Dim Count As Integer = GetCountOfChildren(mChildren)

        'CType(EndSegment.Elements(0), NumericElement).Value = Count

        'CType(EndSegment.Elements(1), StringElement).Value = CType(StartSegment.Elements(1), StringElement).Value

        CType(EndSegment, Segments.SE_Obj).SE02 = CType(StartSegment, Segments.ST_Obj).ST02
        Dim Count As Integer

        For index = 0 To mChildren.Count - 2
            Await mChildren(index).WriteAsync(writer, clearAfterWriting, envelope)

            If TypeOf mChildren(index) Is Segment Then
                Count += 1
            Else
                Count += mChildren(index).WriteCount
            End If
        Next

        Count += 1

        CType(EndSegment, Segments.SE_Obj).SE01 = Count
        'CType(EndSegment.Elements(0), NumericElement).Value = Count

        Await mChildren(mChildren.Count - 1).WriteAsync(writer, clearAfterWriting, envelope)
    End Function

    Private Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Return 0
    End Function

    Public Overridable Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim temp As New ValidationResults

        ValidateChildren(temp)

        If temp.HasErrors Then
            Dim e As New ValidationFailureResult With {.Source = Me}

            e.Errors.Add("At least one segment has an error.")

            results.Failures.Add(e)
        End If
    End Sub

    Public Overridable Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        Dim TryValidate As IValidate

        For Each item In mChildren
            TryValidate = TryCast(item, IValidate)

            If TryValidate IsNot Nothing Then
                TryValidate.Validate(results)
                TryValidate.ValidateChildren(results)
            End If
        Next
    End Sub

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
