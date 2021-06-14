Namespace DataElements
    '''<summary>Implementation Convention Reference</summary>
    '''<remarks>
    '''<para>Reference assigned to identify Implementation Convention</para>
    '''</remarks>
    Partial Friend Class Element1705
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1705
            Dim rval As New Element1705

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace