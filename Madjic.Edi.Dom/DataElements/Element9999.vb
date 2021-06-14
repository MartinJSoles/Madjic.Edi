Namespace DataElements
    '''<summary>Context Name</summary>
    '''<remarks>
    '''<para>Holds the name or 'tag' or a context</para>
    '''</remarks>
    Partial Friend Class Element9999
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element9999
            Dim rval As New Element9999

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace