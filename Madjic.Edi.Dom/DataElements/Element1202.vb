Namespace DataElements
    '''<summary>Flexible Spending Account Selection Code</summary>
    '''<remarks>
    '''<para>Code indicating selection of a type of Flexible Spending Account</para>
    '''</remarks>
    Partial Friend Class Element1202
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "D,E,H,L,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1202
            Dim rval As New Element1202

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace