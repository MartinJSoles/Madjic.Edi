Namespace DataElements
    '''<summary>Government Service Affiliation Code</summary>
    '''<remarks>
    '''<para>Code specifying the government service affiliation</para>
    '''</remarks>
    Partial Friend Class Element1595
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,Q,R,S,U,W")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1595
            Dim rval As New Element1595

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace