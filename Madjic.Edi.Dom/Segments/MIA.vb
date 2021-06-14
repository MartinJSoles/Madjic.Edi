Namespace Segments
    '''<summary>Medicare Inpatient Adjudication</summary>
    '''<remarks>To provide claim-level data related to the adjudication of Medicare inpatient claims</remarks>
    Partial Friend Class MIA_Obj
        Inherits Segment
        Implements MIA,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("MIA")
            Elements.AddRange({CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element127),
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
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element782)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property MIA01 As Decimal? Implements MIA.MIA01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element380
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property MIA02 As Decimal? Implements MIA.MIA02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA02
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

        Friend Property MIA03 As Decimal? Implements MIA.MIA03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property MIA04 As Decimal? Implements MIA.MIA04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element782
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property MIA05 As String Implements MIA.MIA05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element127
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MIA06 As Decimal? Implements MIA.MIA06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA06
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

        Friend Property MIA07 As Decimal? Implements MIA.MIA07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA07
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

        Friend Property MIA08 As Decimal? Implements MIA.MIA08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA08
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

        Friend Property MIA09 As Decimal? Implements MIA.MIA09, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA09
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

        Friend Property MIA10 As Decimal? Implements MIA.MIA10, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA10, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA10
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

        Friend Property MIA11 As Decimal? Implements MIA.MIA11, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA11, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA11
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

        Friend Property MIA12 As Decimal? Implements MIA.MIA12, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA12, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA12
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

        Friend Property MIA13 As Decimal? Implements MIA.MIA13, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA13, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA13
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

        Friend Property MIA14 As Decimal? Implements MIA.MIA14, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA14, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA14
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

        Friend Property MIA15 As Decimal? Implements MIA.MIA15, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA15, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element380
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property MIA16 As Decimal? Implements MIA.MIA16, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA16, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA16
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

        Friend Property MIA17 As Decimal? Implements MIA.MIA17, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA17, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA17
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

        Friend Property MIA18 As Decimal? Implements MIA.MIA18, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA18, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA18
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

        Friend Property MIA19 As Decimal? Implements MIA.MIA19, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA19, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA19
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

        Friend Property MIA20 As String Implements MIA.MIA20, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA20, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element127
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MIA21 As String Implements MIA.MIA21, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA21, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA21
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element127
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MIA22 As String Implements MIA.MIA22, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA22, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA22
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element127
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MIA23 As String Implements MIA.MIA23, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA23, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA23
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element127
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MIA24 As Decimal? Implements MIA.MIA24, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MIA.MIA24, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MIA.MIA24
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As MIA
            Dim rval As New MIA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .MIA01 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .MIA02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .MIA03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .MIA04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .MIA05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .MIA06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .MIA07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .MIA08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .MIA09 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .MIA10 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .MIA11 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .MIA12 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .MIA13 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .MIA14 = source.ToFloatValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .MIA15 = source.ToFloatValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .MIA16 = source.ToFloatValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .MIA17 = source.ToFloatValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .MIA18 = source.ToFloatValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .MIA19 = source.ToFloatValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .MIA20 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .MIA21 = source.ToStringValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .MIA22 = source.ToStringValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .MIA23 = source.ToStringValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .MIA24 = source.ToFloatValue(23)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Medicare Inpatient Adjudication</summary>
    '''<remarks>To provide claim-level data related to the adjudication of Medicare inpatient claims</remarks>
    Public Interface MIA
        Inherits ISegment

        '''<summary>Quantity</summary>
        '''<remarks>MIA01 is the covered days.</remarks>
        Property MIA01 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA02 is the Prospective Payment System (PPS) Operating Outlier amount.</remarks>
        Property MIA02 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>MIA03 is the lifetime psychiatric days.</remarks>
        Property MIA03 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA04 is the Diagnosis Related Group (DRG) amount.</remarks>
        Property MIA04 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>MIA05 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MIA05 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA06 is the disproportionate share amount.</remarks>
        Property MIA06 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA07 is the Medicare Secondary Payer (MSP) pass-through amount.</remarks>
        Property MIA07 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA08 is the total Prospective Payment System (PPS) capital amount.</remarks>
        Property MIA08 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA09 is the Prospective Payment System (PPS) capital, federal specific portion, Diagnosis Related Group (DRG) amount.</remarks>
        Property MIA09 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA10 is the Prospective Payment System (PPS) capital, hospital specific portion, Diagnosis Related Group (DRG), amount.</remarks>
        Property MIA10 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA11 is the Prospective Payment System (PPS) capital, disproportionate share, hospital Diagnosis Related Group (DRG) amount.</remarks>
        Property MIA11 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA12 is the old capital amount.</remarks>
        Property MIA12 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA13 is the Prospective Payment System (PPS) capital indirect medical education claim amount.</remarks>
        Property MIA13 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA14 is hospital specific Diagnosis Related Group (DRG) Amount.</remarks>
        Property MIA14 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>MIA15 is the cost report days.</remarks>
        Property MIA15 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA16 is the federal specific Diagnosis Related Group (DRG) amount.</remarks>
        Property MIA16 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA17 is the Prospective Payment System (PPS) Capital Outlier amount.</remarks>
        Property MIA17 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA18 is the indirect teaching amount.</remarks>
        Property MIA18 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA19 is the professional component amount billed but not payable.</remarks>
        Property MIA19 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>MIA20 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MIA20 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MIA21 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MIA21 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MIA22 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MIA22 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MIA23 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MIA23 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>MIA24 is the capital exception amount.</remarks>
        Property MIA24 As Decimal?

    End Interface
End NameSpace