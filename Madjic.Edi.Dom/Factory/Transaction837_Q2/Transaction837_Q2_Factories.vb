﻿Namespace Factory.Transaction837_Q2
    '''<summary>Provides methods for instantiating the Transaction837_Q2 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet">Transaction837_Q2.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet">Transaction837_Q2.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction837_Q2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Standard_Obj("005010X224A2")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet">Transaction837_Q2.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet">Transaction837_Q2.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction837_Q2(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Standard_Obj(controlNumber, "005010X224A2")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.BHT">BHT</see> interface (Beginning of Hierarchical Transaction).</summary>
        Public Shared Function CreateBHT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.BHT
            Return New Global.Madjic.Edi.Dom.Segments.BHT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000A">Loop1000A</see> interface (Submitter Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000A">Loop1000A</see> interface.</returns>
        Public Shared Function CreateLoop1000A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000B">Loop1000B</see> interface (Receiver Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000B">Loop1000B</see> interface.</returns>
        Public Shared Function CreateLoop1000B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop1000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000A">Loop2000A</see> interface (Billing Provider Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AA">Loop2010AA</see> interface (Billing Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AA">Loop2010AA</see> interface.</returns>
        Public Shared Function CreateLoop2010AA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AB">Loop2010AB</see> interface (Pay-to Address Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AB">Loop2010AB</see> interface.</returns>
        Public Shared Function CreateLoop2010AB() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AB
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AC">Loop2010AC</see> interface (Pay-To Plan Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AC">Loop2010AC</see> interface.</returns>
        Public Shared Function CreateLoop2010AC() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010AC
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000B">Loop2000B</see> interface (Subscriber Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BA">Loop2010BA</see> interface (Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BA">Loop2010BA</see> interface.</returns>
        Public Shared Function CreateLoop2010BA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BB">Loop2010BB</see> interface (Payer Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BB">Loop2010BB</see> interface.</returns>
        Public Shared Function CreateLoop2010BB() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010BB
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000C">Loop2000C</see> interface (Patient Hierarchical Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000C">Loop2000C</see> interface.</returns>
        Public Shared Function CreateLoop2000C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010CA">Loop2010CA</see> interface (Patient Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010CA">Loop2010CA</see> interface.</returns>
        Public Shared Function CreateLoop2010CA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2010CA
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2010_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2300">Loop2300</see> interface (Claim Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2300">Loop2300</see> interface.</returns>
        Public Shared Function CreateLoop2300() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2300
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2300_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310A">Loop2310A</see> interface (Referring Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310A">Loop2310A</see> interface.</returns>
        Public Shared Function CreateLoop2310A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310B">Loop2310B</see> interface (Rendering Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310B">Loop2310B</see> interface.</returns>
        Public Shared Function CreateLoop2310B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310C">Loop2310C</see> interface (Service Facility Location Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310C">Loop2310C</see> interface.</returns>
        Public Shared Function CreateLoop2310C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310D">Loop2310D</see> interface (Assistant Surgeon Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310D">Loop2310D</see> interface.</returns>
        Public Shared Function CreateLoop2310D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310E">Loop2310E</see> interface (Supervising Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310E">Loop2310E</see> interface.</returns>
        Public Shared Function CreateLoop2310E() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2310E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2310_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2320">Loop2320</see> interface (Other Subscriber Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2320">Loop2320</see> interface.</returns>
        Public Shared Function CreateLoop2320() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2320
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2320_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330A">Loop2330A</see> interface (Other Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330A">Loop2330A</see> interface.</returns>
        Public Shared Function CreateLoop2330A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330B">Loop2330B</see> interface (Other Payer Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330B">Loop2330B</see> interface.</returns>
        Public Shared Function CreateLoop2330B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330C">Loop2330C</see> interface (Other Payer Referring Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330C">Loop2330C</see> interface.</returns>
        Public Shared Function CreateLoop2330C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330D">Loop2330D</see> interface (Other Payer Rendering Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330D">Loop2330D</see> interface.</returns>
        Public Shared Function CreateLoop2330D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330E">Loop2330E</see> interface (Other Payer Supervising Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330E">Loop2330E</see> interface.</returns>
        Public Shared Function CreateLoop2330E() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330E
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330F">Loop2330F</see> interface (Other Payer Billing Provider).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330F">Loop2330F</see> interface.</returns>
        Public Shared Function CreateLoop2330F() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330F
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330G">Loop2330G</see> interface (Other Payer Service Facility Location).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330G">Loop2330G</see> interface.</returns>
        Public Shared Function CreateLoop2330G() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330G
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330H">Loop2330H</see> interface (Other Payer Assistant Surgeon).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330H">Loop2330H</see> interface.</returns>
        Public Shared Function CreateLoop2330H() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2330H
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2330_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2400">Loop2400</see> interface (Service Line Number).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2400">Loop2400</see> interface.</returns>
        Public Shared Function CreateLoop2400() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2400
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2400_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420A">Loop2420A</see> interface (Rendering Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420A">Loop2420A</see> interface.</returns>
        Public Shared Function CreateLoop2420A() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420B">Loop2420B</see> interface (Assistant Surgeon Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420B">Loop2420B</see> interface.</returns>
        Public Shared Function CreateLoop2420B() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420C">Loop2420C</see> interface (Supervising Provider Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420C">Loop2420C</see> interface.</returns>
        Public Shared Function CreateLoop2420C() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420D">Loop2420D</see> interface (Service Facility Location Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420D">Loop2420D</see> interface.</returns>
        Public Shared Function CreateLoop2420D() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2420D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2420_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2430">Loop2430</see> interface (Line Adjudication Information).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2430">Loop2430</see> interface.</returns>
        Public Shared Function CreateLoop2430() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Loops.Loop2430
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction837.Loop2430_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000A loop (Submitter Name).</summary>
    Public NotInheritable Class Loop1000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.NM1">NM1</see> interface (Submitter Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER">PER</see> interface (Submitter EDI Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000B loop (Receiver Name).</summary>
    Public NotInheritable Class Loop1000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000B.NM1">NM1</see> interface (Receiver Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Billing Provider Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL">HL</see> interface (Billing Provider Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV">PRV</see> interface (Billing Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.CUR">CUR</see> interface (Foreign Currency Information).</summary>
        Public Shared Function CreateCUR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.CUR
            Return New Global.Madjic.Edi.Dom.Segments.CUR_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AA loop (Billing Provider Name).</summary>
    Public NotInheritable Class Loop2010AAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.NM1">NM1</see> interface (Billing Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N3">N3</see> interface (Billing Provider Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4">N4</see> interface (Billing Provider City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.REF">REF</see> interface (Billing Provider Tax Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.REF_1">REF_1</see> interface (Billing Provider UPIN/License Information).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER">PER</see> interface (Billing Provider Contact Information).</summary>
        Public Shared Function CreatePER() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER
            Return New Global.Madjic.Edi.Dom.Segments.PER_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AB loop (Pay-to Address Name).</summary>
    Public NotInheritable Class Loop2010ABFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.NM1">NM1</see> interface (Pay-to Address Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N3">N3</see> interface (Pay-to Address - ADDRESS).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4">N4</see> interface (Pay-To Address City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010AC loop (Pay-To Plan Name).</summary>
    Public NotInheritable Class Loop2010ACFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.NM1">NM1</see> interface (Pay-To Plan Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N3">N3</see> interface (Pay-to Plan Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4">N4</see> interface (Pay-To Plan City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.REF">REF</see> interface (Pay-to Plan Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.REF_1">REF_1</see> interface (Pay-To Plan Tax Identification Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Subscriber Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL">HL</see> interface (Subscriber Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR">SBR</see> interface (Subscriber Information).</summary>
        Public Shared Function CreateSBR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR
            Return New Global.Madjic.Edi.Dom.Segments.SBR_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010BA loop (Subscriber Name).</summary>
    Public NotInheritable Class Loop2010BAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.NM1">NM1</see> interface (Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N3">N3</see> interface (Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4">N4</see> interface (Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG">DMG</see> interface (Subscriber Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.REF">REF</see> interface (Subscriber Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.REF_1">REF_1</see> interface (Property and Casualty Claim Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010BB loop (Payer Name).</summary>
    Public NotInheritable Class Loop2010BBFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.NM1">NM1</see> interface (Payer Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N3">N3</see> interface (Payer Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4">N4</see> interface (Payer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.REF">REF</see> interface (Payer Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.REF_1">REF_1</see> interface (Billing Provider Secondary Identification).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000C loop (Patient Hierarchical Level).</summary>
    Public NotInheritable Class Loop2000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL">HL</see> interface (Patient Hierarchical Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.PAT">PAT</see> interface (Patient Information).</summary>
        Public Shared Function CreatePAT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.PAT
            Return New Global.Madjic.Edi.Dom.Segments.PAT_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2010CA loop (Patient Name).</summary>
    Public NotInheritable Class Loop2010CAFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.NM1">NM1</see> interface (Patient Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N3">N3</see> interface (Patient Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4">N4</see> interface (Patient City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG">DMG</see> interface (Patient Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.REF">REF</see> interface (Property and Casualty Claim Number).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.REF_1">REF_1</see> interface (Property and Casualty Patient Identifier).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2300 loop (Claim Information).</summary>
    Public NotInheritable Class Loop2300Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM">CLM</see> interface (Claim Information).</summary>
        Public Shared Function CreateCLM() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM
            Return New Global.Madjic.Edi.Dom.Segments.CLM_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP">DTP</see> interface (Date - Accident).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_1">DTP_1</see> interface (Date - Appliance Placement).</summary>
        Public Shared Function CreateDTP_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_1
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_2">DTP_2</see> interface (Date - Service Date).</summary>
        Public Shared Function CreateDTP_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_2
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_3">DTP_3</see> interface (Date - Repricer Received Date).</summary>
        Public Shared Function CreateDTP_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DTP_3
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1">DN1</see> interface (Orthodontic Total Months of Treatment).</summary>
        Public Shared Function CreateDN1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1
            Return New Global.Madjic.Edi.Dom.Segments.DN1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2">DN2</see> interface (Tooth Status).</summary>
        Public Shared Function CreateDN2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2
            Return New Global.Madjic.Edi.Dom.Segments.DN2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK">PWK</see> interface (Claim Supplemental Information).</summary>
        Public Shared Function CreatePWK() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK
            Return New Global.Madjic.Edi.Dom.Segments.PWK_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1">CN1</see> interface (Contract Information).</summary>
        Public Shared Function CreateCN1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1
            Return New Global.Madjic.Edi.Dom.Segments.CN1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.AMT">AMT</see> interface (Patient Amount Paid).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF">REF</see> interface (Predetermination Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_1">REF_1</see> interface (Service Authorization Exception Code).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_2">REF_2</see> interface (Payer Claim Control Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_3">REF_3</see> interface (Referral Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_4">REF_4</see> interface (Prior Authorization).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_5">REF_5</see> interface (Repriced Claim Number).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_6">REF_6</see> interface (Adjusted Repriced Claim Number).</summary>
        Public Shared Function CreateREF_6() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_6
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_7">REF_7</see> interface (Claim Identifier For Transmission Intermediaries).</summary>
        Public Shared Function CreateREF_7() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.REF_7
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.K3">K3</see> interface (File Information).</summary>
        Public Shared Function CreateK3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.K3
            Return New Global.Madjic.Edi.Dom.Segments.K3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.NTE">NTE</see> interface (Claim Note).</summary>
        Public Shared Function CreateNTE() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.NTE
            Return New Global.Madjic.Edi.Dom.Segments.NTE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI">HI</see> interface (Health Care Diagnosis Code).</summary>
        Public Shared Function CreateHI() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP">HCP</see> interface (Claim Pricing/Repricing Information).</summary>
        Public Shared Function CreateHCP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP
            Return New Global.Madjic.Edi.Dom.Segments.HCP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.C023" /> interface (Health Care Service Location Information).</summary>
        Public Shared Function CreateCLM05() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.C023
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C023_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.C024" /> interface (Related Causes Information).</summary>
        Public Shared Function CreateCLM11() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.C024
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C024_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI01() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI02() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI03() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022" /> interface (Health Care Code Information).</summary>
        Public Shared Function CreateHI04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C022_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310A loop (Referring Provider Name).</summary>
    Public NotInheritable Class Loop2310AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.NM1">NM1</see> interface (Referring Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV">PRV</see> interface (Referring Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.REF">REF</see> interface (Referring Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310B loop (Rendering Provider Name).</summary>
    Public NotInheritable Class Loop2310BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.NM1">NM1</see> interface (Rendering Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV">PRV</see> interface (Rendering Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.REF">REF</see> interface (Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310C loop (Service Facility Location Name).</summary>
    Public NotInheritable Class Loop2310CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.NM1">NM1</see> interface (Service Facility Location Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N3">N3</see> interface (Service Facility Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4">N4</see> interface (Service Facility Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.REF">REF</see> interface (Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310D loop (Assistant Surgeon Name).</summary>
    Public NotInheritable Class Loop2310DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.NM1">NM1</see> interface (Assistant Surgeon Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV">PRV</see> interface (Assistant Surgeon Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.REF">REF</see> interface (Assistant Surgeon Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2310E loop (Supervising Provider Name).</summary>
    Public NotInheritable Class Loop2310EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310E.NM1">NM1</see> interface (Supervising Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310E.REF">REF</see> interface (Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2320 loop (Other Subscriber Information).</summary>
    Public NotInheritable Class Loop2320Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR">SBR</see> interface (Other Subscriber Information).</summary>
        Public Shared Function CreateSBR() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR
            Return New Global.Madjic.Edi.Dom.Segments.SBR_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS">CAS</see> interface (Claim Level Adjustments).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT">AMT</see> interface (Coordination of Benefits (COB) Payer Paid Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_1">AMT_1</see> interface (Remaining Patient Liability).</summary>
        Public Shared Function CreateAMT_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_1
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_2">AMT_2</see> interface (Coordination of Benefits (COB) Total Non-Covered Amount).</summary>
        Public Shared Function CreateAMT_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_2
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA">MOA</see> interface (Outpatient Adjudication Information).</summary>
        Public Shared Function CreateMOA() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA
            Return New Global.Madjic.Edi.Dom.Segments.MOA_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330A loop (Other Subscriber Name).</summary>
    Public NotInheritable Class Loop2330AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.NM1">NM1</see> interface (Other Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N3">N3</see> interface (Other Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4">N4</see> interface (Other Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.REF">REF</see> interface (Other Subscriber Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330B loop (Other Payer Name).</summary>
    Public NotInheritable Class Loop2330BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.NM1">NM1</see> interface (Other Payer Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N3">N3</see> interface (Other Payer Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4">N4</see> interface (Other Payer City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.DTP">DTP</see> interface (Claim Check or Remittance Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF">REF</see> interface (Other Payer Secondary Identifier).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_1">REF_1</see> interface (Other Payer Prior Authorization Number).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_2">REF_2</see> interface (Other Payer Referral Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_3">REF_3</see> interface (Other Payer Claim Adjustment Indicator).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_4">REF_4</see> interface (Other Payer Predetermination Identification).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_5">REF_5</see> interface (Other Payer Claim Control Number).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330C loop (Other Payer Referring Provider).</summary>
    Public NotInheritable Class Loop2330CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330C.NM1">NM1</see> interface (Other Payer Referring Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330C.REF">REF</see> interface (Other Payer Referring Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330D loop (Other Payer Rendering Provider).</summary>
    Public NotInheritable Class Loop2330DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330D.NM1">NM1</see> interface (Other Payer Rendering Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330D.REF">REF</see> interface (Other Payer Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330E loop (Other Payer Supervising Provider).</summary>
    Public NotInheritable Class Loop2330EFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330E.NM1">NM1</see> interface (Other Payer Supervising Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330E.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330E.REF">REF</see> interface (Other Payer Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330E.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330F loop (Other Payer Billing Provider).</summary>
    Public NotInheritable Class Loop2330FFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330F.NM1">NM1</see> interface (Other Payer Billing Provider).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330F.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330F.REF">REF</see> interface (Other Payer Billing Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330F.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330G loop (Other Payer Service Facility Location).</summary>
    Public NotInheritable Class Loop2330GFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330G.NM1">NM1</see> interface (Other Payer Service Facility Location).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330G.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330G.REF">REF</see> interface (Other Payer Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330G.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2330H loop (Other Payer Assistant Surgeon).</summary>
    Public NotInheritable Class Loop2330HFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330H.NM1">NM1</see> interface (Other Payer Assistant Surgeon).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330H.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330H.REF">REF</see> interface (Other Payer Assistant Surgeon Secondary Identifier).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330H.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2400 loop (Service Line Number).</summary>
    Public NotInheritable Class Loop2400Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.LX">LX</see> interface (Service Line Number).</summary>
        Public Shared Function CreateLX() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.LX
            Return New Global.Madjic.Edi.Dom.Segments.LX_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3">SV3</see> interface (Dental Service).</summary>
        Public Shared Function CreateSV3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3
            Return New Global.Madjic.Edi.Dom.Segments.SV3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO">TOO</see> interface (Tooth Information).</summary>
        Public Shared Function CreateTOO() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO
            Return New Global.Madjic.Edi.Dom.Segments.TOO_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP">DTP</see> interface (Date - Service Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_1">DTP_1</see> interface (Date - Prior Placement).</summary>
        Public Shared Function CreateDTP_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_1
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_2">DTP_2</see> interface (Date - Appliance Placement).</summary>
        Public Shared Function CreateDTP_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_2
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_3">DTP_3</see> interface (Date - Replacement).</summary>
        Public Shared Function CreateDTP_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_3
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_4">DTP_4</see> interface (Date - Treatment Start).</summary>
        Public Shared Function CreateDTP_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_4
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_5">DTP_5</see> interface (Date - Treatment Completion).</summary>
        Public Shared Function CreateDTP_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.DTP_5
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1">CN1</see> interface (Contract Information).</summary>
        Public Shared Function CreateCN1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1
            Return New Global.Madjic.Edi.Dom.Segments.CN1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF">REF</see> interface (Service Predetermination Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_1">REF_1</see> interface (Prior Authorization).</summary>
        Public Shared Function CreateREF_1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_1
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_2">REF_2</see> interface (Line Item Control Number).</summary>
        Public Shared Function CreateREF_2() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_2
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_3">REF_3</see> interface (Repriced Claim Number).</summary>
        Public Shared Function CreateREF_3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_3
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_4">REF_4</see> interface (Adjusted Repriced Claim Number).</summary>
        Public Shared Function CreateREF_4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_4
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_5">REF_5</see> interface (Referral Number).</summary>
        Public Shared Function CreateREF_5() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.REF_5
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.AMT">AMT</see> interface (Sales Tax Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.K3">K3</see> interface (File Information).</summary>
        Public Shared Function CreateK3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.K3
            Return New Global.Madjic.Edi.Dom.Segments.K3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP">HCP</see> interface (Line Pricing/Repricing Information).</summary>
        Public Shared Function CreateHCP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP
            Return New Global.Madjic.Edi.Dom.Segments.HCP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.C003" /> interface (Composite Medical Procedure Identifier).</summary>
        Public Shared Function CreateSV301() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.C003
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C003_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.DataElements.Composite.C006" /> interface (Oral Cavity Designation).</summary>
        Public Shared Function CreateSV304() As Global.Madjic.Edi.Dom.DataElements.Composite.C006
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C006_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.DataElements.Composite.C004" /> interface (Composite Diagnosis Code Pointer).</summary>
        Public Shared Function CreateSV311() As Global.Madjic.Edi.Dom.DataElements.Composite.C004
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C004_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF.REF_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF.REF_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_1.REF_1_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF_1_REF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_1.REF_1_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_5.REF_5_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF_5_REF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.REF_5.REF_5_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420A loop (Rendering Provider Name).</summary>
    Public NotInheritable Class Loop2420AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.NM1">NM1</see> interface (Rendering Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV">PRV</see> interface (Rendering Provider Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.REF">REF</see> interface (Rendering Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420A.REF.REF_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420A.REF.REF_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420B loop (Assistant Surgeon Name).</summary>
    Public NotInheritable Class Loop2420BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.NM1">NM1</see> interface (Assistant Surgeon Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV">PRV</see> interface (Assistant Surgeon Specialty Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.REF">REF</see> interface (Assistant Surgeon Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420B.REF.REF_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420B.REF.REF_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420C loop (Supervising Provider Name).</summary>
    Public NotInheritable Class Loop2420CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420C.NM1">NM1</see> interface (Supervising Provider Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420C.REF">REF</see> interface (Supervising Provider Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420C.REF.REF_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420C.REF.REF_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2420D loop (Service Facility Location Name).</summary>
    Public NotInheritable Class Loop2420DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.NM1">NM1</see> interface (Service Facility Location Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N3">N3</see> interface (Service Facility Location Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4">N4</see> interface (Service Facility Location City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.REF">REF</see> interface (Service Facility Location Secondary Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420D.REF.REF_04.C040" /> interface (Reference Identifier).</summary>
        Public Shared Function CreateREF04() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2420D.REF.REF_04.C040
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C040_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2430 loop (Line Adjudication Information).</summary>
    Public NotInheritable Class Loop2430Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD">SVD</see> interface (Line Adjudication Information).</summary>
        Public Shared Function CreateSVD() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD
            Return New Global.Madjic.Edi.Dom.Segments.SVD_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS">CAS</see> interface (Line Adjustment).</summary>
        Public Shared Function CreateCAS() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS
            Return New Global.Madjic.Edi.Dom.Segments.CAS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.DTP">DTP</see> interface (Line Check or Remittance Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.AMT">AMT</see> interface (Remaining Patient Liability).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.C003" /> interface (Composite Medical Procedure Identifier).</summary>
        Public Shared Function CreateSVD03() As Global.Madjic.Edi.Dom.Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.C003
            Return New Global.Madjic.Edi.Dom.DataElements.Composite.C003_Obj
        End Function
    End Class
End Namespace
