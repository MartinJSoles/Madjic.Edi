Namespace DataElements
    '''<summary>Identification Card Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of identification card</para>
    '''</remarks>
    Partial Friend Class Element1215
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "D,E,H,P,V")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1215
            Dim rval As New Element1215

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace