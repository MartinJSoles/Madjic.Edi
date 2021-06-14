Namespace DataElements
    '''<summary>Confidentiality Code</summary>
    '''<remarks>
    '''<para>Code indicating the access to insured information</para>
    '''</remarks>
    Partial Friend Class Element1165
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "O,R,U")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1165
            Dim rval As New Element1165

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace