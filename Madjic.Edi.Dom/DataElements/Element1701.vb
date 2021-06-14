Namespace DataElements
    '''<summary>Eligibility Reason Code</summary>
    '''<remarks>
    '''<para>Code specifying reason for eligibility</para>
    '''</remarks>
    Partial Friend Class Element1701
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1701
            Dim rval As New Element1701

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace