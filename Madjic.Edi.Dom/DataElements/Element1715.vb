Namespace DataElements
    '''<summary>Country Subdivision Code</summary>
    '''<remarks>
    '''<para>Code identifying the country subdivision</para>
    '''</remarks>
    Partial Friend Class Element1715
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1715
            Dim rval As New Element1715

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace