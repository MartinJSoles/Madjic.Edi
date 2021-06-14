Namespace DataElements
    '''<summary>Range Minimum</summary>
    '''<remarks>
    '''<para>The value specifying the minimum of the measurement range</para>
    '''</remarks>
    Partial Friend Class Element740
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element740
            Dim rval As New Element740

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace