Namespace DataElements
    '''<summary>Trace Type Code</summary>
    '''<remarks>
    '''<para>Code identifying which transaction is being referenced</para>
    '''</remarks>
    Partial Friend Class Element481
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element481
            Dim rval As New Element481

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace