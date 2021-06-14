Namespace DataElements
    '''<summary>Sample Selection Modulus</summary>
    '''<remarks>
    '''<para>To specify the sampling frequency in terms of a modulus of the Unit of Measure, e.g., every fifth bag, every 1.5 minutes</para>
    '''</remarks>
    Partial Friend Class Element1167
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1167
            Dim rval As New Element1167

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace