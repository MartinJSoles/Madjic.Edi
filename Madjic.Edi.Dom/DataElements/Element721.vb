Namespace DataElements
    '''<summary>Segment ID Code</summary>
    '''<remarks>
    '''<para>Code identifying the segment ID of the data segment in error (See Appendix A - Number 77)</para>
    '''</remarks>
    Partial Friend Class Element721
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element721
            Dim rval As New Element721

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace