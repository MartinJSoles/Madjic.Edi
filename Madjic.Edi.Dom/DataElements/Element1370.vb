Namespace DataElements
    '''<summary>Unit Dose Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of unit dose dispensing done</para>
    '''</remarks>
    Partial Friend Class Element1370
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3,4,5,6,7,8,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1370
            Dim rval As New Element1370

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace