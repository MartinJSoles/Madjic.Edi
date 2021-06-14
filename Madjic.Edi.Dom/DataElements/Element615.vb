Namespace DataElements
    '''<summary>Time Period Qualifier</summary>
    '''<remarks>
    '''<para>Code defining periods</para>
    '''</remarks>
    Partial Friend Class Element615
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,4,5,6,7,8,9,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element615
            Dim rval As New Element615

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace