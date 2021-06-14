Namespace DataElements
    '''<summary>Rate or Value Type Code</summary>
    '''<remarks>
    '''<para>Code identifying method used to determine the type of rate, value, or percent details</para>
    '''</remarks>
    Partial Friend Class Element562
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element562
            Dim rval As New Element562

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace