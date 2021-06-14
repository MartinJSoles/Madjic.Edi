Namespace DataElements
    '''<summary>Product/Service ID</summary>
    '''<remarks>
    '''<para>Identifying number for a product or service</para>
    '''</remarks>
    Partial Friend Class Element234
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 48)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element234
            Dim rval As New Element234

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace