Namespace DataElements
    '''<summary>Claim Submission Reason Code</summary>
    '''<remarks>
    '''<para>Code identifying reason for claim submission</para>
    '''</remarks>
    Partial Friend Class Element1383
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1383
            Dim rval As New Element1383

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace