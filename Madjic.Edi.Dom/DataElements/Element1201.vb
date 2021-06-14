Namespace DataElements
    '''<summary>Information Status Code</summary>
    '''<remarks>
    '''<para>A code to indicate the status of information</para>
    '''</remarks>
    Partial Friend Class Element1201
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,L,O,P,S,T")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1201
            Dim rval As New Element1201

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace