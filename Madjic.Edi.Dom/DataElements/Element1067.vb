Namespace DataElements
    '''<summary>Marital Status Code</summary>
    '''<remarks>
    '''<para>Code defining the marital status of a person</para>
    '''</remarks>
    Partial Friend Class Element1067
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,I,K,M,R,S,U,W,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1067
            Dim rval As New Element1067

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace