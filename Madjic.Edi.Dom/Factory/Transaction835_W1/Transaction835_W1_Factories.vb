Namespace Factory.Transaction835_W1
    '''<summary>Provides methods for instantiating the Transaction835_W1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet">Transaction835_W1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet">Transaction835_W1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction835_W1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Standard_Obj("005010X221A1")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet">Transaction835_W1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet">Transaction835_W1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction835_W1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Standard_Obj(controlNumber, "005010X221A1")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR">BPR</see> interface (Financial Information).</summary>
        Public Shared Function CreateBPR() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.BPR
            Return New Global.Madjic.Edi.Dom.Segments.BPR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN">TRN</see> interface (Reassociation Trace Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR">CUR</see> interface (Foreign Currency Information).</summary>
        Public Shared Function CreateCUR() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.CUR
            Return New Global.Madjic.Edi.Dom.Segments.CUR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF">REF</see> interface (Receiver Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1">REF_1</see> interface (Version Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM">DTM</see> interface (Production Date).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB">PLB</see> interface (Provider Adjustment).</summary>
        Public Shared Function CreatePLB() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.PLB
            Return New Global.Madjic.Edi.Dom.Segments.PLB_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A">Loop1000A</see> interface (Payer Identification).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A">Loop1000A</see> interface.</returns>
        Public Shared Function CreateLoop1000A() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B">Loop1000B</see> interface (Payee Identification).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B">Loop1000B</see> interface.</returns>
        Public Shared Function CreateLoop1000B() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop1000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000">Loop2000</see> interface (Header Number).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000">Loop2000</see> interface.</returns>
        Public Shared Function CreateLoop2000() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2000
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100">Loop2100</see> interface (Claim Payment Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100">Loop2100</see> interface.</returns>
        Public Shared Function CreateLoop2100() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2100
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110">Loop2110</see> interface (Service Payment Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110">Loop2110</see> interface.</returns>
        Public Shared Function CreateLoop2110() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Loops.Loop2110
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction835.Loop2110_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000A loop (Payer Identification).</summary>
    Public NotInheritable Class Loop1000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1">N1</see> interface (Payer Identification).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3">N3</see> interface (Payer Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4">N4</see> interface (Payer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF">REF</see> interface (Additional Payer Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER">PER</see> interface (Payer Business Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1">PER_1</see> interface (Payer Technical Contact Information).</summary>
        Public Shared Function CreatePER_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2">PER_2</see> interface (Payer WEB Site).</summary>
        Public Shared Function CreatePER_2() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000B loop (Payee Identification).</summary>
    Public NotInheritable Class Loop1000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1">N1</see> interface (Payee Identification).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3">N3</see> interface (Payee Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4">N4</see> interface (Payee City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF">REF</see> interface (Payee Additional Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM">RDM</see> interface (Remittance Delivery Method).</summary>
        Public Shared Function CreateRDM() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM
            Return New Global.Madjic.Edi.Dom.Segments.RDM_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000 loop (Header Number).</summary>
    Public NotInheritable Class Loop2000Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX">LX</see> interface (Header Number).</summary>
        Public Shared Function CreateLX() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX
            Return New Global.Madjic.Edi.Dom.Segments.LX_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3">TS3</see> interface (Provider Summary Information).</summary>
        Public Shared Function CreateTS3() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3
            Return New Global.Madjic.Edi.Dom.Segments.TS3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2">TS2</see> interface (Provider Supplemental Summary Information).</summary>
        Public Shared Function CreateTS2() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2
            Return New Global.Madjic.Edi.Dom.Segments.TS2_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100 loop (Claim Payment Information).</summary>
    Public NotInheritable Class Loop2100Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP">CLP</see> interface (Claim Payment Information).</summary>
        Public Shared Function CreateCLP() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP
            Return New Global.Madjic.Edi.Dom.Segments.CLP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS">CAS</see> interface (Claim Adjustment).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1">NM1</see> interface (Patient Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1">NM1_1</see> interface (Insured Name).</summary>
        Public Shared Function CreateNM1_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2">NM1_2</see> interface (Corrected Patient/Insured Name).</summary>
        Public Shared Function CreateNM1_2() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_2
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3">NM1_3</see> interface (Service Provider Name).</summary>
        Public Shared Function CreateNM1_3() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_3
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4">NM1_4</see> interface (Crossover Carrier Name).</summary>
        Public Shared Function CreateNM1_4() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_4
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5">NM1_5</see> interface (Corrected Priority Payer Name).</summary>
        Public Shared Function CreateNM1_5() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_5
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6">NM1_6</see> interface (Other Subscriber Name).</summary>
        Public Shared Function CreateNM1_6() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.NM1_6
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA">MIA</see> interface (Inpatient Adjudication Information).</summary>
        Public Shared Function CreateMIA() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA
            Return New Global.Madjic.Edi.Dom.Segments.MIA_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA">MOA</see> interface (Outpatient Adjudication Information).</summary>
        Public Shared Function CreateMOA() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA
            Return New Global.Madjic.Edi.Dom.Segments.MOA_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF">REF</see> interface (Other Claim Related Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1">REF_1</see> interface (Rendering Provider Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM">DTM</see> interface (Statement From or To Date).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1">DTM_1</see> interface (Coverage Expiration Date).</summary>
        Public Shared Function CreateDTM_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2">DTM_2</see> interface (Claim Received Date).</summary>
        Public Shared Function CreateDTM_2() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER">PER</see> interface (Claim Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT">AMT</see> interface (Claim Supplemental Information).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY">QTY</see> interface (Claim Supplemental Information Quantity).</summary>
        Public Shared Function CreateQTY() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY
            Return New Global.Madjic.Edi.Dom.Segments.QTY_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2110 loop (Service Payment Information).</summary>
    Public NotInheritable Class Loop2110Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC">SVC</see> interface (Service Payment Information).</summary>
        Public Shared Function CreateSVC() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC
            Return New Global.Madjic.Edi.Dom.Segments.SVC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM">DTM</see> interface (Service Date).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS">CAS</see> interface (Service Adjustment).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF">REF</see> interface (Service Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1">REF_1</see> interface (Line Item Control Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2">REF_2</see> interface (Rendering Provider Information).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3">REF_3</see> interface (HealthCare Policy Identification).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT">AMT</see> interface (Service Supplemental Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY">QTY</see> interface (Service Supplemental Quantity).</summary>
        Public Shared Function CreateQTY() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY
            Return New Global.Madjic.Edi.Dom.Segments.QTY_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ">LQ</see> interface (Health Care Remark Codes).</summary>
        Public Shared Function CreateLQ() As Global.Madjic.Edi.Dom.Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ
            Return New Global.Madjic.Edi.Dom.Segments.LQ_Obj
        End Function
    End Class
End Namespace
