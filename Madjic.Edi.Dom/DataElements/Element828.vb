Namespace DataElements
    '''<summary>Dollar Basis For Percent</summary>
    '''<remarks>
    '''<para>Dollar basis to be used in the percent calculation of the allowance, charge or tax</para>
    '''</remarks>
    Partial Friend Class Element828
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element828
            Dim rval As New Element828

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace