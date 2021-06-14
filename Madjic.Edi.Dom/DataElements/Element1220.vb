Namespace DataElements
    '''<summary>Student Status Code</summary>
    '''<remarks>
    '''<para>Code indicating the student status of the patient if 19 years of age or older, not handicapped and not the insured</para>
    '''</remarks>
    Partial Friend Class Element1220
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "F,N,P")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1220
            Dim rval As New Element1220

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace