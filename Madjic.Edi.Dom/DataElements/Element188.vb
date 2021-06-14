Namespace DataElements
    '''<summary>Weight Unit Code</summary>
    '''<remarks>
    '''<para>Code specifying the weight unit</para>
    '''</remarks>
    Partial Friend Class Element188
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "E,G,K,L,M,O,S,T")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element188
            Dim rval As New Element188

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace