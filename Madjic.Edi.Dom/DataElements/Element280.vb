Namespace DataElements
    '''<summary>Exchange Rate</summary>
    '''<remarks>
    '''<para>Value to be used as a multiplier conversion factor to convert monetary value from one currency to another</para>
    '''</remarks>
    Partial Friend Class Element280
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(4, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element280
            Dim rval As New Element280

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace