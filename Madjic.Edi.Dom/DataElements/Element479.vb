Namespace DataElements
    '''<summary>Functional Identifier Code</summary>
    '''<remarks>
    '''<para>Code identifying a group of application related transaction sets</para>
    '''</remarks>
    Partial Friend Class Element479
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element479
            Dim rval As New Element479

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace