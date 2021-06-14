Namespace DataElements
    '''<summary>Yes/No Condition or Response Code</summary>
    '''<remarks>
    '''<para>Code indicating a Yes or No condition or response</para>
    '''</remarks>
    Partial Friend Class Element1073
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "N,U,W,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1073
            Dim rval As New Element1073

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace