Namespace Factory.Transaction820_A1
    '''<summary>Provides methods for instantiating the Transaction820_A1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet">Transaction820_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet">Transaction820_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction820_A1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Standard_Obj("005010X218")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet">Transaction820_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet">Transaction820_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction820_A1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Standard_Obj(controlNumber, "005010X218")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST">ST</see> interface (820 Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR">BPR</see> interface (Financial Information).</summary>
        Public Shared Function CreateBPR() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.BPR
            Return New Global.Madjic.Edi.Dom.Segments.BPR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN">TRN</see> interface (Reassociation Trace Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR">CUR</see> interface (Foreign Currency Information).</summary>
        Public Shared Function CreateCUR() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.CUR
            Return New Global.Madjic.Edi.Dom.Segments.CUR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF">REF</see> interface (Premium Receivers Identification Key).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM">DTM</see> interface (Process Date).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1">DTM_1</see> interface (Delivery Date).</summary>
        Public Shared Function CreateDTM_1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_1
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2">DTM_2</see> interface (Coverage Period).</summary>
        Public Shared Function CreateDTM_2() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_2
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3">DTM_3</see> interface (Creation Date).</summary>
        Public Shared Function CreateDTM_3() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.DTM_3
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A">Loop1000A</see> interface (Premium Receiver's Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A">Loop1000A</see> interface.</returns>
        Public Shared Function CreateLoop1000A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B">Loop1000B</see> interface (Premium Payer's Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B">Loop1000B</see> interface.</returns>
        Public Shared Function CreateLoop1000B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C">Loop1000C</see> interface (Intermediary Bank Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C">Loop1000C</see> interface.</returns>
        Public Shared Function CreateLoop1000C() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop1000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A">Loop2000A</see> interface (Organization Summary Remittance).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A">Loop2200A</see> interface (Organization Summary Remittance Level Adjustment for Previous Payment).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A">Loop2200A</see> interface.</returns>
        Public Shared Function CreateLoop2200A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A">Loop2300A</see> interface (Organization Summary Remittance Detail).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A">Loop2300A</see> interface.</returns>
        Public Shared Function CreateLoop2300A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2300_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A">Loop2310A</see> interface (Summary Line Item).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A">Loop2310A</see> interface.</returns>
        Public Shared Function CreateLoop2310A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2310A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A">Loop2312A</see> interface (Service, Promotion, Allowance, or Charge Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A">Loop2312A</see> interface.</returns>
        Public Shared Function CreateLoop2312A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2312A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2312_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A">Loop2315A</see> interface (Member Count).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A">Loop2315A</see> interface.</returns>
        Public Shared Function CreateLoop2315A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2315A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2315_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A">Loop2320A</see> interface (Organization Summary Remittance Level Adjustment for Current Payment).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A">Loop2320A</see> interface.</returns>
        Public Shared Function CreateLoop2320A() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2320_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B">Loop2000B</see> interface (Individual Remittance).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B">Loop2100B</see> interface (Individual Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B">Loop2100B</see> interface.</returns>
        Public Shared Function CreateLoop2100B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2100B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B">Loop2200B</see> interface (Individual Premium Adjustment for Previous Payment).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B">Loop2200B</see> interface.</returns>
        Public Shared Function CreateLoop2200B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2200B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B">Loop2300B</see> interface (Individual Premium Remittance Detail).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B">Loop2300B</see> interface.</returns>
        Public Shared Function CreateLoop2300B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2300B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2300_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B">Loop2320B</see> interface (Individual Premium Adjustment for Current Payment).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B">Loop2320B</see> interface.</returns>
        Public Shared Function CreateLoop2320B() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Loops.Loop2320B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction820.Loop2320_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000A loop (Premium Receiver's Name).</summary>
    Public NotInheritable Class Loop1000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1">N1</see> interface (Premium Receiver's Name).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2">N2</see> interface (Premium Receiver Additional Name).</summary>
        Public Shared Function CreateN2() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2
            Return New Global.Madjic.Edi.Dom.Segments.N2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3">N3</see> interface (Premium Receiver's Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4">N4</see> interface (Premium Receiver's City, State, and ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM">RDM</see> interface (Premium Receiver's Remittance Delivery Method).</summary>
        Public Shared Function CreateRDM() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM
            Return New Global.Madjic.Edi.Dom.Segments.RDM_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000B loop (Premium Payer's Name).</summary>
    Public NotInheritable Class Loop1000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1">N1</see> interface (Premium Payer's Name).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2">N2</see> interface (Premium Payer Additional Name).</summary>
        Public Shared Function CreateN2() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2
            Return New Global.Madjic.Edi.Dom.Segments.N2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3">N3</see> interface (Premium Payer's Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4">N4</see> interface (Premium Payer's City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER">PER</see> interface (Premium Payer's Administrative Contact).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000C loop (Intermediary Bank Information).</summary>
    Public NotInheritable Class Loop1000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1">N1</see> interface (Intermediary Bank Information).</summary>
        Public Shared Function CreateN1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1
            Return New Global.Madjic.Edi.Dom.Segments.N1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2">N2</see> interface (Intermediary Bank Additional Name).</summary>
        Public Shared Function CreateN2() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2
            Return New Global.Madjic.Edi.Dom.Segments.N2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3">N3</see> interface (Intermediary Bank's Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4">N4</see> interface (Intermediary Bank's City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER">PER</see> interface (Intermediary Bank's Administrative Contact).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Organization Summary Remittance).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT">ENT</see> interface (Organization Summary Remittance).</summary>
        Public Shared Function CreateENT() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT
            Return New Global.Madjic.Edi.Dom.Segments.ENT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200A loop (Organization Summary Remittance Level Adjustment for Previous Payment).</summary>
    Public NotInheritable Class Loop2200AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX">ADX</see> interface (Organization Summary Remittance Level Adjustment for Previous Payment).</summary>
        Public Shared Function CreateADX() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX
            Return New Global.Madjic.Edi.Dom.Segments.ADX_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2300A loop (Organization Summary Remittance Detail).</summary>
    Public NotInheritable Class Loop2300AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR">RMR</see> interface (Organization Summary Remittance Detail).</summary>
        Public Shared Function CreateRMR() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR
            Return New Global.Madjic.Edi.Dom.Segments.RMR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF">REF</see> interface (Reference Information).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM">DTM</see> interface (Organizational Coverage Period).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310A loop (Summary Line Item).</summary>
    Public NotInheritable Class Loop2310AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1">IT1</see> interface (Summary Line Item).</summary>
        Public Shared Function CreateIT1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1
            Return New Global.Madjic.Edi.Dom.Segments.IT1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2312A loop (Service, Promotion, Allowance, or Charge Information).</summary>
    Public NotInheritable Class Loop2312AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC">SAC</see> interface (Service, Promotion, Allowance, or Charge Information).</summary>
        Public Shared Function CreateSAC() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC
            Return New Global.Madjic.Edi.Dom.Segments.SAC_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2315A loop (Member Count).</summary>
    Public NotInheritable Class Loop2315AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN">SLN</see> interface (Member Count).</summary>
        Public Shared Function CreateSLN() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN
            Return New Global.Madjic.Edi.Dom.Segments.SLN_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2320A loop (Organization Summary Remittance Level Adjustment for Current Payment).</summary>
    Public NotInheritable Class Loop2320AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX">ADX</see> interface (Organization Summary Remittance Level Adjustment for Current Payment).</summary>
        Public Shared Function CreateADX() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX
            Return New Global.Madjic.Edi.Dom.Segments.ADX_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Individual Remittance).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT">ENT</see> interface (Individual Remittance).</summary>
        Public Shared Function CreateENT() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT
            Return New Global.Madjic.Edi.Dom.Segments.ENT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100B loop (Individual Name).</summary>
    Public NotInheritable Class Loop2100BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1">NM1</see> interface (Individual Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2100B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200B loop (Individual Premium Adjustment for Previous Payment).</summary>
    Public NotInheritable Class Loop2200BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX">ADX</see> interface (Individual Premium Adjustment for Previous Payment).</summary>
        Public Shared Function CreateADX() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX
            Return New Global.Madjic.Edi.Dom.Segments.ADX_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2300B loop (Individual Premium Remittance Detail).</summary>
    Public NotInheritable Class Loop2300BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR">RMR</see> interface (Individual Premium Remittance Detail).</summary>
        Public Shared Function CreateRMR() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR
            Return New Global.Madjic.Edi.Dom.Segments.RMR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF">REF</see> interface (Reference Information).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM">DTM</see> interface (Individual Coverage Period).</summary>
        Public Shared Function CreateDTM() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM
            Return New Global.Madjic.Edi.Dom.Segments.DTM_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2320B loop (Individual Premium Adjustment for Current Payment).</summary>
    Public NotInheritable Class Loop2320BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX">ADX</see> interface (Individual Premium Adjustment for Current Payment).</summary>
        Public Shared Function CreateADX() As Global.Madjic.Edi.Dom.Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX
            Return New Global.Madjic.Edi.Dom.Segments.ADX_Obj
        End Function
    End Class
End Namespace
