Namespace DataElements
    '''<summary>Quantity</summary>
    '''<remarks>
    '''<para>Numeric value of quantity</para>
    '''</remarks>
    Partial Friend Class Element380
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element380
            Dim rval As New Element380

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace