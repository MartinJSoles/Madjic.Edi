Namespace Segments
    '''<summary>Service, Promotion, Allowance, or Charge Information</summary>
    '''<remarks>To request or identify a service, promotion, allowance, or charge; to specify the amount or percentage for the service, promotion, allowance, or charge</remarks>
    Partial Friend Class SAC_Obj
        Inherits Segment
        Implements SAC,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({2, 3}),
                                                 New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRulePaired({6, 7}),
                                                 New SyntaxRulePaired({9, 10}),
                                                 New SyntaxRuleConditional(11, {10}),
                                                 New SyntaxRuleConditional(14, {13}),
                                                 New SyntaxRuleConditional(16, {15}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SAC")
            Elements.AddRange({CType(Nothing, DataElements.Element248),
                                      CType(Nothing, DataElements.Element1300),
                                      CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element1301),
                                      CType(Nothing, DataElements.Element610),
                                      CType(Nothing, DataElements.Element378),
                                      CType(Nothing, DataElements.Element332),
                                      CType(Nothing, DataElements.Element118),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element331),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element770),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element819)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SAC01 As String Implements SAC.SAC01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC.SAC01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element248).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element248
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element248).Value = value
                End If
            End Set
        End Property

        Friend Property SAC02 As String Implements SAC.SAC02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC.SAC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1300).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1300
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1300).Value = value
                End If
            End Set
        End Property

        Friend Property SAC03 As String Implements SAC.SAC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element559
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property SAC04 As String Implements SAC.SAC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1301).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1301
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1301).Value = value
                End If
            End Set
        End Property

        Friend Property SAC05 As Decimal? Implements SAC.SAC05, Transactions.Transaction820.Transaction820_A1.Segments.Loop2312A.SAC.SAC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element610).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element610
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element610).Value = value
                End If
            End Set
        End Property

        Friend Property SAC06 As String Implements SAC.SAC06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element378).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element378
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element378).Value = value
                End If
            End Set
        End Property

        Friend Property SAC07 As Decimal? Implements SAC.SAC07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element332).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element332
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element332).Value = value
                End If
            End Set
        End Property

        Friend Property SAC08 As Decimal? Implements SAC.SAC08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element118).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element118
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element118).Value = value
                End If
            End Set
        End Property

        Friend Property SAC09 As String Implements SAC.SAC09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element355
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property SAC10 As Decimal? Implements SAC.SAC10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element380
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SAC11 As Decimal? Implements SAC.SAC11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element380
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SAC12 As String Implements SAC.SAC12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element331).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element331
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element331).Value = value
                End If
            End Set
        End Property

        Friend Property SAC13 As String Implements SAC.SAC13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element127
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property SAC14 As String Implements SAC.SAC14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element770).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element770
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element770).Value = value
                End If
            End Set
        End Property

        Friend Property SAC15 As String Implements SAC.SAC15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element352
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property SAC16 As String Implements SAC.SAC16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element819).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element819
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element819).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SAC
            Dim rval As New SAC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SAC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SAC02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SAC03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SAC04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SAC05 = source.ToDecimalValue(4, 2)
                End If
                If source.Elements.Count > 5 Then
                    .SAC06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SAC07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SAC08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SAC09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SAC10 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .SAC11 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .SAC12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .SAC13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .SAC14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .SAC15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .SAC16 = source.ToStringValue(15)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Service, Promotion, Allowance, or Charge Information</summary>
    '''<remarks>To request or identify a service, promotion, allowance, or charge; to specify the amount or percentage for the service, promotion, allowance, or charge</remarks>
    Public Interface SAC
        Inherits ISegment

        '''<summary>Allowance or Charge Indicator</summary>
        '''<remarks>If SAC01 is "A" or "C", then at least one of SAC05, SAC07, or SAC08 is required.</remarks>
        Property SAC01 As String

        '''<summary>Service, Promotion, Allowance, or Charge Code</summary>
        '''<remarks></remarks>
        Property SAC02 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks></remarks>
        Property SAC03 As String

        '''<summary>Agency Service, Promotion, Allowance, or Charge Code</summary>
        '''<remarks>SAC04 may be used to uniquely identify the service, promotion, allowance, or charge. In addition, it may be used in conjunction with SAC03 to further define SAC02.</remarks>
        Property SAC04 As String

        '''<summary>Amount</summary>
        '''<remarks>SAC05 is the total amount for the service, promotion, allowance, or charge.</remarks>
        Property SAC05 As Decimal?

        '''<summary>Allowance/Charge Percent Qualifier</summary>
        '''<remarks></remarks>
        Property SAC06 As String

        '''<summary>Percent, Decimal Format</summary>
        '''<remarks></remarks>
        Property SAC07 As Decimal?

        '''<summary>Rate</summary>
        '''<remarks>SAC08 is the allowance or charge rate per unit.</remarks>
        Property SAC08 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property SAC09 As String

        '''<summary>Quantity</summary>
        '''<remarks>SAC10 and SAC11 is the quantity basis when the allowance or charge quantity is different from the purchase order or invoice quantity.</remarks>
        Property SAC10 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property SAC11 As Decimal?

        '''<summary>Allowance or Charge Method of Handling Code</summary>
        '''<remarks></remarks>
        Property SAC12 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>SAC13 is used in conjunction with SAC02 or SAC04 to provide a specific reference number as identified by the code used.</remarks>
        Property SAC13 As String

        '''<summary>Option Number</summary>
        '''<remarks>SAC14 is used in conjunction with SAC13 to identify an option when there is more than one option of the promotion.</remarks>
        Property SAC14 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property SAC15 As String

        '''<summary>Language Code</summary>
        '''<remarks>SAC16 is used to identify the language being used in SAC15.</remarks>
        Property SAC16 As String

    End Interface
End NameSpace