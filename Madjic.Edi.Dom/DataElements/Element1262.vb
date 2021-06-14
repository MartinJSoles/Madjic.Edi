Namespace DataElements
    '''<summary>Loan Type Code</summary>
    Partial Friend Class Element1262
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1262
            Dim rval As New Element1262

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace