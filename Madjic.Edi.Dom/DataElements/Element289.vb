Namespace DataElements
    '''<summary>Multiple Price Quantity</summary>
    '''<remarks>
    '''<para>Quantity of units for a given price, e.g., 3 for $10.00</para>
    '''</remarks>
    Partial Friend Class Element289
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element289
            Dim rval As New Element289

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace