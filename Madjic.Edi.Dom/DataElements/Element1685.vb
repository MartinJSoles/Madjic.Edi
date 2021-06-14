Namespace DataElements
    '''<summary>Tax Treatment Code</summary>
    '''<remarks>
    '''<para>Code specifying whether a deduction should have pre- or post-tax status</para>
    '''</remarks>
    Partial Friend Class Element1685
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,N")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1685
            Dim rval As New Element1685

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace