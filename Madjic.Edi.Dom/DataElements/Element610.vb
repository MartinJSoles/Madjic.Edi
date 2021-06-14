Namespace DataElements
    '''<summary>Amount</summary>
    '''<remarks>
    '''<para>Monetary amount</para>
    '''</remarks>
    Partial Friend Class Element610
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 2, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element610
            Dim rval As New Element610

            rval.Value = fullElement.ToDecimal(2)
            Return rval
        End Function
    End Class
End NameSpace