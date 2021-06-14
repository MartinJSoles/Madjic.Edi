Namespace DataElements
    '''<summary>Adjustment Reason Code Characteristic</summary>
    '''<remarks>
    '''<para>Specifies an additional characteristic of the adjustment reason</para>
    '''</remarks>
    Partial Friend Class Element1129
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,10,11,12,13,14,15,16,17,18,19,2,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,5,57,58,6,60,61,62,63,64,65,66,67,69,7,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C6,C7,C8,C9,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E9,F1,F2,F3,F4,F5,F6,F7,F8,F9,G2,G3,G4,G5,G6,G7,G9,H2,H3,H4,H5,H6,H7")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1129
            Dim rval As New Element1129

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace