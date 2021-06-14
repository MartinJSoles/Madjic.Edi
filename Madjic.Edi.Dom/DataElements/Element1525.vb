Namespace DataElements
    '''<summary>Request Category Code</summary>
    '''<remarks>
    '''<para>Code indicating a type of request</para>
    '''</remarks>
    Partial Friend Class Element1525
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "AR,BA,HS,IN,PR,RE,SC")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1525
            Dim rval As New Element1525

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace