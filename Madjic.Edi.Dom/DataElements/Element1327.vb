Namespace DataElements
    '''<summary>Copay Status Code</summary>
    '''<remarks>
    '''<para>Code indicating whether or not co-payment requirements were met on a line by line basis</para>
    '''</remarks>
    Partial Friend Class Element1327
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1327
            Dim rval As New Element1327

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace