Namespace DataElements
    '''<summary>Insurance Line Code</summary>
    '''<remarks>
    '''<para>Code identifying a group of insurance products</para>
    '''</remarks>
    Partial Friend Class Element1205
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing,
                       "403,AAA,AAB,AAC,AC,ADD,AF,AG,AH,AI,AJ,AK,AM,AP,AR,AU,BC,BE,BH,BK,CC,CHU,CLF,CV,DCP,DEN,EMP,EPO,FAC,FSA,GDC,HE,HLT,HMO,IRA,IRC,LL,LTC,LTD,MM,MOD,NGD,NQ,PDG,POS,PPO,PRA,PSP,QDA,QDC,STD,UL,UR,VIS,ZZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1205
            Dim rval As New Element1205

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace