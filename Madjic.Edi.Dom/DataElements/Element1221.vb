Namespace DataElements
    '''<summary>Provider Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of provider</para>
    '''</remarks>
    Partial Friend Class Element1221
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "AD,AS,AT,BI,BS,CO,CV,H,HH,LA,ON,OP,OR,OT,P1,P2,PC,PE,PT,PU,R,RF,RP,SB,SK,SU")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1221
            Dim rval As New Element1221

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace