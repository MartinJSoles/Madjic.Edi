Namespace DataElements
    '''<summary>Version Identifier</summary>
    '''<remarks>
    '''<para>Revision level of a particular format, program, technique or algorithm</para>
    '''</remarks>
    Partial Friend Class Element799
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element799
            Dim rval As New Element799

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace