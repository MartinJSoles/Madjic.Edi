Namespace DataElements
    '''<summary>Oral Cavity Designation Code</summary>
    '''<remarks>
    '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
    '''</remarks>
    Partial Friend Class Element1361
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1361
            Dim rval As New Element1361

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace