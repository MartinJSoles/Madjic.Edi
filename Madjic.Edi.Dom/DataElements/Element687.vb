Namespace DataElements
    '''<summary>Class of Trade Code</summary>
    '''<remarks>
    '''<para>Code indicating class of trade</para>
    '''</remarks>
    Partial Friend Class Element687
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AQ,AR,AS,BG,BR,CB,CN,CO,CR,CX,CY,DE,DF,DI,DR,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF,ML,OE,OF,ON,PF,PH,PT,PY,RS,SA,SB,SE,ST,TR,WA,WC,WH,WS")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element687
            Dim rval As New Element687

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace