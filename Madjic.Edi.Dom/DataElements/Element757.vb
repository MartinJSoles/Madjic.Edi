Namespace DataElements
    '''<summary>Report Copies Needed</summary>
    '''<remarks>
    '''<para>The number of copies of a report that should be sent to the addressee</para>
    '''</remarks>
    Partial Friend Class Element757
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element757
            Dim rval As New Element757

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace