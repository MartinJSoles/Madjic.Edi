Namespace DataElements
    '''<summary>Quantity Invoiced</summary>
    '''<remarks>
    '''<para>Number of units invoiced (supplier units)</para>
    '''</remarks>
    Partial Friend Class Element358
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element358
            Dim rval As New Element358

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace