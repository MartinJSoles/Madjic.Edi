Namespace DataElements
    '''<summary>Transaction Set Purpose Code</summary>
    '''<remarks>
    '''<para>Code identifying purpose of transaction set</para>
    '''</remarks>
    Partial Friend Class Element353
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,5C,77,CN,CO,EX,GR,PR,RH,RV,SU,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element353
            Dim rval As New Element353

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace