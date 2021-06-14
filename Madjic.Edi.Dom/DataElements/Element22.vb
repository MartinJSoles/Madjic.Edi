Namespace DataElements
    '''<summary>Commodity Code</summary>
    '''<remarks>
    '''<para>Code describing a commodity or group of commodities</para>
    '''</remarks>
    Partial Friend Class Element22
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element22
            Dim rval As New Element22

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace