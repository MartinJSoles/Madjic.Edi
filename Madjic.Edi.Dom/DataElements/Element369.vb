Namespace DataElements
    '''<summary>Free-form Description</summary>
    Partial Friend Class Element369
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 45)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element369
            Dim rval As New Element369

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace