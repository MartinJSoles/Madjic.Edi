Namespace DataElements
    '''<summary>Tax Jurisdiction Code Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the source of the data used in tax jurisdiction code</para>
    '''</remarks>
    Partial Friend Class Element955
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "CD,MB,SP,ST,VD,VE")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element955
            Dim rval As New Element955

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace