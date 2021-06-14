Namespace DataElements
    '''<summary>Claim Submitter's Identifier</summary>
    '''<remarks>
    '''<para>Identifier used to track a claim from creation by the health care provider through payment</para>
    '''</remarks>
    Partial Friend Class Element1028
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 38)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1028
            Dim rval As New Element1028

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace