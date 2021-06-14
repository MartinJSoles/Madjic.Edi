Namespace DataElements
    '''<summary>Multiplier</summary>
    '''<remarks>
    '''<para>Value to be used as a multiplier to obtain a new value</para>
    '''</remarks>
    Partial Friend Class Element649
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element649
            Dim rval As New Element649

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace