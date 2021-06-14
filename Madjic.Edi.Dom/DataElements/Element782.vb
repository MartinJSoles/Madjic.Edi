Namespace DataElements
    '''<summary>Monetary Amount</summary>
    '''<remarks>
    '''<para>Monetary amount</para>
    '''</remarks>
    Partial Friend Class Element782
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 18)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element782
            Dim rval As New Element782

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace