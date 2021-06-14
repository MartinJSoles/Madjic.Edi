Namespace DataElements
    '''<summary>Ship/Delivery Pattern Time Code</summary>
    '''<remarks>
    '''<para>Code which specifies the time for routine shipments or deliveries</para>
    '''</remarks>
    Partial Friend Class Element679
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,F,G,Y,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element679
            Dim rval As New Element679

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace