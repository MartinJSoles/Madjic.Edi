Namespace DataElements
    '''<summary>Oxygen Equipment Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the specific type of equipment being prescribed for the delivery of oxygen</para>
    '''</remarks>
    Partial Friend Class Element1348
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,O")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1348
            Dim rval As New Element1348

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace