Namespace DataElements
    '''<summary>Payment Format Code</summary>
    '''<remarks>
    '''<para>Code identifying the payment format to be used</para>
    '''</remarks>
    Partial Friend Class Element812
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 10, Nothing, "BPT,CBC,CBR,CCD,CCP,CIE,CIP,CTX,PBC,PBR,POP,POS,PPD,PPP,PRD,RCK,TEL,WEB")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element812
            Dim rval As New Element812

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace