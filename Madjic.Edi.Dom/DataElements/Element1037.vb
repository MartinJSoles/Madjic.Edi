Namespace DataElements
    '''<summary>Name Middle</summary>
    '''<remarks>
    '''<para>Individual middle name or initial</para>
    '''</remarks>
    Partial Friend Class Element1037
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 25)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1037
            Dim rval As New Element1037

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace