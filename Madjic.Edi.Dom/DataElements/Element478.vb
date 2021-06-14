Namespace DataElements
    '''<summary>Credit/Debit Flag Code</summary>
    '''<remarks>
    '''<para>Code indicating whether amount is a credit or debit</para>
    '''</remarks>
    Partial Friend Class Element478
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "C,D")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element478
            Dim rval As New Element478

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace