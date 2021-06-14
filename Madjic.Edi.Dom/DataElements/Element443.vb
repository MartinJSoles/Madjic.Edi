Namespace DataElements
    '''<summary>Contact Inquiry Reference</summary>
    '''<remarks>
    '''<para>Additional reference number or description to clarify a contact number</para>
    '''</remarks>
    Partial Friend Class Element443
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element443
            Dim rval As New Element443

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace