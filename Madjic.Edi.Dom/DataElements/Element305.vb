Namespace DataElements
    '''<summary>Transaction Handling Code</summary>
    '''<remarks>
    '''<para>Code designating the action to be taken by all parties</para>
    '''</remarks>
    Partial Friend Class Element305
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,X,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element305
            Dim rval As New Element305

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace