Namespace DataElements
    '''<summary>Special Program Code</summary>
    '''<remarks>
    '''<para>Code indicating the Special Program under which the services rendered to the patient were performed</para>
    '''</remarks>
    Partial Friend Class Element1366
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, "01,02,03,04,05,06,07,08,09,10")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1366
            Dim rval As New Element1366

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace