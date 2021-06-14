Namespace DataElements
    '''<summary>Diagnosis Related Group (DRG) Code</summary>
    '''<remarks>
    '''<para>Code indicating a patient's diagnosis group based on a patient's illness, diseases, and medical problems</para>
    '''</remarks>
    Partial Friend Class Element1354
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 4, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1354
            Dim rval As New Element1354

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace