Namespace DataElements
    '''<summary>Transaction Set Acknowledgment Code</summary>
    '''<remarks>
    '''<para>Code indicating accept or reject condition based on the syntax editing of the transaction set</para>
    '''</remarks>
    Partial Friend Class Element717
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,E,M,R,W,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element717
            Dim rval As New Element717

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace