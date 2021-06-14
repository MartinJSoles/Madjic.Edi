Namespace DataElements
    '''<summary>Payment Action Code</summary>
    '''<remarks>
    '''<para>Code specifying the accounts receivable open item(s), if any, to be included in the cash application.</para>
    '''</remarks>
    Partial Friend Class Element482
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "AJ,ER,FL,NS,PA,PI,PO,PP,PR")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element482
            Dim rval As New Element482

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace