Namespace DataElements
    '''<summary>Repeating Data Element Position</summary>
    '''<remarks>
    '''<para>To identify the specific repetition of a data element that is in error</para>
    '''</remarks>
    Partial Friend Class Element1686
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1686
            Dim rval As New Element1686

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace