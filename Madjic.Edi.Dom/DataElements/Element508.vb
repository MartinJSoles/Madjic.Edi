Namespace DataElements
    '''<summary>Account Number</summary>
    '''<remarks>
    '''<para>Account number assigned</para>
    '''</remarks>
    Partial Friend Class Element508
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 35)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element508
            Dim rval As New Element508

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace