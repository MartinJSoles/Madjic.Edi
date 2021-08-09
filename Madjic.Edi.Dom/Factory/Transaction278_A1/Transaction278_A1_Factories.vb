Namespace Factory.Transaction278_A1
    '''<summary>Provides methods for instantiating the Transaction278_A1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet">Transaction278_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet">Transaction278_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction278_A1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Standard_Obj("005010X217")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet">Transaction278_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet">Transaction278_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction278_A1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Standard_Obj(controlNumber, "005010X217")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT">BHT</see> interface (Beginning of Hierarchical Transaction).</summary>
        Public Shared Function CreateBHT() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.BHT
            Return New Global.Madjic.Edi.Dom.Segments.BHT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A">Loop2000A</see> interface (Utilization Management Organization (UMO) Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A">Loop2010A</see> interface (Utilization Management Organization (UMO) Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A">Loop2010A</see> interface.</returns>
        Public Shared Function CreateLoop2010A() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B">Loop2000B</see> interface (Requester Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B">Loop2010B</see> interface (Requester Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B">Loop2010B</see> interface.</returns>
        Public Shared Function CreateLoop2010B() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C">Loop2000C</see> interface (Subscriber Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C">Loop2000C</see> interface.</returns>
        Public Shared Function CreateLoop2000C() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C">Loop2010C</see> interface (Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C">Loop2010C</see> interface.</returns>
        Public Shared Function CreateLoop2010C() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D">Loop2000D</see> interface (Dependent Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D">Loop2000D</see> interface.</returns>
        Public Shared Function CreateLoop2000D() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D">Loop2010D</see> interface (Dependent Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D">Loop2010D</see> interface.</returns>
        Public Shared Function CreateLoop2010D() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E">Loop2000E</see> interface (Patient Event Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E">Loop2000E</see> interface.</returns>
        Public Shared Function CreateLoop2000E() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA">Loop2010EA</see> interface (Patient Event Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA">Loop2010EA</see> interface.</returns>
        Public Shared Function CreateLoop2010EA() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB">Loop2010EB</see> interface (Patient Event Transport Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB">Loop2010EB</see> interface.</returns>
        Public Shared Function CreateLoop2010EB() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EB
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC">Loop2010EC</see> interface (Patient Event Other UMO Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC">Loop2010EC</see> interface.</returns>
        Public Shared Function CreateLoop2010EC() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010EC
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F">Loop2000F</see> interface (Service Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F">Loop2000F</see> interface.</returns>
        Public Shared Function CreateLoop2000F() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2000F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F">Loop2010F</see> interface (Service Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F">Loop2010F</see> interface.</returns>
        Public Shared Function CreateLoop2010F() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Loops.Loop2010F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction278.Loop2010_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Utilization Management Organization (UMO) Level).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL">HL</see> interface (Utilization Management Organization (UMO) Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010A loop (Utilization Management Organization (UMO) Name).</summary>
    Public NotInheritable Class Loop2010AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1">NM1</see> interface (Utilization Management Organization (UMO) Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Requester Level).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL">HL</see> interface (Requester Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010B loop (Requester Name).</summary>
    Public NotInheritable Class Loop2010BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1">NM1</see> interface (Requester Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF">REF</see> interface (Requester Supplemental Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3">N3</see> interface (Requester Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4">N4</see> interface (Requester City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER">PER</see> interface (Requester Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV">PRV</see> interface (Requester Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000C loop (Subscriber Level).</summary>
    Public NotInheritable Class Loop2000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL">HL</see> interface (Subscriber Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010C loop (Subscriber Name).</summary>
    Public NotInheritable Class Loop2010CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1">NM1</see> interface (Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF">REF</see> interface (Subscriber Supplemental Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3">N3</see> interface (Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4">N4</see> interface (Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG">DMG</see> interface (Subscriber Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS">INS</see> interface (Subscriber Relationship).</summary>
        Public Shared Function CreateINS() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS
            Return New Global.Madjic.Edi.Dom.Segments.INS_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000D loop (Dependent Level).</summary>
    Public NotInheritable Class Loop2000DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL">HL</see> interface (Dependent Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010D loop (Dependent Name).</summary>
    Public NotInheritable Class Loop2010DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1">NM1</see> interface (Dependent Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF">REF</see> interface (Dependent Supplemental Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3">N3</see> interface (Dependent Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4">N4</see> interface (Dependent City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG">DMG</see> interface (Dependent Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS">INS</see> interface (Dependent Relationship).</summary>
        Public Shared Function CreateINS() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS
            Return New Global.Madjic.Edi.Dom.Segments.INS_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000E loop (Patient Event Level).</summary>
    Public NotInheritable Class Loop2000EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL">HL</see> interface (Patient Event Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN">TRN</see> interface (Patient Event Tracking Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM">UM</see> interface (Health Care Services Review Information).</summary>
        Public Shared Function CreateUM() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM
            Return New Global.Madjic.Edi.Dom.Segments.UM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF">REF</see> interface (Previous Review Authorization Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1">REF_1</see> interface (Previous Review Administrative Reference Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP">DTP</see> interface (Accident Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1">DTP_1</see> interface (Last Menstrual Period Date).</summary>
        Public Shared Function CreateDTP_1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_1
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2">DTP_2</see> interface (Estimated Date of Birth).</summary>
        Public Shared Function CreateDTP_2() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_2
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3">DTP_3</see> interface (Onset of Current Symptoms or Illness Date).</summary>
        Public Shared Function CreateDTP_3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_3
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4">DTP_4</see> interface (Event Date).</summary>
        Public Shared Function CreateDTP_4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_4
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5">DTP_5</see> interface (Admission Date).</summary>
        Public Shared Function CreateDTP_5() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_5
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6">DTP_6</see> interface (Discharge Date).</summary>
        Public Shared Function CreateDTP_6() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.DTP_6
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI">HI</see> interface (Patient Diagnosis).</summary>
        Public Shared Function CreateHI() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD">HSD</see> interface (Health Care Services Delivery).</summary>
        Public Shared Function CreateHSD() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD
            Return New Global.Madjic.Edi.Dom.Segments.HSD_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC">CRC</see> interface (Ambulance Certification Information).</summary>
        Public Shared Function CreateCRC() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1">CRC_1</see> interface (Chiropractic Certification Information).</summary>
        Public Shared Function CreateCRC_1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2">CRC_2</see> interface (Durable Medical Equipment Information).</summary>
        Public Shared Function CreateCRC_2() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3">CRC_3</see> interface (Oxygen Therapy Certification Information).</summary>
        Public Shared Function CreateCRC_3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4">CRC_4</see> interface (Functional Limitations Information).</summary>
        Public Shared Function CreateCRC_4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5">CRC_5</see> interface (Activities Permitted Information).</summary>
        Public Shared Function CreateCRC_5() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6">CRC_6</see> interface (Mental Status Information).</summary>
        Public Shared Function CreateCRC_6() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1">CL1</see> interface (Institutional Claim Code).</summary>
        Public Shared Function CreateCL1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1
            Return New Global.Madjic.Edi.Dom.Segments.CL1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1">CR1</see> interface (Ambulance Transport Information).</summary>
        Public Shared Function CreateCR1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1
            Return New Global.Madjic.Edi.Dom.Segments.CR1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2">CR2</see> interface (Spinal Manipulation Service Information).</summary>
        Public Shared Function CreateCR2() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2
            Return New Global.Madjic.Edi.Dom.Segments.CR2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6">CR6</see> interface (Home Health Care Information).</summary>
        Public Shared Function CreateCR6() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6
            Return New Global.Madjic.Edi.Dom.Segments.CR6_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK">PWK</see> interface (Additional Patient Information).</summary>
        Public Shared Function CreatePWK() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG">MSG</see> interface (Message Text).</summary>
        Public Shared Function CreateMSG() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG
            Return New Global.Madjic.Edi.Dom.Segments.MSG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023" /> interface (Health Care Service Location Information).</summary>
        Public Shared Function CreateUM04() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C023_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.DataElements.Composite.C024" /> interface (Related Causes Information).</summary>
        Public Shared Function CreateUM05() As Global.Madjic.Edi.Dom.DataElements.Composite.C024
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C024_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI01() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI02() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI03() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI04() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI05() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI06() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI07() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI08() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI09() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI10() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI11() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI12() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010EA loop (Patient Event Provider Name).</summary>
    Public NotInheritable Class Loop2010EAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1">NM1</see> interface (Patient Event Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF">REF</see> interface (Patient Event Provider Supplemental Information).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3">N3</see> interface (Patient Event Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4">N4</see> interface (Patient Event City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER">PER</see> interface (Patient Event Provider Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV">PRV</see> interface (Patient Event Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010EB loop (Patient Event Transport Information).</summary>
    Public NotInheritable Class Loop2010EBFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1">NM1</see> interface (Patient Event Transport Information).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3">N3</see> interface (Patient Event Transport Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4">N4</see> interface (Patient Event Transport Location City/State/ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010EC loop (Patient Event Other UMO Name).</summary>
    Public NotInheritable Class Loop2010ECFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1">NM1</see> interface (Patient Event Other UMO Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF">REF</see> interface (Other UMO Denial Reason).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP">DTP</see> interface (Other UMO Denial Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EC.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000F loop (Service Level).</summary>
    Public NotInheritable Class Loop2000FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL">HL</see> interface (Service Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN">TRN</see> interface (Service Trace Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM">UM</see> interface (Health Care Services Review Information).</summary>
        Public Shared Function CreateUM() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM
            Return New Global.Madjic.Edi.Dom.Segments.UM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF">REF</see> interface (Previous Review Authorization Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1">REF_1</see> interface (Previous Review Administrative Reference Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP">DTP</see> interface (Service Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1">SV1</see> interface (Professional Service).</summary>
        Public Shared Function CreateSV1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1
            Return New Global.Madjic.Edi.Dom.Segments.SV1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2">SV2</see> interface (Institutional Service Line).</summary>
        Public Shared Function CreateSV2() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2
            Return New Global.Madjic.Edi.Dom.Segments.SV2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3">SV3</see> interface (Dental Service).</summary>
        Public Shared Function CreateSV3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3
            Return New Global.Madjic.Edi.Dom.Segments.SV3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO">TOO</see> interface (Tooth Information).</summary>
        Public Shared Function CreateTOO() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO
            Return New Global.Madjic.Edi.Dom.Segments.TOO_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD">HSD</see> interface (Health Care Services Delivery).</summary>
        Public Shared Function CreateHSD() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD
            Return New Global.Madjic.Edi.Dom.Segments.HSD_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK">PWK</see> interface (Additional Service Information).</summary>
        Public Shared Function CreatePWK() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG">MSG</see> interface (Message Text).</summary>
        Public Shared Function CreateMSG() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG
            Return New Global.Madjic.Edi.Dom.Segments.MSG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023" /> interface (Health Care Service Location Information).</summary>
        Public Shared Function CreateUM04() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C023_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010F loop (Service Provider Name).</summary>
    Public NotInheritable Class Loop2010FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1">NM1</see> interface (Service Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF">REF</see> interface (Service Provider Supplemental Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3">N3</see> interface (Service Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4">N4</see> interface (Service Provider City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER">PER</see> interface (Service Provider Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV">PRV</see> interface (Service Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
    End Class
End Namespace
