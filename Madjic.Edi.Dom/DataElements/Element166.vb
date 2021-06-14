Namespace DataElements
    '''<summary>Address Information</summary>
    '''<remarks>
    '''<para>Address information</para>
    '''</remarks>
    Partial Friend Class Element166
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 55)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element166
            Dim rval As New Element166

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace