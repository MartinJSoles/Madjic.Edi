Namespace DataElements
    '''<summary>Copy of Bad Data Element</summary>
    '''<remarks>
    '''<para>This is a copy of the data element in error</para>
    '''</remarks>
    Partial Friend Class Element724
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 99)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element724
            Dim rval As New Element724

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace