Namespace DataElements
    '''<summary>Implant Status Code</summary>
    '''<remarks>
    '''<para>Code identifying the status of implant components</para>
    '''</remarks>
    Partial Friend Class Element1404
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1404
            Dim rval As New Element1404

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace