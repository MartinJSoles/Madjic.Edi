Namespace DataElements
    '''<summary>Currency Market/Exchange Code</summary>
    '''<remarks>
    '''<para>Code identifying the market upon which the currency exchange rate is based</para>
    '''</remarks>
    Partial Friend Class Element669
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing, "IMF,LNF,LNS,NYC,PHI,ZUR")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element669
            Dim rval As New Element669

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace