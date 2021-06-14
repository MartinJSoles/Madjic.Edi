Namespace DataElements
    '''<summary>Hierarchical Level Code</summary>
    '''<remarks>
    '''<para>Code defining the characteristic of a level in a hierarchical structure</para>
    '''</remarks>
    Partial Friend Class Element735
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "0,1,19,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,8,9,A,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AP,AS,AT,B,BD,BE,BP,C,CB,CC,CE,CH,CI,CL,CN,CO,CP,CT,CV,D,DG,DM,DP,DS,E,EB,EC,ED,EF,EG,EH,EI,EL,EM,EN,EV,EX,F,FC,FG,FI,FL,FR,G,GC,GP,GW,H,I,IA,IB,IC,IN,IS,IT,IV,J,JU,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KV,KW,KX,L,LD,LN,LP,M,ML,N,NI,NS,O,OS,P,PA,PB,PC,PD,PE,PH,PI,PK,PL,PP,PR,PS,PT,PY,Q,R,RA,RB,RC,RD,RE,RF,RG,RH,RL,RM,RP,S,S1,S2,S3,SA,SB,SC,SD,SE,SF,SG,SH,SI,SL,SP,SR,SS,ST,SY,T,TA,TD,TI,TS,TU,TX,U,UT,V,VI,W,WB,WC,WL,WP,WR,X,Y,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element735
            Dim rval As New Element735

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace