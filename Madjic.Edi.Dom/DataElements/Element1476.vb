Namespace DataElements
    '''<summary>Language Proficiency Indicator</summary>
    '''<remarks>
    '''<para>Code indicating language proficiency</para>
    '''</remarks>
    Partial Friend Class Element1476
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,A,B,C,D,E")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1476
            Dim rval As New Element1476

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace