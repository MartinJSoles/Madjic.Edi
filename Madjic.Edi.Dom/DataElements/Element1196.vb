Namespace DataElements
    '''<summary>Breakdown Structure Detail Code</summary>
    '''<remarks>
    '''<para>Codes identifying details relating to a reporting breakdown structure tree</para>
    '''</remarks>
    Partial Friend Class Element1196
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1196
            Dim rval As New Element1196

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace