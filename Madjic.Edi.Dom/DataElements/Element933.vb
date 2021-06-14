Namespace DataElements
    '''<summary>Free-form Message Text</summary>
    '''<remarks>
    '''<para>Free-form message text</para>
    '''</remarks>
    Partial Friend Class Element933
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 264)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element933
            Dim rval As New Element933

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace