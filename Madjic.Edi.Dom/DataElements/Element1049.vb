Namespace DataElements
    '''<summary>Tax Payment Type Code</summary>
    Partial Friend Class Element1049
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 5, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1049
            Dim rval As New Element1049

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace