Namespace DataElements
    '''<summary>Admission Source Code</summary>
    '''<remarks>
    '''<para>Code indicating the source of this admission</para>
    '''</remarks>
    Partial Friend Class Element1314
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1314
            Dim rval As New Element1314

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace