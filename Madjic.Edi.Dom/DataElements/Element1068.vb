Namespace DataElements
    '''<summary>Gender Code</summary>
    '''<remarks>
    '''<para>Code indicating the sex of the individual</para>
    '''</remarks>
    Partial Friend Class Element1068
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,F,M,N,U,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1068
            Dim rval As New Element1068

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace