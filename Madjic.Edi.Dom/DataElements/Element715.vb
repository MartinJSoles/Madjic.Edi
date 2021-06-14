Namespace DataElements
    '''<summary>Functional Group Acknowledgment Code</summary>
    '''<remarks>
    '''<para>Code indicating accept or reject condition based on the syntax editing of the functional group</para>
    '''</remarks>
    Partial Friend Class Element715
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,E,M,P,R,W,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element715
            Dim rval As New Element715

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace