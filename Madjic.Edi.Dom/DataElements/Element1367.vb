Namespace DataElements
    '''<summary>Subluxation Level Code</summary>
    '''<remarks>
    '''<para>Code identifying the specific level of subluxation</para>
    '''</remarks>
    Partial Friend Class Element1367
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing,
                       "C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7,T8,T9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1367
            Dim rval As New Element1367

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace