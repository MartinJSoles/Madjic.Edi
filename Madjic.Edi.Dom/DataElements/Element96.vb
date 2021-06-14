Namespace DataElements
    '''<summary>Number of Included Segments</summary>
    '''<remarks>
    '''<para>Total number of segments included in a transaction set including ST and SE segments</para>
    '''</remarks>
    Partial Friend Class Element96
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element96
            Dim rval As New Element96

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace