Namespace DataElements
    '''<summary>Ownership Code</summary>
    '''<remarks>
    '''<para>Code indicating the relationship of equipment to carrier or ownership of equipment</para>
    '''</remarks>
    Partial Friend Class Element102
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "L,N,R,S,T")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element102
            Dim rval As New Element102

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace