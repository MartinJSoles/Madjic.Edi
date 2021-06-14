Namespace DataElements
    '''<summary>Insurance Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of insurance policy within a specific insurance program</para>
    '''</remarks>
    Partial Friend Class Element1336
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing,
                       "12,13,14,15,16,41,42,43,47,AP,C1,CO,CP,D,DB,E,EP,FF,GP,HM,HN,HS,IN,IP,LC,LD,LI,LT,MA,MB,MC,MH,MI,MP,OT,PE,PL,PP,PR,PS,QM,RP,SP,TF,U,WC,WU")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1336
            Dim rval As New Element1336

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace