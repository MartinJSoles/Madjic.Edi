Namespace DataElements
    '''<summary>Security Level Code</summary>
    '''<remarks>
    '''<para>Code indicating the level of confidentiality assigned by the sender to the information following</para>
    '''</remarks>
    Partial Friend Class Element786
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element786
            Dim rval As New Element786

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace