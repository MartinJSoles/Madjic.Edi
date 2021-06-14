Namespace DataElements
    '''<summary>Policy Compliance Code</summary>
    '''<remarks>
    '''<para>Code specifying policy compliance</para>
    '''</remarks>
    Partial Friend Class Element1526
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,5")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1526
            Dim rval As New Element1526

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace