Namespace DataElements
    '''<summary>Occupation Code</summary>
    '''<remarks>
    '''<para>Code identifying the occupation of an individual</para>
    '''</remarks>
    Partial Friend Class Element1149
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(4, 6, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1149
            Dim rval As New Element1149

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace