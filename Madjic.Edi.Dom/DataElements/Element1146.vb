Namespace DataElements
    '''<summary>Disability Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the disability status of the individual</para>
    '''</remarks>
    Partial Friend Class Element1146
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1146
            Dim rval As New Element1146

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace