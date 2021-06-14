Namespace DataElements
    '''<summary>Contract Type Code</summary>
    '''<remarks>
    '''<para>Code identifying a contract type</para>
    '''</remarks>
    Partial Friend Class Element1166
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,09,AB,AC,AD,AE,AF,AG,AH,AI,AJ,CA,CB,CH,CP,CS,CW,CX,CY,DI,EA,ER,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FR,FX,LA,LE,LH,OC,PR,SP,TM,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1166
            Dim rval As New Element1166

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace