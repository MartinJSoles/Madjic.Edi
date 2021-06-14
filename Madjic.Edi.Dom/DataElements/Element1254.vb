Namespace DataElements
    '''<summary>Immunization Status Code</summary>
    '''<remarks>
    '''<para>Code indicating the status of an immunization conducted on a person</para>
    '''</remarks>
    Partial Friend Class Element1254
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,10,11,12,13,14,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1254
            Dim rval As New Element1254

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace