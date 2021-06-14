Namespace DataElements
    '''<summary>Prescription Denial Override Code</summary>
    '''<remarks>
    '''<para>Code indicating that a pharmacist has overridden the denial of a prescription</para>
    '''</remarks>
    Partial Friend Class Element1355
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "00,01,02,03,04,05,06,07")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1355
            Dim rval As New Element1355

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace