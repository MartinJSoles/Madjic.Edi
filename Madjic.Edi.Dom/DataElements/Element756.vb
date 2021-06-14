Namespace DataElements
    '''<summary>Report Transmission Code</summary>
    '''<remarks>
    '''<para>Code defining timing, transmission method or format by which reports are to be sent</para>
    '''</remarks>
    Partial Friend Class Element756
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,2,3,4,5,6,7,8,9,AA,AB,AC,AD,AE,AF,AG,AM,AS,AT,AU,BE,BM,BW,CD,CF,CP,CT,DA,EL,EM,FT,FX,GS,HL,IA,IE,IM,MB,MD,MN,MP,MT,NS,OL,PO,SE,SM,SN,SW,TA,TE,TM,TX,VO,WS")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element756
            Dim rval As New Element756

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace