Namespace DataElements
    '''<summary>Implant Type Code</summary>
    '''<remarks>
    '''<para>Code identifying implant components</para>
    '''</remarks>
    Partial Friend Class Element1403
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1403
            Dim rval As New Element1403

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace