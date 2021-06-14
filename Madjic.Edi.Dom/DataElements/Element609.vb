Namespace DataElements
    '''<summary>Count</summary>
    '''<remarks>
    '''<para>Occurrence counter</para>
    '''</remarks>
    Partial Friend Class Element609
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element609
            Dim rval As New Element609

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace