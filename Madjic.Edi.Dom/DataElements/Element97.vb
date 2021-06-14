Namespace DataElements
    '''<summary>Number of Transaction Sets Included</summary>
    '''<remarks>
    '''<para>Total number of transaction sets included in the functional group or interchange (transmisison) group terminated by the trailer containing this data element</para>
    '''</remarks>
    Partial Friend Class Element97
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element97
            Dim rval As New Element97

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace