Namespace DataElements
    '''<summary>Earnings Rate of Pay</summary>
    '''<remarks>
    '''<para>To specify rate of pay</para>
    '''</remarks>
    Partial Friend Class Element1687
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1687
            Dim rval As New Element1687

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace