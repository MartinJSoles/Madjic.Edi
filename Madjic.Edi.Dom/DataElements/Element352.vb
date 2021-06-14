Namespace DataElements
    '''<summary>Description</summary>
    '''<remarks>
    '''<para>A free-form description to clarify the related data elements and their content</para>
    '''</remarks>
    Partial Friend Class Element352
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 80)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element352
            Dim rval As New Element352

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace