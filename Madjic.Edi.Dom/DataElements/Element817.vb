Namespace DataElements
    '''<summary>Tax Information Identification Number</summary>
    Partial Friend Class Element817
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element817
            Dim rval As New Element817

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace