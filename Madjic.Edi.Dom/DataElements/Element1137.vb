Namespace DataElements
    '''<summary>Medical Code Value</summary>
    '''<remarks>
    '''<para>Code value for describing a medical condition or procedure</para>
    '''</remarks>
    Partial Friend Class Element1137
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1137
            Dim rval As New Element1137

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace