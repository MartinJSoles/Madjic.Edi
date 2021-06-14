Namespace DataElements
    '''<summary>Volume Unit Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the volume unit</para>
    '''</remarks>
    Partial Friend Class Element184
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "B,C,D,E,F,G,H,L,M,N,R,S,T,U,V,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element184
            Dim rval As New Element184

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace