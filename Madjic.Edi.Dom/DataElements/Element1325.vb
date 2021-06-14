Namespace DataElements
    '''<summary>Claim Frequency Type Code</summary>
    '''<remarks>
    '''<para>Code specifying the frequency of the claim; this is the third position of the Uniform Billing Claim Form Bill Type</para>
    '''</remarks>
    Partial Friend Class Element1325
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1325
            Dim rval As New Element1325

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace