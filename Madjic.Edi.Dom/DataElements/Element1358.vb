Namespace DataElements
    '''<summary>Prosthesis, Crown or Inlay Code</summary>
    '''<remarks>
    '''<para>Code specifying the placement status for the dental work</para>
    '''</remarks>
    Partial Friend Class Element1358
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "I,R")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1358
            Dim rval As New Element1358

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace