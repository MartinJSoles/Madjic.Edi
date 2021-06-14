Namespace DataElements
    '''<summary>Provider Accept Assignment Code</summary>
    '''<remarks>
    '''<para>Code indicating whether the provider accepts assignment</para>
    '''</remarks>
    Partial Friend Class Element1359
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,P")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1359
            Dim rval As New Element1359

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace