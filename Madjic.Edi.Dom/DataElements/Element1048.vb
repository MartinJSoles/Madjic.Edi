Namespace DataElements
    '''<summary>Business Function Code</summary>
    '''<remarks>
    '''<para>Code identifying the business reason for this payment</para>
    '''</remarks>
    Partial Friend Class Element1048
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "COL,CON,DBT,PCS,PEN,PRL,RYL,TAX,VEN")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1048
            Dim rval As New Element1048

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace