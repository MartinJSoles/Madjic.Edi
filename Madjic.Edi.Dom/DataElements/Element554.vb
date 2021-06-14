Namespace DataElements
    '''<summary>Assigned Number</summary>
    '''<remarks>
    '''<para>Number assigned for differentiation within a transaction set</para>
    '''</remarks>
    Partial Friend Class Element554
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element554
            Dim rval As New Element554

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace