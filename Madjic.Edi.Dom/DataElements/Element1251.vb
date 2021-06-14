Namespace DataElements
    '''<summary>Date Time Period</summary>
    '''<remarks>
    '''<para>Expression of a date, a time, or range of dates, times or dates and times</para>
    '''</remarks>
    Partial Friend Class Element1251
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1251
            Dim rval As New Element1251

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace