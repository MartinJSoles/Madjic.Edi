Namespace DataElements
    '''<summary>Coordination of Benefits Code</summary>
    '''<remarks>
    '''<para>Code identifying whether there is a coordination of benefits</para>
    '''</remarks>
    Partial Friend Class Element1143
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1143
            Dim rval As New Element1143

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace