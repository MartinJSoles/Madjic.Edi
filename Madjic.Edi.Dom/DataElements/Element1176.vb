Namespace DataElements
    '''<summary>Employment Class Code</summary>
    '''<remarks>
    '''<para>Code indicating category of employee</para>
    '''</remarks>
    Partial Friend Class Element1176
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,ZY,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1176
            Dim rval As New Element1176

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace