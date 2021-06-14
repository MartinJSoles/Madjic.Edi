Namespace DataElements
    '''<summary>Level of Service Code</summary>
    '''<remarks>
    '''<para>Code specifying the level of service rendered</para>
    '''</remarks>
    Partial Friend Class Element1338
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "00,01,02,03,04,05,06,09,10,11,E,F1,F2,I,L,NBC,R,U")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1338
            Dim rval As New Element1338

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace