Namespace DataElements
    '''<summary>Financial Information Code</summary>
    '''<remarks>
    '''<para>Code representing financial accounting information</para>
    '''</remarks>
    Partial Friend Class Element1195
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 80)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1195
            Dim rval As New Element1195

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace