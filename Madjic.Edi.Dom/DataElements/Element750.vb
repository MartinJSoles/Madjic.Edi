Namespace DataElements
    '''<summary>Product/Process Characteristic Code</summary>
    '''<remarks>
    '''<para>Code identifying the general class of a product or process characteristic</para>
    '''</remarks>
    Partial Friend Class Element750
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing,
                       "01,02,03,04,05,06,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,99,9A,9B,9C,9D,AA,AB,AC,AD,AE,AF,AG,AGE,AH,AI,AJ,AK,AL,AT,B8,BC,BCC,BES,BEV,BLM,BND,BPI,BRG,BW,C2,C3,C4,C5,C6,CCN,CD,CFC,CH,CHF,CL,CLT,CM,CMS,CO,CP,CS,CU,CW,DAC,DAF,DE,DF,DIR,DM,DS,EC,EN,EV,FA,FC,FCD,FDD,FL,FLV,FMR,FQ,GD,GEN,GM,GS,HB,HY,HZ,HZR,ING,INJ,KI,LC,LO,MA,MAC,MB,MBU,MM,MS,MSG,NH,OC,OD,ODR,OR,OT,P6,PD,PF,PFA,PFC,PFG,PFI,PFK,PFL,PFM,PFN,PFP,PFS,PFT,PG,PP,PR,PRI,PRO,PSC,PUB,PUR,QAS,R3,RA,RCC,RM,RR,RSD,RSE,RX,SC,SE,SEC,SF,SIZ,SLM,SOL,ST,STL,SYN,TC,TE,TF,THR,TIF,TIR,TP,TR,TRM,TRN,TWF,TZ,VA,VC,VI,WD,WF,WLC,WT,WTT,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element750
            Dim rval As New Element750

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace