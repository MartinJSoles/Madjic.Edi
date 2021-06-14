Namespace DataElements
    '''<summary>Non-Institutional Claim Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of provider or claim</para>
    '''</remarks>
    Partial Friend Class Element1343
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "A,AA,AM,AN,CF,CH,CS,DA,DD,DM,DN,ER,HH,HS,IF,IL,L,LT,MD,MF,MH,MI,MO,MS,NM,NP,NS,O,OC,OP,OT,OX,P,PA,PD,PE,PF,PS,PT,RX,S,SC,SN,ST,T,TX,V")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1343
            Dim rval As New Element1343

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace