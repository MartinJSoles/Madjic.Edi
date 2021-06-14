Namespace DataElements
    '''<summary>Claim Filing Indicator Code</summary>
    '''<remarks>
    '''<para>Code identifying type of claim</para>
    '''</remarks>
    Partial Friend Class Element1032
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,31,32,33,AM,BL,CH,CI,CN,DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1032
            Dim rval As New Element1032

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace