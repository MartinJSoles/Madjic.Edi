Namespace DataElements
    '''<summary>Admission Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the priority of this admission</para>
    '''</remarks>
    Partial Friend Class Element1315
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1315
            Dim rval As New Element1315

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace