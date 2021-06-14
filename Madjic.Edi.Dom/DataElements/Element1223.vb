Namespace DataElements
    '''<summary>Provider Organization Code</summary>
    '''<remarks>
    '''<para>Code identifying the organizational structure of a provider</para>
    '''</remarks>
    Partial Friend Class Element1223
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing, "001,002,003,004,005,006,007,008")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1223
            Dim rval As New Element1223

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace