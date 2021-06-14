Namespace DataElements
    '''<summary>Source Subqualifier</summary>
    '''<remarks>
    '''<para>A reference that indicates the table or text maintained by the Source Qualifier</para>
    '''</remarks>
    Partial Friend Class Element822
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element822
            Dim rval As New Element822

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace