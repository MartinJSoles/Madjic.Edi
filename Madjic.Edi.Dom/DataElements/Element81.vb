Namespace DataElements
    '''<summary>Weight</summary>
    '''<remarks>
    '''<para>Numeric value of weight</para>
    '''</remarks>
    Partial Friend Class Element81
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element81
            Dim rval As New Element81

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace