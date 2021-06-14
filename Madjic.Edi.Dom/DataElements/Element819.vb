Namespace DataElements
    '''<summary>Language Code</summary>
    '''<remarks>
    '''<para>Code designating the language used in text, from a standard code list maintained by the International Standards Organization (ISO 639)</para>
    '''</remarks>
    Partial Friend Class Element819
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element819
            Dim rval As New Element819

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace