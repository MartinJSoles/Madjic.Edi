Namespace DataElements
    '''<summary>Context Reference</summary>
    '''<remarks>
    '''<para>Holds a reference to or for a context</para>
    '''</remarks>
    Partial Friend Class Element9998
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element9998
            Dim rval As New Element9998

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace