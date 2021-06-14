Namespace DataElements
    '''<summary>Level of Care Code</summary>
    '''<remarks>
    '''<para>Code specifying the level of care provided by a nursing home facility</para>
    '''</remarks>
    Partial Friend Class Element1337
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,7,8")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1337
            Dim rval As New Element1337

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace