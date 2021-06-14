Namespace DataElements
    '''<summary>Payer Responsibility Sequence Number Code</summary>
    '''<remarks>
    '''<para>Code identifying the insurance carrier's level of responsibility for a payment of a claim</para>
    '''</remarks>
    Partial Friend Class Element1138
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,F,G,H,N,O,P,S,T,U")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1138
            Dim rval As New Element1138

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace