Namespace DataElements
    '''<summary>Code Category</summary>
    '''<remarks>
    '''<para>Specifies the situation or category to which the code applies</para>
    '''</remarks>
    Partial Friend Class Element1136
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DR,DV,E1,E2,E3,E4,E5,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,ER,ET,FA,FC,FH,FI,FL,FP,FR,FT,GD,GS,GU,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HY,HZ,IC,ID,IH,IM,IN,LA,LC,LE,LI,LL,LR,LS,LT,LZ,MA,MI,ML,MN,MO,MP,MS,MT,NC,NL,NS,NW,OA,OC,OF,OI,ON,OP,OT,OU,PA,PB,PC,PD,PE,PF,PG,PI,PJ,PN,PO,PR,PS,PT,PX,R1,R2,R3,R4,R5,RC,RE,RI,RL,RM,RN,RP,RR,RS,RT,RU,RV,S1,S2,S3,S4,S5,SA,SD,SE,SI,SJ,SL,SN,SP,SR,SS,ST,SU,SW,SZ,TB,TE,TF,TH,TI,TM,TN,TP,TR,TW,TX,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,VA,VD,VO,WA,WB,WD,WE,WF,WG,WH,WI,WK,WL,WM,WN,WO,WP,WQ,WR,WS,WT,X1,X2,X3,X4,X5,X6,X7,X8,YR,YT,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1136
            Dim rval As New Element1136

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace