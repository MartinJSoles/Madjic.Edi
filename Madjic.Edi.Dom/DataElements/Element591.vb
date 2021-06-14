Namespace DataElements
    '''<summary>Payment Method Code</summary>
    '''<remarks>
    '''<para>Code identifying the method for the movement of payment instructions</para>
    '''</remarks>
    Partial Friend Class Element591
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing,
                       "ACH,BKW,BOP,CAS,CCC,CCF,CCH,CDA,CHK,CLH,CPC,CWT,DCC,DCD,DDP,DEB,DLC,DLD,DXC,DXD,DYC,DYD,DZC,DZD,EBX,EXC,FEW,FWT,FXP,IWT,NON,PAC,PBD,PDC,PDD,PDE,PRO,QDR,QIR,REV,SCC,SCD,SDC,SDD,SWT,SXC,SXD,SYC,SZC,SZD,TRA,VIS,X12,ZZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element591
            Dim rval As New Element591

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace