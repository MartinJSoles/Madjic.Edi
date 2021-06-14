Namespace DataElements
    '''<summary>Release of Information Code</summary>
    '''<remarks>
    '''<para>Code indicating whether the provider has on file a signed statement by the patient authorizing the release of medical data to other organizations</para>
    '''</remarks>
    Partial Friend Class Element1363
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,I,M,N,O,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1363
            Dim rval As New Element1363

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace