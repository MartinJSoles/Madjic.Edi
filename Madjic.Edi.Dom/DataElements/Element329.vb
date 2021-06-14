Namespace DataElements
    '''<summary>Transaction Set Control Number</summary>
    '''<remarks>
    '''<para>Identifying control number that must be unique within the transaction set functional group assigned by the originator for a transaction set</para>
    '''</remarks>
    Partial Friend Class Element329
        Inherits StringElement

        Public Sub New()
            MyBase.New(4, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element329
            Dim rval As New Element329

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace