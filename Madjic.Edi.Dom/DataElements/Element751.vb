Namespace DataElements
    '''<summary>Product Description Code</summary>
    '''<remarks>
    '''<para>A code from an industry code list which provides specific data about a product characteristic</para>
    '''</remarks>
    Partial Friend Class Element751
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 12)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element751
            Dim rval As New Element751

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace