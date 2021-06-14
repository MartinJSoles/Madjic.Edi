Namespace DataElements
    '''<summary>Patient Signature Source Code</summary>
    '''<remarks>
    '''<para>Code indicating how the patient or subscriber authorization signatures were obtained and how they are being retained by the provider</para>
    '''</remarks>
    Partial Friend Class Element1351
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "B,C,M,P,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1351
            Dim rval As New Element1351

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace