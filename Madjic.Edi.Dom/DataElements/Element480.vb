Namespace DataElements
    '''<summary>Version / Release / Industry Identifier Code</summary>
    '''<remarks>
    '''<para>Code identifying the version, release, subrelease, and industry identifier of the EDI standard being used, including the GS and GE segments; if code in DE455 in GS segment is X, then in DE 480 positions 1-3 are the version number; positions 4-6 are the release and subrelease, level of hte version; and positions 7-12 are the industry or trade association identifiers (optionally assigned by user); if code in DE455 in GS segment is T, then other formats are allowed</para>
    '''</remarks>
    Partial Friend Class Element480
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 12)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element480
            Dim rval As New Element480

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace