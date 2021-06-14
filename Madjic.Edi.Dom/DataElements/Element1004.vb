Namespace DataElements
    '''<summary>Percent Qualifier</summary>
    '''<remarks>
    '''<para>Code to qualify percent</para>
    '''</remarks>
    Partial Friend Class Element1004
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,62,65,66,67,68,69,7,70,71,72,73,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS,AT,AU,AV,AY,AZ,B,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BP,BS,BT,BU,C,CA,CB,CH,CJ,CN,CO,CP,CR,CS,CU,CV,D,DF,DY,E,EA,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,ET,F,FT,FV,G,GA,H,IA,IN,J,K,KA,KB,L,LM,M,MA,MN,MS,MX,N,NA,NH,O,OC,OF,OH,OP,P,PA,PB,PC,PD,PF,PH,PM,PN,PP,PR,PT,PV,PW,Q,Q1,Q2,Q3,Q4,Q5,R,RA,RB,RC,RD,RE,RF,RG,RI,RL,RO,RP,RQ,RR,RS,S,SA,SC,SD,SE,SF,SG,ST,T,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TP,TQ,TR,TS,TX,U,V,W,WI,WK,X,X1,X2,X3,X4,XT,Y,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1004
            Dim rval As New Element1004

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace