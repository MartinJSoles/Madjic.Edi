Namespace DataElements
    '''<summary>Safety Characteristic/Hazard Code</summary>
    '''<remarks>
    '''<para>Code indicating precautionary measures, means of treatment and hazard information and warnings</para>
    '''</remarks>
    Partial Friend Class Element821
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing,
                       "ACT,AM2,AP2,CAR,CI2,CO2,CON,CTD,DCL,DEC,DEH,DI2,DIS,DM2,EDD,EFA,EFB,EFX,EIM,EN2,ENA,ENB,ENG,ENO,ENS,EO2,EP2,EPA,ESD,EVP,EXC,EXG,EXI,EXL,EYA,EYC,EYF,EYZ,FA2,FAA,FAL,FAS,FAT,FAZ,FE2,FEH,FEZ,FLC,FLP,GCA,GMA,GPI,HAI,HCA,HCP,HH2,HHA,HI2,HZC,HZR,IA2,IGA,IGC,IGZ,IHA,IHC,IHZ,INC,INS,INX,IRR,KY2,LAB,LKI,MAT,MCE,MUT,NOT,NTE,NTR,NTS,NTZ,OPH,OPR,ORC,PD2,PM2,POL,PPA,PPB,PPC,PPD,PPE,PPF,PPG,PPR,PPS,PPZ,PR2,PRE,PRF,PRG,PRH,PRI,PRJ,PRK,PRL,PRM,PRO,PRQ,PRS,PRT,PRU,PRZ,RE2,REA,REC,REP,RG2,RLI,RTK,SAP,SBY,SCE,SGW,SH2,SHI,SKA,SKC,SKS,SKT,SKZ,SL2,SNS,SPF,SPI,SPJ,SPL,SPP,ST2,STA,SUB,SYP,SYS,TER,TOC,TOG,TRH,TS2,TX2,VRZ,WAR,WDI")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element821
            Dim rval As New Element821

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace