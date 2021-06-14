Namespace DataElements
    '''<summary>Interchange Delivery Time</summary>
    '''<remarks>
    '''<para>This is the earliest time the interchange can be delivered to the recipient</para>
    '''</remarks>
    Partial Friend Class ElementI36
        Inherits TimeElement

        Public Sub New()
            MyBase.New(4, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI36
            Dim rval As New ElementI36

            rval.Value = fullElement.ToTimeSpan
            Return rval
        End Function
    End Class
End NameSpace