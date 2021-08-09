Namespace Factory.Transaction277_A1
    '''<summary>Provides methods for instantiating the Transaction277_A1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet">Transaction277_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet">Transaction277_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction277_A1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Standard_Obj("005010X212")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet">Transaction277_A1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet">Transaction277_A1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction277_A1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Standard_Obj(controlNumber, "005010X212")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.BHT">BHT</see> interface (Beginning of Hierarchical Transaction).</summary>
        Public Shared Function CreateBHT() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.BHT
            Return New Global.Madjic.Edi.Dom.Segments.BHT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000A">Loop2000A</see> interface (Information Source Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100A">Loop2100A</see> interface (Payer Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100A">Loop2100A</see> interface.</returns>
        Public Shared Function CreateLoop2100A() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000B">Loop2000B</see> interface (Information Receiver Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100B">Loop2100B</see> interface (Information Receiver Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100B">Loop2100B</see> interface.</returns>
        Public Shared Function CreateLoop2100B() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200B">Loop2200B</see> interface (Information Receiver Trace Identifier).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200B">Loop2200B</see> interface.</returns>
        Public Shared Function CreateLoop2200B() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000C">Loop2000C</see> interface (Service Provider Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000C">Loop2000C</see> interface.</returns>
        Public Shared Function CreateLoop2000C() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100C">Loop2100C</see> interface (Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100C">Loop2100C</see> interface.</returns>
        Public Shared Function CreateLoop2100C() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200C">Loop2200C</see> interface (Provider of Service Trace Identifier).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200C">Loop2200C</see> interface.</returns>
        Public Shared Function CreateLoop2200C() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000D">Loop2000D</see> interface (Subscriber Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000D">Loop2000D</see> interface.</returns>
        Public Shared Function CreateLoop2000D() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100D">Loop2100D</see> interface (Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100D">Loop2100D</see> interface.</returns>
        Public Shared Function CreateLoop2100D() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200D">Loop2200D</see> interface (Claim Status Tracking Number).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200D">Loop2200D</see> interface.</returns>
        Public Shared Function CreateLoop2200D() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220D">Loop2220D</see> interface (Service Line Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220D">Loop2220D</see> interface.</returns>
        Public Shared Function CreateLoop2220D() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2220_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000E">Loop2000E</see> interface (Dependent Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000E">Loop2000E</see> interface.</returns>
        Public Shared Function CreateLoop2000E() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2000E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100E">Loop2100E</see> interface (Dependent Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100E">Loop2100E</see> interface.</returns>
        Public Shared Function CreateLoop2100E() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2100E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200E">Loop2200E</see> interface (Claim Status Tracking Number).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200E">Loop2200E</see> interface.</returns>
        Public Shared Function CreateLoop2200E() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2200E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2200_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220E">Loop2220E</see> interface (Service Line Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220E">Loop2220E</see> interface.</returns>
        Public Shared Function CreateLoop2220E() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Loops.Loop2220E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction277.Loop2220_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Information Source Level).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL">HL</see> interface (Information Source Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100A loop (Payer Name).</summary>
    Public NotInheritable Class Loop2100AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.NM1">NM1</see> interface (Payer Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER">PER</see> interface (Payer Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Information Receiver Level).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL">HL</see> interface (Information Receiver Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100B loop (Information Receiver Name).</summary>
    Public NotInheritable Class Loop2100BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100B.NM1">NM1</see> interface (Information Receiver Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200B loop (Information Receiver Trace Identifier).</summary>
    Public NotInheritable Class Loop2200BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.TRN">TRN</see> interface (Information Receiver Trace Identifier).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC">STC</see> interface (Information Receiver Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC01() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC10() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC11() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000C loop (Service Provider Level).</summary>
    Public NotInheritable Class Loop2000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL">HL</see> interface (Service Provider Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100C loop (Provider Name).</summary>
    Public NotInheritable Class Loop2100CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100C.NM1">NM1</see> interface (Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200C loop (Provider of Service Trace Identifier).</summary>
    Public NotInheritable Class Loop2200CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.TRN">TRN</see> interface (Provider of Service Trace Identifier).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC">STC</see> interface (Provider Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC01() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC10() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.C043" /> interface (Health Care Claim Status).</summary>
        Public Shared Function CreateSTC11() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.C043
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C043_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000D loop (Subscriber Level).</summary>
    Public NotInheritable Class Loop2000DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL">HL</see> interface (Subscriber Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100D loop (Subscriber Name).</summary>
    Public NotInheritable Class Loop2100DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100D.NM1">NM1</see> interface (Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200D loop (Claim Status Tracking Number).</summary>
    Public NotInheritable Class Loop2200DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.TRN">TRN</see> interface (Claim Status Tracking Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC">STC</see> interface (Claim Level Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF">REF</see> interface (Payer Claim Control Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_1">REF_1</see> interface (Institutional Bill Type Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_2">REF_2</see> interface (Patient Control Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_3">REF_3</see> interface (Pharmacy Prescription Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_4">REF_4</see> interface (Voucher Identifier).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_5">REF_5</see> interface (Claim Identification Number For Clearinghouses and Other Transmission Intermediaries).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.DTP">DTP</see> interface (Claim Service Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2220D loop (Service Line Information).</summary>
    Public NotInheritable Class Loop2220DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC">SVC</see> interface (Service Line Information).</summary>
        Public Shared Function CreateSVC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC
            Return New Global.Madjic.Edi.Dom.Segments.SVC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC">STC</see> interface (Service Line Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.REF">REF</see> interface (Service Line Item Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.DTP">DTP</see> interface (Service Line Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.C003" /> interface (Composite Medical Procedure Identifier).</summary>
        Public Shared Function CreateSVC01() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.C003
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C003_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000E loop (Dependent Level).</summary>
    Public NotInheritable Class Loop2000EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL">HL</see> interface (Dependent Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100E loop (Dependent Name).</summary>
    Public NotInheritable Class Loop2100EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100E.NM1">NM1</see> interface (Dependent Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2100E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2200E loop (Claim Status Tracking Number).</summary>
    Public NotInheritable Class Loop2200EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.TRN">TRN</see> interface (Claim Status Tracking Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC">STC</see> interface (Claim Level Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF">REF</see> interface (Payer Claim Control Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_1">REF_1</see> interface (Institutional Bill Type Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_2">REF_2</see> interface (Patient Control Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_3">REF_3</see> interface (Pharmacy Prescription Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_4">REF_4</see> interface (Voucher Identifier).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_5">REF_5</see> interface (Claim Identification Number For Clearinghouses and Other Transmission Intermediaries).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.DTP">DTP</see> interface (Claim Service Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2220E loop (Service Line Information).</summary>
    Public NotInheritable Class Loop2220EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC">SVC</see> interface (Service Line Information).</summary>
        Public Shared Function CreateSVC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC
            Return New Global.Madjic.Edi.Dom.Segments.SVC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC">STC</see> interface (Service Line Status Information).</summary>
        Public Shared Function CreateSTC() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC
            Return New Global.Madjic.Edi.Dom.Segments.STC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.REF">REF</see> interface (Service Line Item Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.DTP">DTP</see> interface (Service Line Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.C003" /> interface (Composite Medical Procedure Identifier).</summary>
        Public Shared Function CreateSVC01() As Global.Madjic.Edi.Dom.Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.C003
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C003_Obj
        End Function
    End Class
End Namespace
