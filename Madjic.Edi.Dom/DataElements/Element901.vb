Namespace DataElements
    '''<summary>Reject Reason Code</summary>
    '''<remarks>
    '''<para>Code assigned by issuer to identify reason for rejection</para>
    '''</remarks>
    Partial Friend Class Element901
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,95,96,97,98,AA,AB,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AR,BA,BC,BD,BG,BL,BO,BP,BR,BS,BV,BW,CA,CB,CI,CL,CM,CN,CP,CR,CS,CT,CU,CW,DD,DG,DM,DP,DR,DS,DV,E1,E2,E3,E4,E5,E6,E7,E8,EA,ER,ET,FD,FR,GS,HB,HH,HX,IA,ID,II,IP,KR,LK,LS,LW,MA,MO,NC,OG,OI,OR,OV,PM,RB,RD,RF,RH,RK,RL,RN,RP,RS,RT,SC,ST,SU,SW,T1,T2,T3,T4,T5,T6,TC,TD,TH,TL,TR,UC,UF,UG,WA,WK,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element901
            Dim rval As New Element901

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace