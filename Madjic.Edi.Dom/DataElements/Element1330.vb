Namespace DataElements
    '''<summary>Dosage Form Code</summary>
    '''<remarks>
    '''<para>Code indicating the form in which the drug is dispensed</para>
    '''</remarks>
    Partial Friend Class Element1330
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,10,11,12,13,14,15,16,20,21,22,23,24,25,30,31,32,33,34,40,41,42,43,50,51,52,53,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,90,91,92,93,94,95,96,97,98,99")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1330
            Dim rval As New Element1330

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace