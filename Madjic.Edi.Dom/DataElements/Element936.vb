Namespace DataElements
    '''<summary>Measurement Attribute Code</summary>
    '''<remarks>
    '''<para>Code used to express an attribute response when a numeric measurement value cannot be determined</para>
    '''</remarks>
    Partial Friend Class Element936
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,40,41,42,44,45,46,48,49,50,51,52,53,54,56,BA,FL,NA,ND,NS,PR,Q1,Q2,TA,TB,WS,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element936
            Dim rval As New Element936

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace