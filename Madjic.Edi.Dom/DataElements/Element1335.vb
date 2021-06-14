Namespace DataElements
    '''<summary>Insulin Dependent Code</summary>
    '''<remarks>
    '''<para>Code indicating the condition that demonstrates insulin dependence</para>
    '''</remarks>
    Partial Friend Class Element1335
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,N")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1335
            Dim rval As New Element1335

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace