Namespace DataElements
    '''<summary>Measurement Value</summary>
    '''<remarks>
    '''<para>The value of the measurement</para>
    '''</remarks>
    Partial Friend Class Element739
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element739
            Dim rval As New Element739

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace