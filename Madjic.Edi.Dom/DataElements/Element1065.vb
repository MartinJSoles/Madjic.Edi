Namespace DataElements
    '''<summary>Entity Type Qualifier</summary>
    '''<remarks>
    '''<para>Code qualifying the type of entity</para>
    '''</remarks>
    Partial Friend Class Element1065
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,7,8,9,A,B,C,D,E,G,L")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1065
            Dim rval As New Element1065

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace