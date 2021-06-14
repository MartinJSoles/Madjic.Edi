Namespace DataElements
    '''<summary>Tax Identification Number</summary>
    '''<remarks>
    '''<para>Number assigned to a purchaser (buyer, orderer) by a taxing jurisdiction (state, county, etc.); often called a tax exemption number or certificate number</para>
    '''</remarks>
    Partial Friend Class Element325
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element325
            Dim rval As New Element325

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace