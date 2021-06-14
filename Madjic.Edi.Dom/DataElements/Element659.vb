Namespace DataElements
    '''<summary>Basis of Verification Code</summary>
    '''<remarks>
    '''<para>Code indicating the basis of verification</para>
    '''</remarks>
    Partial Friend Class Element659
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element659
            Dim rval As New Element659

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace