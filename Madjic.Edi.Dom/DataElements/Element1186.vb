Namespace DataElements
    '''<summary>Type of Income Code</summary>
    '''<remarks>
    '''<para>Code defining the nature or source of income</para>
    '''</remarks>
    Partial Friend Class Element1186
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1186
            Dim rval As New Element1186

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace