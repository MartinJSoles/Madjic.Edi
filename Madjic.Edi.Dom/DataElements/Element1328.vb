Namespace DataElements
    '''<summary>Diagnosis Code Pointer</summary>
    '''<remarks>
    '''<para>A pointer to the diagnosis code in the order of importance to this service</para>
    '''</remarks>
    Partial Friend Class Element1328
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1328
            Dim rval As New Element1328

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace