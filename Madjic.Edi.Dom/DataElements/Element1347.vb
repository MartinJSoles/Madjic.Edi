Namespace DataElements
    '''<summary>Nutrient Administration Technique Code</summary>
    '''<remarks>
    '''<para>Code indicating the technique used to administer nutrient to a patient</para>
    '''</remarks>
    Partial Friend Class Element1347
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "G,J,N,O")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1347
            Dim rval As New Element1347

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace