Namespace DataElements
    '''<summary>Benefit Status Code</summary>
    '''<remarks>
    '''<para>The type of coverage under which benefits are paid</para>
    '''</remarks>
    Partial Friend Class Element1216
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,C,I,S,T,V")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1216
            Dim rval As New Element1216

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace