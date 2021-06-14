Namespace DataElements
    '''<summary>Identification Code Qualifier</summary>
    '''<remarks>
    '''<para>Code designating the system/method of code structure used for Identification Code (67)</para>
    '''</remarks>
    Partial Friend Class Element66
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "0,1,10,11,12,13,15,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,6,61,62,63,64,7,71,72,73,74,75,76,77,78,81,82,83,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,AA,AB,AC,AD,AE,AF,AI,AL,AP,BC,BD,BE,BG,BN,BP,BS,C,C1,C2,C5,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CP,CR,CS,CT,D,DG,DL,DN,DO,DP,DR,DS,E,EC,EH,EI,EL,EP,EQ,ER,ES,ET,F,FA,FB,FC,FD,FE,FI,FJ,FL,FN,G,GA,GC,HC,HN,HS,I,ID,II,IP,J,K,L,LC,LD,LE,LI,LN,M,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,ML,MN,MO,MP,MR,N,NA,ND,NI,NO,NR,OC,OP,PA,PB,PC,PI,PP,PR,RA,RB,RC,RD,RE,RI,RP,RT,S,SA,SB,SD,SF,SI,SJ,SK,SL,SP,ST,SV,SW,TA,TC,TL,TS,TZ,UC,UI,UL,UP,UR,US,UT,WR,WS,X1,XV,XX,XY,ZC,ZN,ZY,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element66
            Dim rval As New Element66

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace