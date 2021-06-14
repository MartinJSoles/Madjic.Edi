Namespace DataElements
    '''<summary>Tax Type Code</summary>
    '''<remarks>
    '''<para>Code specifying the type of tax</para>
    '''</remarks>
    Partial Friend Class Element963
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element963
            Dim rval As New Element963

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace