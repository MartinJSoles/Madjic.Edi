Namespace DataElements
    '''<summary>Delay Reason Code</summary>
    '''<remarks>
    '''<para>Code indicating the reason why a request was delayed</para>
    '''</remarks>
    Partial Friend Class Element1514
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,10,11,15,16,17,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1514
            Dim rval As New Element1514

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace