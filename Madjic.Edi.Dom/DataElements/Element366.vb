Namespace DataElements
    '''<summary>Contact Function Code</summary>
    '''<remarks>
    '''<para>Code identifying the major duty or responsibility of the person or group named</para>
    '''</remarks>
    Partial Friend Class Element366
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "1A,1B,1C,1D,1E,1F,1G,1H,1I,3A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AP,AR,AS,AT,AU,AV,AW,AX,BA,BB,BC,BD,BI,BJ,BK,BL,BM,BP,BS,BU,C1,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DC,DD,DE,DF,DI,DM,DN,DV,E1,E2,EA,EB,EC,ED,EF,EG,EM,EN,EO,EP,ES,EV,EX,FA,FB,FC,FD,FF,FL,FM,FN,FO,FP,FQ,FR,GA,GB,GC,GE,GR,HM,HR,IC,IO,IP,IS,KA,KB,KC,KP,KT,LD,LG,MA,MB,MC,MD,ME,MG,MK,ML,MM,NA,NC,NP,NT,OA,OC,OD,OS,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QA,QC,QI,QM,QP,QR,QY,RA,RB,RC,RD,RE,RF,RG,RP,RQ,RS,RZ,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SY,TA,TB,TC,TD,TE,TH,TM,TN,TP,TR,TY,UG,UP,UQ,UR,VM,VP,WH,WI,WR,WV,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element366
            Dim rval As New Element366

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace