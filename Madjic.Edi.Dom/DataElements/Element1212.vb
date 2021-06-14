Namespace DataElements
    '''<summary>Health-Related Code</summary>
    '''<remarks>
    '''<para>Code indicating a specific health situation</para>
    '''</remarks>
    Partial Friend Class Element1212
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "N,S,T,U,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1212
            Dim rval As New Element1212

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace