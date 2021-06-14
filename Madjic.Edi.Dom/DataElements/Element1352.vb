Namespace DataElements
    '''<summary>Patient Status Code</summary>
    '''<remarks>
    '''<para>Code indicating patient status as of the "statement covers through date"</para>
    '''</remarks>
    Partial Friend Class Element1352
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1352
            Dim rval As New Element1352

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace