Namespace DataElements
    '''<summary>Nursing Home Residential Status Code</summary>
    '''<remarks>
    '''<para>Code specifying the status of a nursing home resident at the time of service</para>
    '''</remarks>
    Partial Friend Class Element1345
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1345
            Dim rval As New Element1345

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace