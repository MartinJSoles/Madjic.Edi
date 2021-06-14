Namespace DataElements
    '''<summary>Implementation Transaction Set Syntax Error Code</summary>
    '''<remarks>
    '''<para>Code indicating implementation error found based on the syntax editing of a transaction set</para>
    '''</remarks>
    Partial Friend Class Element618
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "1,10,11,12,13,15,16,17,19,2,23,24,25,26,27,3,4,5,6,7,8,9,I6")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element618
            Dim rval As New Element618

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace