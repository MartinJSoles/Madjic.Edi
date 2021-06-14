Namespace DataElements
    '''<summary>Allowance or Charge Indicator</summary>
    '''<remarks>
    '''<para>Code which indicates an allowance or charge for the service specified</para>
    '''</remarks>
    Partial Friend Class Element248
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,C,N,P,Q,R,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element248
            Dim rval As New Element248

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace