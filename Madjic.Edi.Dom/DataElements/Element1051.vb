Namespace DataElements
    '''<summary>Tax Amount</summary>
    Partial Friend Class Element1051
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 2, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1051
            Dim rval As New Element1051

            rval.Value = fullElement.ToDecimal(2)
            Return rval
        End Function
    End Class
End NameSpace