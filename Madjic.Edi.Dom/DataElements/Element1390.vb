Namespace DataElements
    '''<summary>Eligibility or Benefit Information Code</summary>
    '''<remarks>
    '''<para>Code identifying eligibility or benefit information</para>
    '''</remarks>
    Partial Friend Class Element1390
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,2,3,4,5,6,7,8,A,AA,AB,AC,B,C,CB,D,E,F,G,H,I,J,K,L,M,MC,N,O,P,Q,R,S,T,U,V,W,WV,X,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1390
            Dim rval As New Element1390

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace