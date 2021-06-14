Namespace DataElements
    '''<summary>Approval Code</summary>
    '''<remarks>
    '''<para>Code specifying the determination arrived at by the Utilization Review Committee or Peer Review Organization (PRO)</para>
    '''</remarks>
    Partial Friend Class Element1318
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1318
            Dim rval As New Element1318

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace