Namespace DataElements
    '''<summary>Originating Company Supplemental Code</summary>
    '''<remarks>
    '''<para>A code defined between the originating company and the originating depository financial institution (ODFI) that uniquely identifies the company initiating the transfer instructions</para>
    '''</remarks>
    Partial Friend Class Element510
        Inherits StringElement

        Public Sub New()
            MyBase.New(9, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element510
            Dim rval As New Element510

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace