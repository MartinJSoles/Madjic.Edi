Namespace DataElements
    '''<summary>Relationship Code</summary>
    '''<remarks>
    '''<para>Code indicating the relationship between entities</para>
    '''</remarks>
    Partial Friend Class Element662
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,D,I,O,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element662
            Dim rval As New Element662

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace