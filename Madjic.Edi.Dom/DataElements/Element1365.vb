Namespace DataElements
    '''<summary>Service Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the classification of service</para>
    '''</remarks>
    Partial Friend Class Element1365
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 99*2 + 98, Nothing,
                       "1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AQ,AR,B,B1,B2,B3,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,DG,DM,DS,GF,GN,GY,IC,MH,NI,ON,PT,PU,RN,RT,TC,TN,UC")
            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1365
            Dim rval As New Element1365

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace