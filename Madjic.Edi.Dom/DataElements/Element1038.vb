Namespace DataElements
    '''<summary>Name Prefix</summary>
    '''<remarks>
    '''<para>Prefix to individual name</para>
    '''</remarks>
    Partial Friend Class Element1038
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1038
            Dim rval As New Element1038

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace