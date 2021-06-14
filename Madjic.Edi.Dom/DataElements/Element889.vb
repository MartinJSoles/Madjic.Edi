Namespace DataElements
    '''<summary>Follow-up Action Code</summary>
    '''<remarks>
    '''<para>Code identifying follow-up actions allowed</para>
    '''</remarks>
    Partial Friend Class Element889
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "C,D,E,N,P,R,S,W,X,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element889
            Dim rval As New Element889

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace