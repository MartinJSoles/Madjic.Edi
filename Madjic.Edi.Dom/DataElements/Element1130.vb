Namespace DataElements
    '''<summary>Primary or Contingent Code</summary>
    '''<remarks>
    '''<para>Code identifying if the beneficiary is the primary beneficiary or the contingent beneficiary</para>
    '''</remarks>
    Partial Friend Class Element1130
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "C,P")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1130
            Dim rval As New Element1130

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace