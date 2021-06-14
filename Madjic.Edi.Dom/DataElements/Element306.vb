Namespace DataElements
    '''<summary>Action Code</summary>
    '''<remarks>
    '''<para>Code indicating type of action</para>
    '''</remarks>
    Partial Friend Class Element306
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "0,00,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AP,AQ,AR,AS,AT,AV,AW,AX,B,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,C,C1,C2,CA,CB,CC,CD,CE,CF,CG,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CX,D,D1,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DP,DR,DS,DT,DX,E,EA,EB,EC,ED,EE,EN,EP,ER,EV,EX,EZ,F,F1,FA,FC,FI,FO,FR,G,GR,H,HM,HR,I,I1,IA,IM,IN,IS,IT,J,JA,JO,JU,K,KA,L,LC,LQ,M,ME,MO,N,NA,NC,ND,NP,NS,O,OD,OP,OR,OT,P,P1,PA,PB,PC,PD,PF,PI,PJ,PO,PP,PR,PS,PT,PU,PV,Q,R,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RZ,S,S1,S2,SA,SB,SC,SD,SE,SL,SR,SS,SU,SV,SZ,T,TD,TE,TG,TN,TP,TR,TS,TU,U,V,VA,W,W1,WD,WI,WQ,WV,X,Y,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element306
            Dim rval As New Element306

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace