Namespace DataElements
    '''<summary>Number of Periods</summary>
    '''<remarks>
    '''<para>Total number of periods</para>
    '''</remarks>
    Partial Friend Class Element616
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 3)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element616
            Dim rval As New Element616

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace