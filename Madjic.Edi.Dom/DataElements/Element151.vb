Namespace DataElements
    '''<summary>Authority</summary>
    '''<remarks>
    '''<para>Name or code of authority for authorizing action or reservation</para>
    '''</remarks>
    Partial Friend Class Element151
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element151
            Dim rval As New Element151

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace