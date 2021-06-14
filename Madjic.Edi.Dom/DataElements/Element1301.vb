Namespace DataElements
    '''<summary>Agency Service, Promotion, Allowance, or Charge Code</summary>
    '''<remarks>
    '''<para>Agency maintained code identifying the service, promotion, allowance, or charge</para>
    '''</remarks>
    Partial Friend Class Element1301
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1301
            Dim rval As New Element1301

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace