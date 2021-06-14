Namespace DataElements
    '''<summary>Volume</summary>
    '''<remarks>
    '''<para>Value of volumetric measure</para>
    '''</remarks>
    Partial Friend Class Element183
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 8)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element183
            Dim rval As New Element183

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace