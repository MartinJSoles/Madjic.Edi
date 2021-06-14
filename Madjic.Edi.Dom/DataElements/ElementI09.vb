Namespace DataElements
    '''<summary>Interchange Time</summary>
    '''<remarks>
    '''<para>Time of the interchange</para>
    '''</remarks>
    Partial Friend Class ElementI09
        Inherits TimeElement

        Public Sub New()
            MyBase.New(4, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI09
            Dim rval As New ElementI09

            rval.Value = fullElement.ToTimeSpan
            Return rval
        End Function
    End Class
End NameSpace