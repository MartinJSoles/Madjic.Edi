Namespace DataElements
    '''<summary>Name</summary>
    '''<remarks>
    '''<para>Free-form name</para>
    '''</remarks>
    Partial Friend Class Element93
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 60)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element93
            Dim rval As New Element93

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace