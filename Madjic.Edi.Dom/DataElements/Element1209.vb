Namespace DataElements
    '''<summary>Underwriting Decision Code</summary>
    '''<remarks>
    '''<para>Code indicating the decision made by the underwriter</para>
    '''</remarks>
    Partial Friend Class Element1209
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,I,N,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1209
            Dim rval As New Element1209

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace