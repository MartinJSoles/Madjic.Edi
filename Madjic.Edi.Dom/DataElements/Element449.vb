Namespace DataElements
    '''<summary>Fixed Format Information</summary>
    '''<remarks>
    '''<para>Data in fixed format agreed upon by sender and receiver</para>
    '''</remarks>
    Partial Friend Class Element449
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 80)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element449
            Dim rval As New Element449

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace