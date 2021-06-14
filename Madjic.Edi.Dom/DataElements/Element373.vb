Namespace DataElements
    '''<summary>Date</summary>
    '''<remarks>
    '''<para>Date expressed as CCYYMMDD where CC represents the first two digits of the calendar year</para>
    '''</remarks>
    Partial Friend Class Element373
        Inherits DateElement

        Public Sub New()
            MyBase.New(8, 8)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element373
            Dim rval As New Element373

            rval.Value = fullElement.ToDate
            Return rval
        End Function
    End Class
End NameSpace