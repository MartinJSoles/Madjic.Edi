Namespace DataElements
    '''<summary>Percent, Decimal Format</summary>
    '''<remarks>
    '''<para>Percent given in decimal format (e.g., 0.0 through 100.0 represents 0% through 100%)</para>
    '''</remarks>
    Partial Friend Class Element332
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element332
            Dim rval As New Element332

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace