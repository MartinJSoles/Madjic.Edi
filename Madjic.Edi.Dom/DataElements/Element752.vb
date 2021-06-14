Namespace DataElements
    '''<summary>Surface/Layer/Position Code</summary>
    '''<remarks>
    '''<para>Code indicating the product surface, layer or position that is being described</para>
    '''</remarks>
    Partial Friend Class Element752
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "1S,2S,A1,A2,A3,A4,A5,A6,A7,A8,A9,AL,AO,AS,B1,BC,BI,BK,BL,BR,BS,BT,CH,CT,DO,DT,DU,EX,FR,FS,GF,IN,IT,KB,LC,LO,LT,M1,MC,MD,NS,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UN,UP,UT,WF")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element752
            Dim rval As New Element752

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace