Namespace DataElements
    '''<summary>Implementation Segment Syntax Error Code</summary>
    '''<remarks>
    '''<para>Code indicating implementation error found based on the syntax editing of a segment</para>
    '''</remarks>
    Partial Friend Class Element620
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "1,2,3,4,5,6,7,8,I4,I6,I7,I8,I9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element620
            Dim rval As New Element620

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace