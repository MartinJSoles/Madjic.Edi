Namespace DataElements
    '''<summary>Tax Exempt Code</summary>
    '''<remarks>
    '''<para>Code identifying exemption status from sales and use tax</para>
    '''</remarks>
    Partial Friend Class Element441
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element441
            Dim rval As New Element441

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace