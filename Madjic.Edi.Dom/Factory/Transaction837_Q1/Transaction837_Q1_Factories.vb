Namespace Factory.Transaction837_Q1
    '''<summary>Provides methods for instantiating the Transaction837_Q1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet">Transaction837_Q1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet">Transaction837_Q1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction837_Q1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Standard_Obj("005010X222A1")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet">Transaction837_Q1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet">Transaction837_Q1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction837_Q1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Standard_Obj(controlNumber, "005010X222A1")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.BHT">BHT</see> interface (Beginning of Hierarchical Transaction).</summary>
        Public Shared Function CreateBHT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.BHT
            Return New Global.Madjic.Edi.Dom.Segments.BHT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000A">Loop1000A</see> interface (Submitter Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000A">Loop1000A</see> interface.</returns>
        Public Shared Function CreateLoop1000A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000B">Loop1000B</see> interface (Receiver Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000B">Loop1000B</see> interface.</returns>
        Public Shared Function CreateLoop1000B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop1000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000A">Loop2000A</see> interface (Billing Provider Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AA">Loop2010AA</see> interface (Billing Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AA">Loop2010AA</see> interface.</returns>
        Public Shared Function CreateLoop2010AA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AB">Loop2010AB</see> interface (Pay-to Address Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AB">Loop2010AB</see> interface.</returns>
        Public Shared Function CreateLoop2010AB() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AB
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AC">Loop2010AC</see> interface (Pay-To Plan Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AC">Loop2010AC</see> interface.</returns>
        Public Shared Function CreateLoop2010AC() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010AC
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000B">Loop2000B</see> interface (Subscriber Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BA">Loop2010BA</see> interface (Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BA">Loop2010BA</see> interface.</returns>
        Public Shared Function CreateLoop2010BA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BB">Loop2010BB</see> interface (Payer Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BB">Loop2010BB</see> interface.</returns>
        Public Shared Function CreateLoop2010BB() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010BB
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000C">Loop2000C</see> interface (Patient Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000C">Loop2000C</see> interface.</returns>
        Public Shared Function CreateLoop2000C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010CA">Loop2010CA</see> interface (Patient Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010CA">Loop2010CA</see> interface.</returns>
        Public Shared Function CreateLoop2010CA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2010CA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2300">Loop2300</see> interface (Claim Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2300">Loop2300</see> interface.</returns>
        Public Shared Function CreateLoop2300() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2300
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2300_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310A">Loop2310A</see> interface (Referring Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310A">Loop2310A</see> interface.</returns>
        Public Shared Function CreateLoop2310A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310B">Loop2310B</see> interface (Rendering Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310B">Loop2310B</see> interface.</returns>
        Public Shared Function CreateLoop2310B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310C">Loop2310C</see> interface (Service Facility Location Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310C">Loop2310C</see> interface.</returns>
        Public Shared Function CreateLoop2310C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310D">Loop2310D</see> interface (Supervising Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310D">Loop2310D</see> interface.</returns>
        Public Shared Function CreateLoop2310D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310E">Loop2310E</see> interface (Ambulance Pick-up Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310E">Loop2310E</see> interface.</returns>
        Public Shared Function CreateLoop2310E() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310F">Loop2310F</see> interface (Ambulance Drop-off Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310F">Loop2310F</see> interface.</returns>
        Public Shared Function CreateLoop2310F() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2310F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2320">Loop2320</see> interface (Other Subscriber Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2320">Loop2320</see> interface.</returns>
        Public Shared Function CreateLoop2320() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2320
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2320_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330A">Loop2330A</see> interface (Other Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330A">Loop2330A</see> interface.</returns>
        Public Shared Function CreateLoop2330A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330B">Loop2330B</see> interface (Other Payer Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330B">Loop2330B</see> interface.</returns>
        Public Shared Function CreateLoop2330B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330C">Loop2330C</see> interface (Other Payer Referring Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330C">Loop2330C</see> interface.</returns>
        Public Shared Function CreateLoop2330C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330D">Loop2330D</see> interface (Other Payer Rendering Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330D">Loop2330D</see> interface.</returns>
        Public Shared Function CreateLoop2330D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330E">Loop2330E</see> interface (Other Payer Service Facility Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330E">Loop2330E</see> interface.</returns>
        Public Shared Function CreateLoop2330E() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330F">Loop2330F</see> interface (Other Payer Supervising Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330F">Loop2330F</see> interface.</returns>
        Public Shared Function CreateLoop2330F() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330G">Loop2330G</see> interface (Other Payer Billing Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330G">Loop2330G</see> interface.</returns>
        Public Shared Function CreateLoop2330G() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2330G
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2400">Loop2400</see> interface (Service Line Number).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2400">Loop2400</see> interface.</returns>
        Public Shared Function CreateLoop2400() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2400
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2400_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420A">Loop2420A</see> interface (Rendering Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420A">Loop2420A</see> interface.</returns>
        Public Shared Function CreateLoop2420A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420B">Loop2420B</see> interface (Purchased Service Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420B">Loop2420B</see> interface.</returns>
        Public Shared Function CreateLoop2420B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420C">Loop2420C</see> interface (Service Facility Location Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420C">Loop2420C</see> interface.</returns>
        Public Shared Function CreateLoop2420C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420D">Loop2420D</see> interface (Supervising Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420D">Loop2420D</see> interface.</returns>
        Public Shared Function CreateLoop2420D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420E">Loop2420E</see> interface (Ordering Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420E">Loop2420E</see> interface.</returns>
        Public Shared Function CreateLoop2420E() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420F">Loop2420F</see> interface (Referring Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420F">Loop2420F</see> interface.</returns>
        Public Shared Function CreateLoop2420F() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420G">Loop2420G</see> interface (Ambulance Pick-up Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420G">Loop2420G</see> interface.</returns>
        Public Shared Function CreateLoop2420G() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420G
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420H">Loop2420H</see> interface (Ambulance Drop-off Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420H">Loop2420H</see> interface.</returns>
        Public Shared Function CreateLoop2420H() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2420H
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2430">Loop2430</see> interface (Line Adjudication Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2430">Loop2430</see> interface.</returns>
        Public Shared Function CreateLoop2430() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2430
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2430_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2440">Loop2440</see> interface (Form Identification Code).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2440">Loop2440</see> interface.</returns>
        Public Shared Function CreateLoop2440() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Loops.Loop2440
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2440_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000A loop (Submitter Name).</summary>
    Public NotInheritable Class Loop1000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.NM1">NM1</see> interface (Submitter Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER">PER</see> interface (Submitter EDI Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000B loop (Receiver Name).</summary>
    Public NotInheritable Class Loop1000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000B.NM1">NM1</see> interface (Receiver Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Billing Provider Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL">HL</see> interface (Billing Provider Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV">PRV</see> interface (Billing Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.CUR">CUR</see> interface (Foreign Currency Information).</summary>
        Public Shared Function CreateCUR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.CUR
            Return New Global.Madjic.Edi.Dom.Segments.CUR_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AA loop (Billing Provider Name).</summary>
    Public NotInheritable Class Loop2010AAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.NM1">NM1</see> interface (Billing Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N3">N3</see> interface (Billing Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4">N4</see> interface (Billing Provider City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.REF">REF</see> interface (Billing Provider Tax Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.REF_1">REF_1</see> interface (Billing Provider UPIN/License Information).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER">PER</see> interface (Billing Provider Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AB loop (Pay-to Address Name).</summary>
    Public NotInheritable Class Loop2010ABFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.NM1">NM1</see> interface (Pay-to Address Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N3">N3</see> interface (Pay-to Address - ADDRESS).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4">N4</see> interface (Pay-To Address City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AC loop (Pay-To Plan Name).</summary>
    Public NotInheritable Class Loop2010ACFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.NM1">NM1</see> interface (Pay-To Plan Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N3">N3</see> interface (Pay-to Plan Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4">N4</see> interface (Pay-To Plan City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.REF">REF</see> interface (Pay-to Plan Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.REF_1">REF_1</see> interface (Pay-To Plan Tax Identification Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Subscriber Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL">HL</see> interface (Subscriber Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR">SBR</see> interface (Subscriber Information).</summary>
        Public Shared Function CreateSBR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR
            Return New Global.Madjic.Edi.Dom.Segments.SBR_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010BA loop (Subscriber Name).</summary>
    Public NotInheritable Class Loop2010BAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.NM1">NM1</see> interface (Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N3">N3</see> interface (Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4">N4</see> interface (Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG">DMG</see> interface (Subscriber Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.REF">REF</see> interface (Subscriber Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.REF_1">REF_1</see> interface (Property and Casualty Claim Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER">PER</see> interface (Property and Casualty Subscriber Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010BB loop (Payer Name).</summary>
    Public NotInheritable Class Loop2010BBFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.NM1">NM1</see> interface (Payer Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N3">N3</see> interface (Payer Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4">N4</see> interface (Payer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.REF">REF</see> interface (Payer Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.REF_1">REF_1</see> interface (Billing Provider Secondary Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000C loop (Patient Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL">HL</see> interface (Patient Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT">PAT</see> interface (Patient Information).</summary>
        Public Shared Function CreatePAT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT
            Return New Global.Madjic.Edi.Dom.Segments.PAT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010CA loop (Patient Name).</summary>
    Public NotInheritable Class Loop2010CAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.NM1">NM1</see> interface (Patient Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N3">N3</see> interface (Patient Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4">N4</see> interface (Patient City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG">DMG</see> interface (Patient Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.REF">REF</see> interface (Property and Casualty Claim Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.REF_1">REF_1</see> interface (Property and Casualty Patient Identifier).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER">PER</see> interface (Property and Casualty Patient Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2300 loop (Claim Information).</summary>
    Public NotInheritable Class Loop2300Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM">CLM</see> interface (Claim Information).</summary>
        Public Shared Function CreateCLM() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM
            Return New Global.Madjic.Edi.Dom.Segments.CLM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP">DTP</see> interface (Date - Onset of Current Illness or Symptom).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_1">DTP_1</see> interface (Date - Initial Treatment Date).</summary>
        Public Shared Function CreateDTP_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_1
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_2">DTP_2</see> interface (Date - Last Seen Date).</summary>
        Public Shared Function CreateDTP_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_2
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_3">DTP_3</see> interface (Date - Acute Manifestation).</summary>
        Public Shared Function CreateDTP_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_3
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_4">DTP_4</see> interface (Date - Accident).</summary>
        Public Shared Function CreateDTP_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_4
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_5">DTP_5</see> interface (Date - Last Menstrual Period).</summary>
        Public Shared Function CreateDTP_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_5
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_6">DTP_6</see> interface (Date - Last X-ray Date).</summary>
        Public Shared Function CreateDTP_6() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_6
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_7">DTP_7</see> interface (Date - Hearing and Vision Prescription Date).</summary>
        Public Shared Function CreateDTP_7() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_7
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_8">DTP_8</see> interface (Date - Disability Dates).</summary>
        Public Shared Function CreateDTP_8() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_8
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_9">DTP_9</see> interface (Date - Last Worked).</summary>
        Public Shared Function CreateDTP_9() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_9
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_10">DTP_10</see> interface (Date - Authorized Return to Work).</summary>
        Public Shared Function CreateDTP_10() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_10
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_11">DTP_11</see> interface (Date - Admission).</summary>
        Public Shared Function CreateDTP_11() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_11
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_12">DTP_12</see> interface (Date - Discharge).</summary>
        Public Shared Function CreateDTP_12() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_12
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_13">DTP_13</see> interface (Date - Assumed and Relinquished Care Dates).</summary>
        Public Shared Function CreateDTP_13() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_13
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_14">DTP_14</see> interface (Date - Property and Casualty Date of First Contact).</summary>
        Public Shared Function CreateDTP_14() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_14
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_15">DTP_15</see> interface (Date - Repricer Received Date).</summary>
        Public Shared Function CreateDTP_15() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.DTP_15
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK">PWK</see> interface (Claim Supplemental Information).</summary>
        Public Shared Function CreatePWK() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1">CN1</see> interface (Contract Information).</summary>
        Public Shared Function CreateCN1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1
            Return New Global.Madjic.Edi.Dom.Segments.CN1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.AMT">AMT</see> interface (Patient Amount Paid).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF">REF</see> interface (Service Authorization Exception Code).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_1">REF_1</see> interface (Mandatory Medicare (Section 4081) Crossover Indicator).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_2">REF_2</see> interface (Mammography Certification Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_3">REF_3</see> interface (Referral Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_4">REF_4</see> interface (Prior Authorization).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_5">REF_5</see> interface (Payer Claim Control Number).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_6">REF_6</see> interface (Clinical Laboratory Improvement Amendment (CLIA) Number).</summary>
        Public Shared Function CreateREF_6() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_6
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_7">REF_7</see> interface (Repriced Claim Number).</summary>
        Public Shared Function CreateREF_7() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_7
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_8">REF_8</see> interface (Adjusted Repriced Claim Number).</summary>
        Public Shared Function CreateREF_8() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_8
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_9">REF_9</see> interface (Investigational Device Exemption Number).</summary>
        Public Shared Function CreateREF_9() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_9
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_10">REF_10</see> interface (Claim Identifier For Transmission Intermediaries).</summary>
        Public Shared Function CreateREF_10() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_10
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_11">REF_11</see> interface (Medical Record Number).</summary>
        Public Shared Function CreateREF_11() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_11
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_12">REF_12</see> interface (Demonstration Project Identifier).</summary>
        Public Shared Function CreateREF_12() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_12
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_13">REF_13</see> interface (Care Plan Oversight).</summary>
        Public Shared Function CreateREF_13() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.REF_13
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.K3">K3</see> interface (File Information).</summary>
        Public Shared Function CreateK3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.K3
            Return New Global.Madjic.Edi.Dom.Segments.K3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.NTE">NTE</see> interface (Claim Note).</summary>
        Public Shared Function CreateNTE() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.NTE
            Return New Global.Madjic.Edi.Dom.Segments.NTE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1">CR1</see> interface (Ambulance Transport Information).</summary>
        Public Shared Function CreateCR1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1
            Return New Global.Madjic.Edi.Dom.Segments.CR1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC">CRC</see> interface (Ambulance Certification).</summary>
        Public Shared Function CreateCRC() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1">CRC_1</see> interface (Patient Condition Information: Vision).</summary>
        Public Shared Function CreateCRC_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2">CRC_2</see> interface (Homebound Indicator).</summary>
        Public Shared Function CreateCRC_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3">CRC_3</see> interface (EPSDT Referral).</summary>
        Public Shared Function CreateCRC_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI">HI</see> interface (Health Care Diagnosis Code).</summary>
        Public Shared Function CreateHI() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_1">HI_1</see> interface (Anesthesia Related Procedure).</summary>
        Public Shared Function CreateHI_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_1
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2">HI_2</see> interface (Condition Information).</summary>
        Public Shared Function CreateHI_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP">HCP</see> interface (Claim Pricing/Repricing Information).</summary>
        Public Shared Function CreateHCP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP
            Return New Global.Madjic.Edi.Dom.Segments.HCP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310A loop (Referring Provider Name).</summary>
    Public NotInheritable Class Loop2310AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310A.NM1">NM1</see> interface (Referring Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310A.REF">REF</see> interface (Referring Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310B loop (Rendering Provider Name).</summary>
    Public NotInheritable Class Loop2310BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.NM1">NM1</see> interface (Rendering Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV">PRV</see> interface (Rendering Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.REF">REF</see> interface (Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310C loop (Service Facility Location Name).</summary>
    Public NotInheritable Class Loop2310CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.NM1">NM1</see> interface (Service Facility Location Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N3">N3</see> interface (Service Facility Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4">N4</see> interface (Service Facility Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.REF">REF</see> interface (Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER">PER</see> interface (Service Facility Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310D loop (Supervising Provider Name).</summary>
    Public NotInheritable Class Loop2310DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310D.NM1">NM1</see> interface (Supervising Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310D.REF">REF</see> interface (Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310E loop (Ambulance Pick-up Location).</summary>
    Public NotInheritable Class Loop2310EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.NM1">NM1</see> interface (Ambulance Pick-up Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N3">N3</see> interface (Ambulance Pick-up Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4">N4</see> interface (Ambulance Pick-up Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310F loop (Ambulance Drop-off Location).</summary>
    Public NotInheritable Class Loop2310FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.NM1">NM1</see> interface (Ambulance Drop-off Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N3">N3</see> interface (Ambulance Drop-off Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4">N4</see> interface (Ambulance Drop-off Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2320 loop (Other Subscriber Information).</summary>
    Public NotInheritable Class Loop2320Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR">SBR</see> interface (Other Subscriber Information).</summary>
        Public Shared Function CreateSBR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR
            Return New Global.Madjic.Edi.Dom.Segments.SBR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS">CAS</see> interface (Claim Level Adjustments).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT">AMT</see> interface (Coordination of Benefits (COB) Payer Paid Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_1">AMT_1</see> interface (Coordination of Benefits (COB) Total Non-Covered Amount).</summary>
        Public Shared Function CreateAMT_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_1
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_2">AMT_2</see> interface (Remaining Patient Liability).</summary>
        Public Shared Function CreateAMT_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_2
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA">MOA</see> interface (Outpatient Adjudication Information).</summary>
        Public Shared Function CreateMOA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA
            Return New Global.Madjic.Edi.Dom.Segments.MOA_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330A loop (Other Subscriber Name).</summary>
    Public NotInheritable Class Loop2330AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.NM1">NM1</see> interface (Other Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N3">N3</see> interface (Other Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4">N4</see> interface (Other Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.REF">REF</see> interface (Other Subscriber Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330B loop (Other Payer Name).</summary>
    Public NotInheritable Class Loop2330BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.NM1">NM1</see> interface (Other Payer Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N3">N3</see> interface (Other Payer Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4">N4</see> interface (Other Payer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.DTP">DTP</see> interface (Claim Check or Remittance Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF">REF</see> interface (Other Payer Secondary Identifier).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_1">REF_1</see> interface (Other Payer Prior Authorization Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_2">REF_2</see> interface (Other Payer Referral Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_3">REF_3</see> interface (Other Payer Claim Adjustment Indicator).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_4">REF_4</see> interface (Other Payer Claim Control Number).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330C loop (Other Payer Referring Provider).</summary>
    Public NotInheritable Class Loop2330CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330C.NM1">NM1</see> interface (Other Payer Referring Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330C.REF">REF</see> interface (Other Payer Referring Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330D loop (Other Payer Rendering Provider).</summary>
    Public NotInheritable Class Loop2330DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330D.NM1">NM1</see> interface (Other Payer Rendering Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330D.REF">REF</see> interface (Other Payer Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330E loop (Other Payer Service Facility Location).</summary>
    Public NotInheritable Class Loop2330EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330E.NM1">NM1</see> interface (Other Payer Service Facility Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330E.REF">REF</see> interface (Other Payer Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330F loop (Other Payer Supervising Provider).</summary>
    Public NotInheritable Class Loop2330FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330F.NM1">NM1</see> interface (Other Payer Supervising Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330F.REF">REF</see> interface (Other Payer Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330F.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330G loop (Other Payer Billing Provider).</summary>
    Public NotInheritable Class Loop2330GFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330G.NM1">NM1</see> interface (Other Payer Billing Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330G.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330G.REF">REF</see> interface (Other Payer Billing Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330G.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2400 loop (Service Line Number).</summary>
    Public NotInheritable Class Loop2400Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.LX">LX</see> interface (Service Line Number).</summary>
        Public Shared Function CreateLX() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.LX
            Return New Global.Madjic.Edi.Dom.Segments.LX_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1">SV1</see> interface (Professional Service).</summary>
        Public Shared Function CreateSV1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1
            Return New Global.Madjic.Edi.Dom.Segments.SV1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5">SV5</see> interface (Durable Medical Equipment Service).</summary>
        Public Shared Function CreateSV5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5
            Return New Global.Madjic.Edi.Dom.Segments.SV5_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK">PWK</see> interface (Line Supplemental Information).</summary>
        Public Shared Function CreatePWK() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK_1">PWK_1</see> interface (Durable Medical Equipment Certificate of Medical Necessity Indicator).</summary>
        Public Shared Function CreatePWK_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK_1
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1">CR1</see> interface (Ambulance Transport Information).</summary>
        Public Shared Function CreateCR1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1
            Return New Global.Madjic.Edi.Dom.Segments.CR1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3">CR3</see> interface (Durable Medical Equipment Certification).</summary>
        Public Shared Function CreateCR3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3
            Return New Global.Madjic.Edi.Dom.Segments.CR3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC">CRC</see> interface (Ambulance Certification).</summary>
        Public Shared Function CreateCRC() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1">CRC_1</see> interface (Hospice Employee Indicator).</summary>
        Public Shared Function CreateCRC_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2">CRC_2</see> interface (Condition Indicator/Durable Medical Equipment).</summary>
        Public Shared Function CreateCRC_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2
            Return New Global.Madjic.Edi.Dom.Segments.CRC_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP">DTP</see> interface (Date - Service Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_1">DTP_1</see> interface (Date - Prescription Date).</summary>
        Public Shared Function CreateDTP_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_1
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_2">DTP_2</see> interface (DATE - Certification Revision/Recertification Date).</summary>
        Public Shared Function CreateDTP_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_2
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_3">DTP_3</see> interface (Date - Begin Therapy Date).</summary>
        Public Shared Function CreateDTP_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_3
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_4">DTP_4</see> interface (Date - Last Certification Date).</summary>
        Public Shared Function CreateDTP_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_4
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_5">DTP_5</see> interface (Date - Last Seen Date).</summary>
        Public Shared Function CreateDTP_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_5
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_6">DTP_6</see> interface (Date - Test Date).</summary>
        Public Shared Function CreateDTP_6() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_6
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_7">DTP_7</see> interface (Date - Shipped Date).</summary>
        Public Shared Function CreateDTP_7() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_7
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_8">DTP_8</see> interface (Date - Last X-ray Date).</summary>
        Public Shared Function CreateDTP_8() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_8
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_9">DTP_9</see> interface (Date - Initial Treatment Date).</summary>
        Public Shared Function CreateDTP_9() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.DTP_9
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY">QTY</see> interface (Ambulance Patient Count).</summary>
        Public Shared Function CreateQTY() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY
            Return New Global.Madjic.Edi.Dom.Segments.QTY_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY_1">QTY_1</see> interface (Obstetric Anesthesia Additional Units).</summary>
        Public Shared Function CreateQTY_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY_1
            Return New Global.Madjic.Edi.Dom.Segments.QTY_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA">MEA</see> interface (Test Result).</summary>
        Public Shared Function CreateMEA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA
            Return New Global.Madjic.Edi.Dom.Segments.MEA_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1">CN1</see> interface (Contract Information).</summary>
        Public Shared Function CreateCN1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1
            Return New Global.Madjic.Edi.Dom.Segments.CN1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF">REF</see> interface (Repriced Line Item Reference Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_1">REF_1</see> interface (Adjusted Repriced Line Item Reference Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_2">REF_2</see> interface (Prior Authorization).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_3">REF_3</see> interface (Line Item Control Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_4">REF_4</see> interface (Mammography Certification Number).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_5">REF_5</see> interface (Clinical Laboratory Improvement Amendment (CLIA) Number).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_6">REF_6</see> interface (Referring Clinical Laboratory Improvement Amendment (CLIA) Facility Identification).</summary>
        Public Shared Function CreateREF_6() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_6
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_7">REF_7</see> interface (Immunization Batch Number).</summary>
        Public Shared Function CreateREF_7() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_7
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_8">REF_8</see> interface (Referral Number).</summary>
        Public Shared Function CreateREF_8() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.REF_8
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT">AMT</see> interface (Sales Tax Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT_1">AMT_1</see> interface (Postage Claimed Amount).</summary>
        Public Shared Function CreateAMT_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT_1
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.K3">K3</see> interface (File Information).</summary>
        Public Shared Function CreateK3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.K3
            Return New Global.Madjic.Edi.Dom.Segments.K3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE">NTE</see> interface (Line Note).</summary>
        Public Shared Function CreateNTE() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE
            Return New Global.Madjic.Edi.Dom.Segments.NTE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE_1">NTE_1</see> interface (Third Party Organization Notes).</summary>
        Public Shared Function CreateNTE_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE_1
            Return New Global.Madjic.Edi.Dom.Segments.NTE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PS1">PS1</see> interface (Purchased Service Information).</summary>
        Public Shared Function CreatePS1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PS1
            Return New Global.Madjic.Edi.Dom.Segments.PS1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP">HCP</see> interface (Line Pricing/Repricing Information).</summary>
        Public Shared Function CreateHCP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP
            Return New Global.Madjic.Edi.Dom.Segments.HCP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420A loop (Rendering Provider Name).</summary>
    Public NotInheritable Class Loop2420AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.NM1">NM1</see> interface (Rendering Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV">PRV</see> interface (Rendering Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.REF">REF</see> interface (Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420B loop (Purchased Service Provider Name).</summary>
    Public NotInheritable Class Loop2420BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420B.NM1">NM1</see> interface (Purchased Service Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420B.REF">REF</see> interface (Purchased Service Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420C loop (Service Facility Location Name).</summary>
    Public NotInheritable Class Loop2420CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.NM1">NM1</see> interface (Service Facility Location Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N3">N3</see> interface (Service Facility Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4">N4</see> interface (Service Facility Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.REF">REF</see> interface (Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420D loop (Supervising Provider Name).</summary>
    Public NotInheritable Class Loop2420DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420D.NM1">NM1</see> interface (Supervising Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420D.REF">REF</see> interface (Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420E loop (Ordering Provider Name).</summary>
    Public NotInheritable Class Loop2420EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.NM1">NM1</see> interface (Ordering Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N3">N3</see> interface (Ordering Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4">N4</see> interface (Ordering Provider City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.REF">REF</see> interface (Ordering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER">PER</see> interface (Ordering Provider Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420F loop (Referring Provider Name).</summary>
    Public NotInheritable Class Loop2420FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420F.NM1">NM1</see> interface (Referring Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420F.REF">REF</see> interface (Referring Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420F.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420G loop (Ambulance Pick-up Location).</summary>
    Public NotInheritable Class Loop2420GFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.NM1">NM1</see> interface (Ambulance Pick-up Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N3">N3</see> interface (Ambulance Pick-up Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4">N4</see> interface (Ambulance Pick-up Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420H loop (Ambulance Drop-off Location).</summary>
    Public NotInheritable Class Loop2420HFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.NM1">NM1</see> interface (Ambulance Drop-off Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N3">N3</see> interface (Ambulance Drop-off Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4">N4</see> interface (Ambulance Drop-off Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2430 loop (Line Adjudication Information).</summary>
    Public NotInheritable Class Loop2430Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD">SVD</see> interface (Line Adjudication Information).</summary>
        Public Shared Function CreateSVD() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD
            Return New Global.Madjic.Edi.Dom.Segments.SVD_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS">CAS</see> interface (Line Adjustment).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.DTP">DTP</see> interface (Line Check or Remittance Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.AMT">AMT</see> interface (Remaining Patient Liability).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2440 loop (Form Identification Code).</summary>
    Public NotInheritable Class Loop2440Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.LQ">LQ</see> interface (Form Identification Code).</summary>
        Public Shared Function CreateLQ() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.LQ
            Return New Global.Madjic.Edi.Dom.Segments.LQ_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM">FRM</see> interface (Supporting Documentation).</summary>
        Public Shared Function CreateFRM() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM
            Return New Global.Madjic.Edi.Dom.Segments.FRM_Obj
        End Function
    End Class
End Namespace
