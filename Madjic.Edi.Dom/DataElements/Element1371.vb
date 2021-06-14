Namespace DataElements
    '''<summary>Unit Rate</summary>
    '''<remarks>
    '''<para>The rate per unit of associate revenue for hospital accommodation</para>
    '''</remarks>
    Partial Friend Class Element1371
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1371
            Dim rval As New Element1371

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace