Namespace DataElements
    '''<summary>Claim Adjustment Group Code</summary>
    '''<remarks>
    '''<para>Code identifying the general category of payment adjustment</para>
    '''</remarks>
    Partial Friend Class Element1033
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "CO,CR,DE,MA,NC,OA,PI,PR,RR")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1033
            Dim rval As New Element1033

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace