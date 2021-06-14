Namespace DataElements
    '''<summary>Time Code</summary>
    '''<remarks>
    '''<para>Code identifying the time. In accordance with International Standards Organization standard 8601, time can be specified by a + or - and an indication in hours in relation to Universal Time Coordinate (UTC) time; since + is a restricted character, + and - are substituted by P and M in the codes that follow</para>
    '''</remarks>
    Partial Friend Class Element623
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT,CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,ND,NS,NT,PD,PS,PT,TD,TS,TT,UT")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element623
            Dim rval As New Element623

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace