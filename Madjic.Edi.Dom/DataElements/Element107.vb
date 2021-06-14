Namespace DataElements
    '''<summary>Payment Method Type Code</summary>
    '''<remarks>
    '''<para>Code identifying type of payment procedures</para>
    '''</remarks>
    Partial Friend Class Element107
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,8,A,AA,AB,AC,AD,AE,AF,AG,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element107
            Dim rval As New Element107

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace