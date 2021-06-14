Namespace DataElements
    '''<summary>Work Intensity Code</summary>
    '''<remarks>
    '''<para>Code identifying the level of intensity of work</para>
    '''</remarks>
    Partial Friend Class Element1154
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "H,L,M,R")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1154
            Dim rval As New Element1154

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace