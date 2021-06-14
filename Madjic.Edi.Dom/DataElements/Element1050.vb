Namespace DataElements
    '''<summary>Taxpayer Verification</summary>
    Partial Friend Class Element1050
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1050
            Dim rval As New Element1050

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace