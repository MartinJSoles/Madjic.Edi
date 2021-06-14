Namespace DataElements
    '''<summary>Condition Value</summary>
    '''<remarks>
    '''<para>Identifies rate restrictions or provisions</para>
    '''</remarks>
    Partial Friend Class Element499
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element499
            Dim rval As New Element499

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace