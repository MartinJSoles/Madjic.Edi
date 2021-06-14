Namespace DataElements
    '''<summary>Military Service Rank Code</summary>
    '''<remarks>
    '''<para>Code specifying the military service rank</para>
    '''</remarks>
    Partial Friend Class Element1596
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "A1,A2,A3,B1,B2,C1,C2,C3,C4,C5,C6,C7,C8,C9,E1,F1,F2,F3,F4,G1,G4,L1,L2,L3,L4,L5,L6,M1,M2,M3,M4,M5,M6,P1,P2,P3,P4,P5,R1,R2,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,T1,V1,W1")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1596
            Dim rval As New Element1596

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace