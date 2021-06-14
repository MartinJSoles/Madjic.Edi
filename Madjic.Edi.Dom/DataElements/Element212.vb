Namespace DataElements
    '''<summary>Unit Price</summary>
    '''<remarks>
    '''<para>Price per unit of product, service, commodity, etc.</para>
    '''</remarks>
    Partial Friend Class Element212
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 17)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element212
            Dim rval As New Element212

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace