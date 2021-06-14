Namespace DataElements
    '''<summary>Segment Position in Transaction Set</summary>
    '''<remarks>
    '''<para>The numerical count position of this data segment from the start of the transaction set; the transaction set header is count position 1</para>
    '''</remarks>
    Partial Friend Class Element719
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element719
            Dim rval As New Element719

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace