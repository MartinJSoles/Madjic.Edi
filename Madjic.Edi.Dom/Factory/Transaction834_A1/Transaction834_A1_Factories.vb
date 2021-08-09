Namespace Factory.Transaction834_A1
    '''<summary>Provides methods for instantiating the Transaction834_A1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet">Transaction834_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet">Transaction834_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction834_A1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Standard_Obj("005010X220A1")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet">Transaction834_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet">Transaction834_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction834_A1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Standard_Obj(controlNumber, "005010X220A1")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN">BGN</see> interface (Beginning Segment).</summary>
        Public Shared Function CreateBGN() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.BGN
            Return New Global.Madjic.Edi.Dom.Segments.BGN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF">REF</see> interface (Transaction Set Policy Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP">DTP</see> interface (File Effective Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY">QTY</see> interface (Transaction Set Control Totals).</summary>
        Public Shared Function CreateQTY() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.QTY
            Return New Global.Madjic.Edi.Dom.Segments.QTY_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A">Loop1000A</see> interface (Sponsor Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A">Loop1000A</see> interface.</returns>
        Public Shared Function CreateLoop1000A() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B">Loop1000B</see> interface (Payer).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B">Loop1000B</see> interface.</returns>
        Public Shared Function CreateLoop1000B() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C">Loop1000C</see> interface (TPA/Broker Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C">Loop1000C</see> interface.</returns>
        Public Shared Function CreateLoop1000C() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C">Loop1100C</see> interface (TPA/Broker Account Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C">Loop1100C</see> interface.</returns>
        Public Shared Function CreateLoop1100C() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop1100C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop1100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000">Loop2000</see> interface (Member Level Detail).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000">Loop2000</see> interface.</returns>
        Public Shared Function CreateLoop2000() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2000
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A">Loop2100A</see> interface (Member Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A">Loop2100A</see> interface.</returns>
        Public Shared Function CreateLoop2100A() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B">Loop2100B</see> interface (Incorrect Member Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B">Loop2100B</see> interface.</returns>
        Public Shared Function CreateLoop2100B() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C">Loop2100C</see> interface (Member Mailing Address).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C">Loop2100C</see> interface.</returns>
        Public Shared Function CreateLoop2100C() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D">Loop2100D</see> interface (Member Employer).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D">Loop2100D</see> interface.</returns>
        Public Shared Function CreateLoop2100D() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E">Loop2100E</see> interface (Member School).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E">Loop2100E</see> interface.</returns>
        Public Shared Function CreateLoop2100E() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F">Loop2100F</see> interface (Custodial Parent).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F">Loop2100F</see> interface.</returns>
        Public Shared Function CreateLoop2100F() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G">Loop2100G</see> interface (Responsible Person).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G">Loop2100G</see> interface.</returns>
        Public Shared Function CreateLoop2100G() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100G
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H">Loop2100H</see> interface (Drop Off Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H">Loop2100H</see> interface.</returns>
        Public Shared Function CreateLoop2100H() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2100H
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200">Loop2200</see> interface (Disability Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200">Loop2200</see> interface.</returns>
        Public Shared Function CreateLoop2200() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2200
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300">Loop2300</see> interface (Health Coverage).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300">Loop2300</see> interface.</returns>
        Public Shared Function CreateLoop2300() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2300
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2300_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310">Loop2310</see> interface (Provider Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310">Loop2310</see> interface.</returns>
        Public Shared Function CreateLoop2310() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2310
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320">Loop2320</see> interface (Coordination of Benefits).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320">Loop2320</see> interface.</returns>
        Public Shared Function CreateLoop2320() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2320
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2320_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330">Loop2330</see> interface (Coordination of Benefits Related Entity).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330">Loop2330</see> interface.</returns>
        Public Shared Function CreateLoop2330() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2330
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700">Loop2700</see> interface (Member Reporting Categories).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700">Loop2700</see> interface.</returns>
        Public Shared Function CreateLoop2700() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2700
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2700_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750">Loop2750</see> interface (Reporting Category).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750">Loop2750</see> interface.</returns>
        Public Shared Function CreateLoop2750() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Loops.Loop2750
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction834.Loop2750_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000A loop (Sponsor Name).</summary>
    Public NotInheritable Class Loop1000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1">N1</see> interface (Sponsor Name).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000B loop (Payer).</summary>
    Public NotInheritable Class Loop1000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1">N1</see> interface (Payer).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000C loop (TPA/Broker Name).</summary>
    Public NotInheritable Class Loop1000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1">N1</see> interface (TPA/Broker Name).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1100C loop (TPA/Broker Account Information).</summary>
    Public NotInheritable Class Loop1100CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT">ACT</see> interface (TPA/Broker Account Information).</summary>
        Public Shared Function CreateACT() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT
            Return New Global.Madjic.Edi.Dom.Segments.ACT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000 loop (Member Level Detail).</summary>
    Public NotInheritable Class Loop2000Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS">INS</see> interface (Member Level Detail).</summary>
        Public Shared Function CreateINS() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS
            Return New Global.Madjic.Edi.Dom.Segments.INS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF">REF</see> interface (Subscriber Identifier).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1">REF_1</see> interface (Member Policy Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2">REF_2</see> interface (Member Supplemental Identifier).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP">DTP</see> interface (Member Level Dates).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS">LS</see> interface (Additional Reporting Categories).</summary>
        Public Shared Function CreateLS() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS
            Return New Global.Madjic.Edi.Dom.Segments.LS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE">LE</see> interface (Additional Reporting Categories Loop Termination).</summary>
        Public Shared Function CreateLE() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE
            Return New Global.Madjic.Edi.Dom.Segments.LE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052" /> interface (Medicare Status Code).</summary>
        Public Shared Function CreateINS06() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C052_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100A loop (Member Name).</summary>
    Public NotInheritable Class Loop2100AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1">NM1</see> interface (Member Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER">PER</see> interface (Member Communications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3">N3</see> interface (Member Residence Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4">N4</see> interface (Member City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG">DMG</see> interface (Member Demographics).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC">EC</see> interface (Employment Class).</summary>
        Public Shared Function CreateEC() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC
            Return New Global.Madjic.Edi.Dom.Segments.EC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM">ICM</see> interface (Member Income).</summary>
        Public Shared Function CreateICM() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM
            Return New Global.Madjic.Edi.Dom.Segments.ICM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT">AMT</see> interface (Member Policy Amounts).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH">HLH</see> interface (Member Health Information).</summary>
        Public Shared Function CreateHLH() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH
            Return New Global.Madjic.Edi.Dom.Segments.HLH_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI">LUI</see> interface (Member Language).</summary>
        Public Shared Function CreateLUI() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI
            Return New Global.Madjic.Edi.Dom.Segments.LUI_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100B loop (Incorrect Member Name).</summary>
    Public NotInheritable Class Loop2100BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1">NM1</see> interface (Incorrect Member Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG">DMG</see> interface (Incorrect Member Demographics).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100C loop (Member Mailing Address).</summary>
    Public NotInheritable Class Loop2100CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1">NM1</see> interface (Member Mailing Address).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3">N3</see> interface (Member Mail Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4">N4</see> interface (Member Mail City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100D loop (Member Employer).</summary>
    Public NotInheritable Class Loop2100DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1">NM1</see> interface (Member Employer).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER">PER</see> interface (Member Employer Communications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3">N3</see> interface (Member Employer Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4">N4</see> interface (Member Employer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100E loop (Member School).</summary>
    Public NotInheritable Class Loop2100EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1">NM1</see> interface (Member School).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER">PER</see> interface (Member School Commmunications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3">N3</see> interface (Member School Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4">N4</see> interface (Member School City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100F loop (Custodial Parent).</summary>
    Public NotInheritable Class Loop2100FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1">NM1</see> interface (Custodial Parent).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER">PER</see> interface (Custodial Parent Communications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3">N3</see> interface (Custodial Parent Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4">N4</see> interface (Custodial Parent City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100G loop (Responsible Person).</summary>
    Public NotInheritable Class Loop2100GFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1">NM1</see> interface (Responsible Person).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER">PER</see> interface (Responsible Person Communications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3">N3</see> interface (Responsible Person Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4">N4</see> interface (Responsible Person City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100H loop (Drop Off Location).</summary>
    Public NotInheritable Class Loop2100HFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1">NM1</see> interface (Drop Off Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3">N3</see> interface (Drop Off Location Street Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4">N4</see> interface (Drop Off Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200 loop (Disability Information).</summary>
    Public NotInheritable Class Loop2200Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB">DSB</see> interface (Disability Information).</summary>
        Public Shared Function CreateDSB() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB
            Return New Global.Madjic.Edi.Dom.Segments.DSB_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP">DTP</see> interface (Disability Eligibility Dates).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2300 loop (Health Coverage).</summary>
    Public NotInheritable Class Loop2300Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD">HD</see> interface (Health Coverage).</summary>
        Public Shared Function CreateHD() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD
            Return New Global.Madjic.Edi.Dom.Segments.HD_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP">DTP</see> interface (Health Coverage Dates).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT">AMT</see> interface (Health Coverage Policy).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF">REF</see> interface (Health Coverage Policy Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1">REF_1</see> interface (Prior Coverage Months).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC">IDC</see> interface (Identification Card).</summary>
        Public Shared Function CreateIDC() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC
            Return New Global.Madjic.Edi.Dom.Segments.IDC_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310 loop (Provider Information).</summary>
    Public NotInheritable Class Loop2310Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX">LX</see> interface (Provider Information).</summary>
        Public Shared Function CreateLX() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX
            Return New Global.Madjic.Edi.Dom.Segments.LX_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1">NM1</see> interface (Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3">N3</see> interface (Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4">N4</see> interface (Provider City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER">PER</see> interface (Provider Communications Numbers).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA">PLA</see> interface (Provider Change Reason).</summary>
        Public Shared Function CreatePLA() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA
            Return New Global.Madjic.Edi.Dom.Segments.PLA_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2320 loop (Coordination of Benefits).</summary>
    Public NotInheritable Class Loop2320Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB">COB</see> interface (Coordination of Benefits).</summary>
        Public Shared Function CreateCOB() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB
            Return New Global.Madjic.Edi.Dom.Segments.COB_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF">REF</see> interface (Additional Coordination of Benefits Identifiers).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP">DTP</see> interface (Coordination of Benefits Eligibility Dates).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330 loop (Coordination of Benefits Related Entity).</summary>
    Public NotInheritable Class Loop2330Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1">NM1</see> interface (Coordination of Benefits Related Entity).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3">N3</see> interface (Coordination of Benefits Related Entity Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4">N4</see> interface (Coordination of Benefits Other Insurance Company City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER">PER</see> interface (Administrative Communications Contact).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2700 loop (Member Reporting Categories).</summary>
    Public NotInheritable Class Loop2700Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX">LX</see> interface (Member Reporting Categories).</summary>
        Public Shared Function CreateLX() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX
            Return New Global.Madjic.Edi.Dom.Segments.LX_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2750 loop (Reporting Category).</summary>
    Public NotInheritable Class Loop2750Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1">N1</see> interface (Reporting Category).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF">REF</see> interface (Reporting Category Reference).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP">DTP</see> interface (Reporting Category Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class
End Namespace
