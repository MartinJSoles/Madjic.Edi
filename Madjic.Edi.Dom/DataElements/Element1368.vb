Namespace DataElements
    '''<summary>Tooth Status Code</summary>
    '''<remarks>
    '''<para>Code specifying the status of the tooth</para>
    '''</remarks>
    Partial Friend Class Element1368
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "E,I,M,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1368
            Dim rval As New Element1368

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace