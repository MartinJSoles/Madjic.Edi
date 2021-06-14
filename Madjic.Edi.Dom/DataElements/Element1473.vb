Namespace DataElements
    '''<summary>Pricing Methodology</summary>
    '''<remarks>
    '''<para>Code specifying pricing methodology at which the claim or line item has been priced or repriced</para>
    '''</remarks>
    Partial Friend Class Element1473
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "00,01,02,03,04,05,06,07,08,09,10,11,12,13,14")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1473
            Dim rval As New Element1473

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace