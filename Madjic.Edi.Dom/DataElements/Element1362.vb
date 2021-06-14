Namespace DataElements
    '''<summary>Related-Causes Code</summary>
    '''<remarks>
    '''<para>Code identifying an accompanying cause of an illness, injury or an accident</para>
    '''</remarks>
    Partial Friend Class Element1362
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, "AA,AB,AP,EM,OA,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1362
            Dim rval As New Element1362

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace