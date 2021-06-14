Namespace DataElements
    '''<summary>Deduction Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of deduction being reported</para>
    '''</remarks>
    Partial Friend Class Element1688
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 4, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1688
            Dim rval As New Element1688

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace