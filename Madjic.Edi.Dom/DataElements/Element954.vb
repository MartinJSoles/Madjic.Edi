Namespace DataElements
    '''<summary>Percentage as Decimal</summary>
    '''<remarks>
    '''<para>Percentage expressed as a decimal (e.g., 0.0 through 1.0 represents 0% through 100%)</para>
    '''</remarks>
    Partial Friend Class Element954
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element954
            Dim rval As New Element954

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace