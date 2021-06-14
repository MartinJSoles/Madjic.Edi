Namespace Segments
    '''<summary>Beginning Segment for Payment Order/Remittance Advice</summary>
    '''<remarks>To indicate the beginning of a Payment Order/Remittance Advice Transaction Set and total payment amount, or to enable related transfer of funds and/or information from payer to payee to occur</remarks>
    Partial Friend Class BPR_Obj
        Inherits Segment
        Implements BPR,
                   Transactions.Transaction820.Transaction820_A1.Segments.BPR,
                   Transactions.Transaction835.Transaction835_W1.Segments.BPR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({6, 7}),
                                                 New SyntaxRuleConditional(8, {9}),
                                                 New SyntaxRulePaired({12, 13}),
                                                 New SyntaxRuleConditional(14, {15}),
                                                 New SyntaxRulePaired({18, 19}),
                                                 New SyntaxRuleConditional(20, {21}),
                                                 New SyntaxRuleAllRequired({1, 2, 3, 4})}

        Public Sub New()
            MyBase.New("BPR")
            Elements.AddRange({CType(Nothing, DataElements.Element305),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element478),
                                      CType(Nothing, DataElements.Element591),
                                      CType(Nothing, DataElements.Element812),
                                      CType(Nothing, DataElements.Element506),
                                      CType(Nothing, DataElements.Element507),
                                      CType(Nothing, DataElements.Element569),
                                      CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element509),
                                      CType(Nothing, DataElements.Element510),
                                      CType(Nothing, DataElements.Element506),
                                      CType(Nothing, DataElements.Element507),
                                      CType(Nothing, DataElements.Element569),
                                      CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element1048),
                                      CType(Nothing, DataElements.Element506),
                                      CType(Nothing, DataElements.Element507),
                                      CType(Nothing, DataElements.Element569),
                                      CType(Nothing, DataElements.Element508)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property BPR01 As String Implements BPR.BPR01, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR01, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element305).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element305
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element305).Value = value
                End If
            End Set
        End Property

        Friend Property BPR02 As Decimal? Implements BPR.BPR02, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR02, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element782
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property BPR03 As String Implements BPR.BPR03, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR03, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element478).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element478
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element478).Value = value
                End If
            End Set
        End Property

        Friend Property BPR04 As String Implements BPR.BPR04, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR04, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element591).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element591
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element591).Value = value
                End If
            End Set
        End Property

        Friend Property BPR05 As String Implements BPR.BPR05, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR05, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element812).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element812
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element812).Value = value
                End If
            End Set
        End Property

        Friend Property BPR06 As String Implements BPR.BPR06, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR06, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element506).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element506
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element506).Value = value
                End If
            End Set
        End Property

        Friend Property BPR07 As String Implements BPR.BPR07, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR07, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element507).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element507
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element507).Value = value
                End If
            End Set
        End Property

        Friend Property BPR08 As String Implements BPR.BPR08, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR08, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element569).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element569
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element569).Value = value
                End If
            End Set
        End Property

        Friend Property BPR09 As String Implements BPR.BPR09, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR09, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element508
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property BPR10 As String Implements BPR.BPR10, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR10, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element509).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element509
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element509).Value = value
                End If
            End Set
        End Property

        Friend Property BPR11 As String Implements BPR.BPR11, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR11, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element510).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element510
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element510).Value = value
                End If
            End Set
        End Property

        Friend Property BPR12 As String Implements BPR.BPR12, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR12, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element506).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element506
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element506).Value = value
                End If
            End Set
        End Property

        Friend Property BPR13 As String Implements BPR.BPR13, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR13, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element507).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element507
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element507).Value = value
                End If
            End Set
        End Property

        Friend Property BPR14 As String Implements BPR.BPR14, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR14, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element569).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element569
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element569).Value = value
                End If
            End Set
        End Property

        Friend Property BPR15 As String Implements BPR.BPR15, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR15, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element508
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property BPR16 As Date? Implements BPR.BPR16, Transactions.Transaction820.Transaction820_A1.Segments.BPR.BPR16, Transactions.Transaction835.Transaction835_W1.Segments.BPR.BPR16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element373
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property BPR17 As String Implements BPR.BPR17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1048).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1048
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1048).Value = value
                End If
            End Set
        End Property

        Friend Property BPR18 As String Implements BPR.BPR18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element506).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element506
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element506).Value = value
                End If
            End Set
        End Property

        Friend Property BPR19 As String Implements BPR.BPR19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element507).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element507
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element507).Value = value
                End If
            End Set
        End Property

        Friend Property BPR20 As String Implements BPR.BPR20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element569).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element569
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element569).Value = value
                End If
            End Set
        End Property

        Friend Property BPR21 As String Implements BPR.BPR21
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element508
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As BPR
            Dim rval As New BPR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .BPR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .BPR02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .BPR03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .BPR04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .BPR05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .BPR06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .BPR07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .BPR08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .BPR09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .BPR10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .BPR11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .BPR12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .BPR13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .BPR14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .BPR15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .BPR16 = source.ToDateValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .BPR17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .BPR18 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .BPR19 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .BPR20 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .BPR21 = source.ToStringValue(20)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Beginning Segment for Payment Order/Remittance Advice</summary>
    '''<remarks>To indicate the beginning of a Payment Order/Remittance Advice Transaction Set and total payment amount, or to enable related transfer of funds and/or information from payer to payee to occur</remarks>
    Public Interface BPR
        Inherits ISegment

        '''<summary>Transaction Handling Code</summary>
        '''<remarks></remarks>
        Property BPR01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>BPR02 specifies the payment amount.</remarks>
        Property BPR02 As Decimal?

        '''<summary>Credit/Debit Flag Code</summary>
        '''<remarks></remarks>
        Property BPR03 As String

        '''<summary>Payment Method Code</summary>
        '''<remarks></remarks>
        Property BPR04 As String

        '''<summary>Payment Format Code</summary>
        '''<remarks></remarks>
        Property BPR05 As String

        '''<summary>(DFI) ID Number Qualifier</summary>
        '''<remarks>When using this transaction set to initiate a payment, all or some of BPR06 through BPR16 may be required, depending on the conventions of the specific financial channel being used.</remarks>
        Property BPR06 As String

        '''<summary>(DFI) Identification Number</summary>
        '''<remarks></remarks>
        Property BPR07 As String

        '''<summary>Account Number Qualifier</summary>
        '''<remarks>BPR08 is a code identifying the type of bank account or other financial asset.</remarks>
        Property BPR08 As String

        '''<summary>Account Number</summary>
        '''<remarks>BPR09 is the account of the company originating the payment. This account may be debited or credited depending on the type of payment order.</remarks>
        Property BPR09 As String

        '''<summary>Originating Company Identifier</summary>
        '''<remarks>BPR10 shall be mutually established between the originating depository financial institution (ODFI) and the company originating the payment.</remarks>
        Property BPR10 As String

        '''<summary>Originating Company Supplemental Code</summary>
        '''<remarks></remarks>
        Property BPR11 As String

        '''<summary>(DFI) ID Number Qualifier</summary>
        '''<remarks>BPR12 and BPR13 relate to the receiving depository financial institution (RDFI).</remarks>
        Property BPR12 As String

        '''<summary>(DFI) Identification Number</summary>
        '''<remarks></remarks>
        Property BPR13 As String

        '''<summary>Account Number Qualifier</summary>
        '''<remarks>BPR14 is a code identifying the type of bank account or other financial asset.</remarks>
        Property BPR14 As String

        '''<summary>Account Number</summary>
        '''<remarks>BPR15 is the account number of the receiving company to be debited or credited with the payment order.</remarks>
        Property BPR15 As String

        '''<summary>Date</summary>
        '''<remarks>BPR16 is the date the originating company intends for the transaction to be settled (i.e., Payment Effective Date).</remarks>
        Property BPR16 As Date?

        '''<summary>Business Function Code</summary>
        '''<remarks>BPR17 is a code identifying the business reason for this payment.</remarks>
        Property BPR17 As String

        '''<summary>(DFI) ID Number Qualifier</summary>
        '''<remarks>BPR18, BPR19, BPR20 and BPR21, if used, identify a third bank identification number and account to be used for return items only.</remarks>
        Property BPR18 As String

        '''<summary>(DFI) Identification Number</summary>
        '''<remarks></remarks>
        Property BPR19 As String

        '''<summary>Account Number Qualifier</summary>
        '''<remarks>BPR20 is a code identifying the type of bank account or other financial asset.</remarks>
        Property BPR20 As String

        '''<summary>Account Number</summary>
        '''<remarks></remarks>
        Property BPR21 As String

    End Interface
End NameSpace