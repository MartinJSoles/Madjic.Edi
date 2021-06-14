Namespace DataElements
    '''<summary>Hierarchical ID Number</summary>
    '''<remarks>
    '''<para>A unique number assigned by the sender to identify a particular data segment in a hierarchical structure</para>
    '''</remarks>
    Partial Friend Class Element628
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 12)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element628
            Dim rval As New Element628

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace