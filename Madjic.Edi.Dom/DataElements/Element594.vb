Namespace DataElements
    '''<summary>Frequency Code</summary>
    '''<remarks>
    '''<para>Code indicating frequency or type of activities or actions being reported</para>
    '''</remarks>
    Partial Friend Class Element594
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,Q,S,U,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element594
            Dim rval As New Element594

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace