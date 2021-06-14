Namespace DataElements
    '''<summary>Year</summary>
    '''<remarks>
    '''<para>Four position designation of the year expressed as CCYY</para>
    '''</remarks>
    Partial Friend Class Element1095
        Inherits NumericElement

        Public Sub New()
            MyBase.New(4, 0, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1095
            Dim rval As New Element1095

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace