Namespace DataElements
    '''<summary>Employment Status Code</summary>
    '''<remarks>
    '''<para>Code showing the general employment status of an employee/claimant</para>
    '''</remarks>
    Partial Friend Class Element584
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "00,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AS,AT,AU,CA,CC,CO,CT,DC,DD,DI,DQ,DR,DS,EO,FA,FB,FC,FO,FT,HD,IA,IR,L1,L2,L3,L4,L5,L6,L7,LA,LE,LF,LM,LO,LS,LU,LW,LX,NE,OS,OT,PA,PC,PE,PM,PN,PR,PT,PV,PW,RA,RB,RC,RD,RE,RI,RM,RP,RR,RT,RU,RW,SA,SB,SE,SL,SU,TE,TF,TM,TN,TP,TR,UK,VO,XD,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element584
            Dim rval As New Element584

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace