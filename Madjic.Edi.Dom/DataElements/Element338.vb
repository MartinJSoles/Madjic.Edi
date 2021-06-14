Namespace DataElements
    '''<summary>Terms Discount Percent</summary>
    '''<remarks>
    '''<para>Terms discount percentage, expressed as a percent, available to the purchaser if an invoice is paid on or before the Terms Discount Due Date</para>
    '''</remarks>
    Partial Friend Class Element338
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element338
            Dim rval As New Element338

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace