Namespace DataElements
    '''<summary>Country Code</summary>
    '''<remarks>
    '''<para>Code identifying the country</para>
    '''</remarks>
    Partial Friend Class Element26
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element26
            Dim rval As New Element26

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace