Namespace DataElements
    '''<summary>Item Description Type</summary>
    '''<remarks>
    '''<para>Code indicating the format of a description</para>
    '''</remarks>
    Partial Friend Class Element349
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "F,S,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element349
            Dim rval As New Element349

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace