Namespace DataElements
    '''<summary>Participant Status Code</summary>
    '''<remarks>
    '''<para>Code indicating the status of an individual in a benefit plan</para>
    '''</remarks>
    Partial Friend Class Element1295
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "A,AN,AV,C,CD,D,DB,DN,DP,DR,DV,EL,GA,KP,N,PD,PF,R,RT,S,S1,S2,TD,TN,TR,TS,TV,US")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1295
            Dim rval As New Element1295

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace