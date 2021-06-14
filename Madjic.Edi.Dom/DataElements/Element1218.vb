Namespace DataElements
    '''<summary>Medicare Plan Code</summary>
    '''<remarks>
    '''<para>Code identifying the Medicare Plan</para>
    '''</remarks>
    Partial Friend Class Element1218
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1218
            Dim rval As New Element1218

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace