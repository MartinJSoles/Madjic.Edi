Namespace DataElements
    '''<summary>Product/Service ID Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the type/source of the descriptive number used in Product/Service ID (234)</para>
    '''</remarks>
    Partial Friend Class Element235
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "00,A1,A2,A3,A4,A5,A6,A7,A8,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8,DA,DD,DE,DF,DG,DH,DI,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E3,E4,E5,E6,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,EU,EX,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FP,FQ,FR,FS,FT,FU,FV,FW,FX,GA,GC,GD,GE,GI,GK,GM,GN,GQ,GR,GS,GU,HC,HD,HI,HN,HP,IA,IB,IC,ID,IE,IF,IG,II,IM,IN,IQ,IR,IS,IT,IV,IW,IZ,JA,JB,JC,JD,JN,JP,JS,KA,KB,KD,KE,KF,KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,L4,L5,L6,LA,LB,LC,LD,LG,LM,LN,LP,LR,LS,LT,LU,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,N1,N2,N3,N4,N5,N6,ND,NE,NG,NH,NM,NR,NU,NW,NZ,O0,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,OR,OT,OU,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TM,TN,TP,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U2,U3,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,UX,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,W6,W7,WA,WB,WC,WD,WE,WF,WG,WJ,WK,WL,WR,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element235
            Dim rval As New Element235

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace