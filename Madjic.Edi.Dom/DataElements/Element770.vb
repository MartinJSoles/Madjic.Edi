Namespace DataElements
    '''<summary>Option Number</summary>
    '''<remarks>
    '''<para>A unique number identifying available promotion or allowance options when more than one is offered</para>
    '''</remarks>
    Partial Friend Class Element770
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element770
            Dim rval As New Element770

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace