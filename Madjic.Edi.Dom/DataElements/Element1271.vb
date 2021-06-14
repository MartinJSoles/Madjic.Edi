Namespace DataElements
    '''<summary>Industry Code</summary>
    '''<remarks>
    '''<para>Code indicating a code from a specific industry code list</para>
    '''</remarks>
    Partial Friend Class Element1271
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1271
            Dim rval As New Element1271

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace