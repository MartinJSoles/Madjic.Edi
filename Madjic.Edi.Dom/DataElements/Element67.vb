Namespace DataElements
    '''<summary>Identification Code</summary>
    '''<remarks>
    '''<para>Code identifying a party or other code</para>
    '''</remarks>
    Partial Friend Class Element67
        Inherits StringElement

        Public Sub New()
            MyBase.New(2, 80)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element67
            Dim rval As New Element67

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace