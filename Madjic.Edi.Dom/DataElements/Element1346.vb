Namespace DataElements
    '''<summary>Nutrient Administration Method Code</summary>
    '''<remarks>
    '''<para>Code indicating the method used to administer nutrient to a patient</para>
    '''</remarks>
    Partial Friend Class Element1346
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "G,P,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1346
            Dim rval As New Element1346

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace