Namespace DataElements
    '''<summary>Packaging Description Code</summary>
    '''<remarks>
    '''<para>A code from an industry code list which provides specific data about the marking, packaging or loading and unloading of a product</para>
    '''</remarks>
    Partial Friend Class Element754
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 7)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element754
            Dim rval As New Element754

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace