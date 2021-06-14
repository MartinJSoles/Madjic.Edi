Namespace DataElements
    '''<summary>Element Position in Segment</summary>
    '''<remarks>
    '''<para>This is used to indicate the relative position of a simple data element, or the relative position or a composite data structure with the relative position of the component within the composite data structure, in error; in the data segment the count starts with 1 for the simple data element or composite data structure immediately followign the segment ID</para>
    '''</remarks>
    Partial Friend Class Element722
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element722
            Dim rval As New Element722

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace