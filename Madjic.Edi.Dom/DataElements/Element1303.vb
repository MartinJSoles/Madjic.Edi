Namespace DataElements
    '''<summary>Use of Language Indicator</summary>
    '''<remarks>
    '''<para>Code indicating the use of a language</para>
    '''</remarks>
    Partial Friend Class Element1303
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,5,6,7,8")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1303
            Dim rval As New Element1303

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace