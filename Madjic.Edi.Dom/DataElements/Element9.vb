Namespace DataElements
    '''<summary>Late Reason Code</summary>
    '''<remarks>
    '''<para>Identifies the reason for tardiness</para>
    '''</remarks>
    Partial Friend Class Element9
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "C1,D1,D2,D3,D4,D5,D6,E1,E2,E3,E4,E5,E6,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LB")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element9
            Dim rval As New Element9

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace