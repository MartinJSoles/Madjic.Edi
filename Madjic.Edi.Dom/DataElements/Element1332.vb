Namespace DataElements
    '''<summary>Facility Code Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the type of facility referenced</para>
    '''</remarks>
    Partial Friend Class Element1332
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "A,B")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1332
            Dim rval As New Element1332

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace