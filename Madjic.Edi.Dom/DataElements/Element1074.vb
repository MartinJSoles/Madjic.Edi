Namespace DataElements
    '''<summary>Type of Real Estate Asset Code</summary>
    '''<remarks>
    '''<para>Code identifying the nature of a real estate</para>
    '''</remarks>
    Partial Friend Class Element1074
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,UN,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1074
            Dim rval As New Element1074

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace