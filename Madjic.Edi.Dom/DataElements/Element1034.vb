Namespace DataElements
    '''<summary>Claim Adjustment Reason Code</summary>
    '''<remarks>
    '''<para>Code identifying the detailed reason the adjustment was made</para>
    '''</remarks>
    Partial Friend Class Element1034
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 5, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1034
            Dim rval As New Element1034

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace