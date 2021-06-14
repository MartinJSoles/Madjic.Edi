Namespace DataElements
    '''<summary>Measurement Reference ID Code</summary>
    '''<remarks>
    '''<para>Code identifying the broad category to which a measurement applies</para>
    '''</remarks>
    Partial Friend Class Element737
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "9L,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,BA,BB,BC,BD,BL,BM,BN,BO,BP,BR,BT,BZ,C1,CA,CB,CC,CF,CG,CH,CJ,CK,CL,CM,CN,CO,CP,CQ,CS,CT,CU,CV,CW,CY,DE,DN,DT,EA,EE,EF,EL,EN,FC,FD,FH,FJ,FV,FZ,GC,GL,GO,GP,HC,HR,ID,IN,IR,LC,LD,LG,LL,LM,LP,LS,LT,MA,MB,MC,MD,ME,MF,MP,MR,NC,NE,NS,NX,OD,OG,OL,OP,P1,PA,PB,PC,PD,PI,PJ,PK,PL,PM,PO,PR,PS,PT,PU,PY,QR,QV,R1,R2,RA,RG,RL,RN,RO,RP,RQ,RS,RT,SA,SB,SC,SD,SE,SF,SH,SJ,SK,SL,SM,SP,SR,ST,SU,SZ,TA,TD,TE,TI,TL,TO,TP,TR,TS,TT,VT,WA,WR,WT,ZA,ZP")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element737
            Dim rval As New Element737

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace