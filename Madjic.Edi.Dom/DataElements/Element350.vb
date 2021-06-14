Namespace DataElements
    '''<summary>Assigned Identification</summary>
    '''<remarks>
    '''<para>Alphanumeric characters assigned for differentiation within a transaction set</para>
    '''</remarks>
    Partial Friend Class Element350
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 20)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element350
            Dim rval As New Element350

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace