Namespace DataElements
    '''<summary>Attendance Type Code</summary>
    '''<remarks>
    '''<para>Code specifying the type of attendance information being reported</para>
    '''</remarks>
    Partial Friend Class Element1684
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 4, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1684
            Dim rval As New Element1684

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace