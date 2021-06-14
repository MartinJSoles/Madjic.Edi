Namespace DataElements
    '''<summary>Group Control Number</summary>
    '''<remarks>
    '''<para>Code identifying the country</para>
    '''</remarks>
    Partial Friend Class Element28
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element28
            Dim rval As New Element28

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace