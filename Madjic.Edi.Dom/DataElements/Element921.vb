Namespace DataElements
    '''<summary>Discipline Type Code</summary>
    '''<remarks>
    '''<para>Code indicating disciplines ordered by a physician</para>
    '''</remarks>
    Partial Friend Class Element921
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "AI,MS,OT,PT,SN,ST")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element921
            Dim rval As New Element921

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace