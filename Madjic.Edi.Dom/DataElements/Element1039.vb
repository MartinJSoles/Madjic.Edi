Namespace DataElements
    '''<summary>Name Suffix</summary>
    '''<remarks>
    '''<para>Suffix to individual name</para>
    '''</remarks>
    Partial Friend Class Element1039
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1039
            Dim rval As New Element1039

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace