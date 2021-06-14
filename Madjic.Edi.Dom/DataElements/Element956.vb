Namespace DataElements
    '''<summary>Tax Jurisdiction Code</summary>
    '''<remarks>
    '''<para>Code identifying the taxing jurisdiction</para>
    '''</remarks>
    Partial Friend Class Element956
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element956
            Dim rval As New Element956

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace