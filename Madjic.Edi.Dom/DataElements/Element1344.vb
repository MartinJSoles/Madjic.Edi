Namespace DataElements
    '''<summary>Non-Visit Code</summary>
    '''<remarks>
    '''<para>Code indicating on what a medical evaluation is based, when not based on a physician's visit</para>
    '''</remarks>
    Partial Friend Class Element1344
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "L,N,O")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1344
            Dim rval As New Element1344

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace