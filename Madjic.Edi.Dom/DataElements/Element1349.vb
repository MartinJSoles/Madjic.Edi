Namespace DataElements
    '''<summary>Oxygen Test Condition Code</summary>
    '''<remarks>
    '''<para>Code indicating the conditions under which a patient was tested</para>
    '''</remarks>
    Partial Friend Class Element1349
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "E,N,O,R,S,W,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1349
            Dim rval As New Element1349

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace