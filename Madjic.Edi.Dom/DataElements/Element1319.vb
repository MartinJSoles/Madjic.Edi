Namespace DataElements
    '''<summary>Basis of Cost Determination Code</summary>
    '''<remarks>
    '''<para>Code indicating the method by which the ingredient cost was calculated</para>
    '''</remarks>
    Partial Friend Class Element1319
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "0,1,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1319
            Dim rval As New Element1319

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace