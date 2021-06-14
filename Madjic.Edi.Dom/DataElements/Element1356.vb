Namespace DataElements
    '''<summary>Prescription Origin Code</summary>
    '''<remarks>
    '''<para>Code indicating the origin of a prescription</para>
    '''</remarks>
    Partial Friend Class Element1356
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1356
            Dim rval As New Element1356

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace