Namespace DataElements
    '''<summary>Rate</summary>
    '''<remarks>
    '''<para>Rate expressed in the standard monetary denomination for the currency specified</para>
    '''</remarks>
    Partial Friend Class Element118
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element118
            Dim rval As New Element118

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace