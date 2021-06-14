Namespace DataElements
    '''<summary>Category</summary>
    Partial Friend Class Element729
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element729
            Dim rval As New Element729

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace