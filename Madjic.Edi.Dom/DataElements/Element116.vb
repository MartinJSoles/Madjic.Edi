Namespace DataElements
    '''<summary>Postal Code</summary>
    '''<remarks>
    '''<para>Code defining international postal zone code excluding punctuation and blanks (zip code for United States)</para>
    '''</remarks>
    Partial Friend Class Element116
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 15, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element116
            Dim rval As New Element116

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace