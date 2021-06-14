Namespace DataElements
    '''<summary>Component Data Element Position in Composite</summary>
    '''<remarks>
    '''<para>To identify the component data element position within the composite that is in error</para>
    '''</remarks>
    Partial Friend Class Element1528
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1528
            Dim rval As New Element1528

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace