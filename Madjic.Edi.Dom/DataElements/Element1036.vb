Namespace DataElements
    '''<summary>Name First</summary>
    '''<remarks>
    '''<para>Individual first name</para>
    '''</remarks>
    Partial Friend Class Element1036
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1036
            Dim rval As New Element1036

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace