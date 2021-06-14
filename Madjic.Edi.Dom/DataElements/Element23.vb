Namespace DataElements
    '''<summary>Commodity Code Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the commodity coding system used for Commodity Code</para>
    '''</remarks>
    Partial Friend Class Element23
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,2,3,4,5,A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,Q,R,S,T,U,V,W,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element23
            Dim rval As New Element23

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace