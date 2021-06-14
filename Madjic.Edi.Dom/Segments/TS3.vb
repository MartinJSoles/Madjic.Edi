Namespace Segments
    '''<summary>Transaction Statistics</summary>
    '''<remarks>To supply provider-level control information</remarks>
    Partial Friend Class TS3_Obj
        Inherits Segment
        Implements TS3,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5})}

        Public Sub New()
            MyBase.New("TS3")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1331),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TS301 As String Implements TS3.TS301, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element127
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property TS302 As String Implements TS3.TS302, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1331).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1331
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1331).Value = value
                End If
            End Set
        End Property

        Friend Property TS303 As Date? Implements TS3.TS303, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS303
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element373
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property TS304 As Decimal? Implements TS3.TS304, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS304
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element380
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS305 As Decimal? Implements TS3.TS305, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS305
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element782
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS306 As Decimal? Implements TS3.TS306
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element782
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS307 As Decimal? Implements TS3.TS307
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element782
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS308 As Decimal? Implements TS3.TS308
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element782
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS309 As Decimal? Implements TS3.TS309
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element782
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS310 As Decimal? Implements TS3.TS310
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element782
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS311 As Decimal? Implements TS3.TS311
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element782
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS312 As Decimal? Implements TS3.TS312
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element782
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS313 As Decimal? Implements TS3.TS313, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS313
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element782
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS314 As Decimal? Implements TS3.TS314
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element782
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS315 As Decimal? Implements TS3.TS315, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS315
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element782
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS316 As Decimal? Implements TS3.TS316
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element782
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS317 As Decimal? Implements TS3.TS317, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS317
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element782
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS318 As Decimal? Implements TS3.TS318, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS318
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element782
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS319 As Decimal? Implements TS3.TS319
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element782
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS320 As Decimal? Implements TS3.TS320, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS320
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element782
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS321 As Decimal? Implements TS3.TS321, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS321
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element782
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS322 As Decimal? Implements TS3.TS322, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS322
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element782
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS323 As Decimal? Implements TS3.TS323, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS323
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element380
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS324 As Decimal? Implements TS3.TS324, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS3.TS324
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.Element782
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TS3
            Dim rval As New TS3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TS301 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TS302 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TS303 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TS304 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .TS305 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .TS306 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .TS307 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .TS308 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .TS309 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .TS310 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .TS311 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .TS312 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .TS313 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .TS314 = source.ToFloatValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .TS315 = source.ToFloatValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .TS316 = source.ToFloatValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .TS317 = source.ToFloatValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .TS318 = source.ToFloatValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .TS319 = source.ToFloatValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .TS320 = source.ToFloatValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .TS321 = source.ToFloatValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .TS322 = source.ToFloatValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .TS323 = source.ToFloatValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .TS324 = source.ToFloatValue(23)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Statistics</summary>
    '''<remarks>To supply provider-level control information</remarks>
    Public Interface TS3
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>TS301 is the provider number.</remarks>
        Property TS301 As String

        '''<summary>Facility Code Value</summary>
        '''<remarks></remarks>
        Property TS302 As String

        '''<summary>Date</summary>
        '''<remarks>TS303 is the last day of the provider's fiscal year.</remarks>
        Property TS303 As Date?

        '''<summary>Quantity</summary>
        '''<remarks>TS304 is the total number of claims.</remarks>
        Property TS304 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS305 is the total of reported charges.</remarks>
        Property TS305 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS306 is the total of covered charges.</remarks>
        Property TS306 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS307 is the total of noncovered charges.</remarks>
        Property TS307 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS308 is the total of denied charges.</remarks>
        Property TS308 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS309 is the total provider payment.</remarks>
        Property TS309 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS310 is the total amount of interest paid.</remarks>
        Property TS310 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS311 is the total contractual adjustment.</remarks>
        Property TS311 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS312 is the total Gramm-Rudman Reduction.</remarks>
        Property TS312 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS313 is the total Medicare Secondary Payer (MSP) primary payer amount.</remarks>
        Property TS313 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS314 is the total blood deductible amount in dollars.</remarks>
        Property TS314 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS315 is the summary of non-lab charges.</remarks>
        Property TS315 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS316 is the total coinsurance amount.</remarks>
        Property TS316 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS317 is the Health Care Financing Administration Common Procedural Coding System (HCPCS) reported charges.</remarks>
        Property TS317 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS318 is the total Health Care Financing Administration Common Procedural Coding System (HCPCS) payable amount.</remarks>
        Property TS318 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS319 is the total deductible amount.</remarks>
        Property TS319 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS320 is the total professional component amount.</remarks>
        Property TS320 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS321 is the total Medicare Secondary Payer (MSP) patient liability met.</remarks>
        Property TS321 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS322 is the total patient reimbursement.</remarks>
        Property TS322 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS323 is the total periodic interim payment (PIP) number of claims.</remarks>
        Property TS323 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS324 is total periodic interim payment (PIP) adjustment.</remarks>
        Property TS324 As Decimal?

    End Interface
End NameSpace