Namespace DataElements
    '''<summary>Basis of Unit Price Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of unit price for an item</para>
    '''</remarks>
    Partial Friend Class Element639
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "AA,AB,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,EH,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element639
            Dim rval As New Element639

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace