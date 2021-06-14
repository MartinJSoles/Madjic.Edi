Namespace DataElements
    '''<summary>Construction Type</summary>
    '''<remarks>
    '''<para>Contains the primary construction material</para>
    '''</remarks>
    Partial Friend Class Element1429
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "0,1,2,3,4,5,6,7,8,9,A,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1429
            Dim rval As New Element1429

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace