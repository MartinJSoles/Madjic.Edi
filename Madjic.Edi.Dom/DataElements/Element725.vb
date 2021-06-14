Namespace DataElements
    '''<summary>Data Element Reference Number</summary>
    '''<remarks>
    '''<para>Reference number used to locate the data element in the Data Element Dictionary</para>
    '''</remarks>
    Partial Friend Class Element725
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element725
            Dim rval As New Element725

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace