Namespace DataElements
    '''<summary>Number of Received Transaction Sets</summary>
    '''<remarks>
    '''<para>Number of Transaction Sets received</para>
    '''</remarks>
    Partial Friend Class Element123
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element123
            Dim rval As New Element123

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace