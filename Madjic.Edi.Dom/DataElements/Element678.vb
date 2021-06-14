Namespace DataElements
    '''<summary>Ship/Delivery or Calendar Pattern Code</summary>
    '''<remarks>
    '''<para>Code which specifies the routine shipments, deliveries, or calendar pattern</para>
    '''</remarks>
    Partial Friend Class Element678
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SA,SB,SC,SD,SG,SL,SP,SX,SY,SZ,T,U,V,W,WE,X,Y,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element678
            Dim rval As New Element678

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace