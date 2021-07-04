Namespace DataElements
    '''<summary>Time</summary>
    '''<remarks>
    '''<para>Time expressed in 24-hour clock time as follows: HHMM, or HHMMSS, or HHMMSSD, or HHMMSSDD, where H = hours (00-23), M = minutes (00-59), S = integer seconds (00-59) and DD = decimal seconds; decimal seconds are expressed as follows: D = tenths (0-9) and DD = hundredths (00-99)</para>
    '''</remarks>
    Partial Friend Class Element337
        Inherits TimeElement

        Public Sub New()
            MyBase.New(4, 8)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element337
            Dim rval As New Element337

            rval.FromString(fullElement)
            Return rval
        End Function
    End Class
End NameSpace