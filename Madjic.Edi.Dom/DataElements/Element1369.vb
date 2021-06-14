Namespace DataElements
    '''<summary>Tooth Surface Code</summary>
    '''<remarks>
    '''<para>Code identifying the area of the tooth that was treated</para>
    '''</remarks>
    Partial Friend Class Element1369
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "B,D,F,I,L,M,O")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1369
            Dim rval As New Element1369

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace