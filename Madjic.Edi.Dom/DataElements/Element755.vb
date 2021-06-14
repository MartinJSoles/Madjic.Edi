Namespace DataElements
    '''<summary>Report Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the title or contents of a document, report or supporting item</para>
    '''</remarks>
    Partial Friend Class Element755
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,BA,BB,BC,BE,BF,BL,BM,BN,BO,BR,BS,BT,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DQ,DR,DS,DT,DU,DV,DW,E1,EA,EB,EC,ED,EH,EL,EP,ER,ES,EX,EY,F1,F2,F3,F4,F5,F6,F7,F8,F9,FB,FC,FD,FE,FH,FI,FM,FO,FR,FS,G1,G2,G3,G4,G5,G6,G7,GP,GT,HC,HI,HP,HR,HW,I2,I3,I4,I5,I6,IA,IC,IM,IN,IP,IR,IS,IT,IU,IV,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,JM,JN,JO,JP,JQ,JR,JS,JT,JV,JW,JX,JY,JZ,KA,KC,KD,KE,KF,KG,KH,KI,KJ,KY,KZ,LA,LB,LC,LD,LE,LG,LI,LO,LP,LR,LS,LT,LW,M1,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MV,MZ,NA,NC,ND,NI,NL,NM,NN,NO,NQ,NR,NT,OB,OC,OD,OE,OL,OP,OR,OS,OT,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PV,PW,PX,PY,PZ,QC,QD,QE,QM,QR,QS,QT,R1,R2,R3,R4,R5,R6,R7,R9,RA,RB,RC,RD,RE,RF,RG,RH,RM,RN,RO,RR,RT,RV,RX,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,T1,T2,T3,T4,T5,T6,T7,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TX,U1,UA,UB,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UU,UV,UX,UY,UZ,V1,V2,V3,V4,V5,V6,V7,VA,VC,VD,VM,W1,W2,WA,WB,WC,WD,WE,WF,WG,WH,WI,WP,WT,X1,X2,X3,X4,X5,XE,XP,Y1,Y2,Y3,ZA,ZB,ZC,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element755
            Dim rval As New Element755

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace