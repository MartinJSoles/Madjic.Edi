Namespace DataElements
    '''<summary>Type of Deduction</summary>
    Partial Friend Class Element1511
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1511
            Dim rval As New Element1511

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace