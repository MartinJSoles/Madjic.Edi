Namespace DataElements
    '''<summary>Number</summary>
    '''<remarks>
    '''<para>A generic number</para>
    '''</remarks>
    Partial Friend Class Element1470
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1470
            Dim rval As New Element1470

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace