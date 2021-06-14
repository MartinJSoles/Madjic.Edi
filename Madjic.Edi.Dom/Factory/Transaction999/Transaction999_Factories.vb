Namespace Factory.Transaction999
    '''<summary>Provides methods for instantiating the Transaction999 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet">Transaction999.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet">Transaction999.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction999() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction999.Standard_Obj("005010X231")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet">Transaction999.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet">Transaction999.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction999(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction999.Standard_Obj(controlNumber, "005010X231")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST">ST</see> interface ().</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1">AK1</see> interface ().</summary>
        Public Shared Function CreateAK1() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK1
            Return New Global.Madjic.Edi.Dom.Segments.AK1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9">AK9</see> interface ().</summary>
        Public Shared Function CreateAK9() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.AK9
            Return New Global.Madjic.Edi.Dom.Segments.AK9_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE">SE</see> interface ().</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000">Loop1000</see> interface ().</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000">Loop1000</see> interface.</returns>
        Public Shared Function CreateLoop1000() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop1000
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction999.Loop1000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000">Loop2000</see> interface ().</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000">Loop2000</see> interface.</returns>
        Public Shared Function CreateLoop2000() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop2000
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction999.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000">Loop3000</see> interface ().</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000">Loop3000</see> interface.</returns>
        Public Shared Function CreateLoop3000() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Loops.Loop3000
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction999.Loop3000_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop1000 loop ().</summary>
    Public NotInheritable Class Loop1000Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2">AK2</see> interface ().</summary>
        Public Shared Function CreateAK2() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2
            Return New Global.Madjic.Edi.Dom.Segments.AK2_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5">IK5</see> interface ().</summary>
        Public Shared Function CreateIK5() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5
            Return New Global.Madjic.Edi.Dom.Segments.IK5_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000 loop ().</summary>
    Public NotInheritable Class Loop2000Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3">IK3</see> interface ().</summary>
        Public Shared Function CreateIK3() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3
            Return New Global.Madjic.Edi.Dom.Segments.IK3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX">CTX</see> interface ().</summary>
        Public Shared Function CreateCTX() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX
            Return New Global.Madjic.Edi.Dom.Segments.CTX_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop3000 loop ().</summary>
    Public NotInheritable Class Loop3000Factory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4">IK4</see> interface ().</summary>
        Public Shared Function CreateIK4() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4
            Return New Global.Madjic.Edi.Dom.Segments.IK4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX">CTX</see> interface ().</summary>
        Public Shared Function CreateCTX() As Global.Madjic.Edi.Dom.Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX
            Return New Global.Madjic.Edi.Dom.Segments.CTX_Obj
        End Function
    End Class
End Namespace
