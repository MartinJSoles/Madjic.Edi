Namespace DataElements
    '''<summary>Agency Qualifier Code</summary>
    '''<remarks>
    '''<para>Code identifying the agency assigning the code values</para>
    '''</remarks>
    Partial Friend Class Element559
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,64,65,66,93,94,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AJ,AL,AM,AP,AQ,AR,AS,AT,AW,AX,AY,BA,BE,BF,BI,CA,CB,CC,CE,CI,CL,CM,CO,CP,CR,CS,CU,CX,DA,DD,DE,DF,DH,DI,DL,DN,DO,DR,DS,DX,DY,DZ,EI,EP,ES,ET,EU,EX,FA,FC,FD,FG,FH,FI,GC,GI,GS,GU,HC,HF,HI,HS,HU,IA,IB,IC,IM,IN,IS,JA,LA,LB,LI,MA,MB,MC,ME,MI,MP,MS,MV,NA,NB,NC,NE,NF,NG,NI,NP,NR,NS,NT,NU,NW,OI,OP,OS,PA,PC,PI,RN,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UA,UC,UI,UL,UN,UT,VI,WH,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element559
            Dim rval As New Element559

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace