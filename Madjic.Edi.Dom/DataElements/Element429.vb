Namespace DataElements
    '''<summary>Check Number</summary>
    '''<remarks>
    '''<para>Check identification number</para>
    '''</remarks>
    Partial Friend Class Element429
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 16)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element429
            Dim rval As New Element429

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace