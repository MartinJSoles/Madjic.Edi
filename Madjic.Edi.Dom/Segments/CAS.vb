Namespace Segments
    '''<summary>Claims Adjustment</summary>
    '''<remarks>To supply adjustment reason codes and amounts as needed for an entire claim or for a particular service within the claim being paid</remarks>
    Partial Friend Class CAS_Obj
        Inherits Segment
        Implements CAS,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleListConditional(5, {6, 7}),
                                                 New SyntaxRuleConditional(6, {5}),
                                                 New SyntaxRuleConditional(7, {5}),
                                                 New SyntaxRuleListConditional(8, {9, 10}),
                                                 New SyntaxRuleConditional(9, {8}),
                                                 New SyntaxRuleConditional(10, {8}),
                                                 New SyntaxRuleListConditional(11, {12, 13}),
                                                 New SyntaxRuleConditional(12, {11}),
                                                 New SyntaxRuleConditional(13, {11}),
                                                 New SyntaxRuleListConditional(14, {15, 16}),
                                                 New SyntaxRuleConditional(15, {14}),
                                                 New SyntaxRuleConditional(16, {14}),
                                                 New SyntaxRuleListConditional(17, {18, 19}),
                                                 New SyntaxRuleConditional(18, {17}),
                                                 New SyntaxRuleConditional(19, {17}),
                                                 New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("CAS")
            Elements.AddRange({CType(Nothing, DataElements.Element1033),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1034),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CAS01 As String Implements CAS.CAS01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1033).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1033
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1033).Value = value
                End If
            End Set
        End Property

        Friend Property CAS02 As String Implements CAS.CAS02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1034
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS03 As Decimal? Implements CAS.CAS03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element782
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property CAS04 As Decimal? Implements CAS.CAS04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS04
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

        Friend Property CAS05 As String Implements CAS.CAS05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1034
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS06 As Decimal? Implements CAS.CAS06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS06
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

        Friend Property CAS07 As Decimal? Implements CAS.CAS07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element380
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CAS08 As String Implements CAS.CAS08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS08, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS08, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1034
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS09 As Decimal? Implements CAS.CAS09, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS09, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS09
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

        Friend Property CAS10 As Decimal? Implements CAS.CAS10, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS10, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS10, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS10, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS10, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS10, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS10, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS10, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS10
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

        Friend Property CAS11 As String Implements CAS.CAS11, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS11, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS11, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS11, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS11, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS11, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS11, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS11, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1034
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS12 As Decimal? Implements CAS.CAS12, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS12, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS12, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS12, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS12, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS12, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS12, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS12, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS12
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

        Friend Property CAS13 As Decimal? Implements CAS.CAS13, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS13, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS13, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS13, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS13, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS13, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS13, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS13, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element380
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CAS14 As String Implements CAS.CAS14, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS14, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS14, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS14, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS14, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS14, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS14, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS14, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1034
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS15 As Decimal? Implements CAS.CAS15, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS15, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS15, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS15, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS15, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS15, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS15, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS15, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS15
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

        Friend Property CAS16 As Decimal? Implements CAS.CAS16, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS16, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS16, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS16, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS16, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS16, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS16, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS16, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element380
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CAS17 As String Implements CAS.CAS17, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS17, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS17, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS17, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS17, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS17, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS17, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS17, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1034).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1034
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1034).Value = value
                End If
            End Set
        End Property

        Friend Property CAS18 As Decimal? Implements CAS.CAS18, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS18, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS18, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS18, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS18, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS18, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS18, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS18, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS18
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

        Friend Property CAS19 As Decimal? Implements CAS.CAS19, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CAS.CAS19, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.CAS.CAS19, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.CAS.CAS19, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.CAS.CAS19, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.CAS.CAS19, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.CAS.CAS19, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.CAS.CAS19, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.CAS.CAS19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element380
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CAS
            Dim rval As New CAS_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CAS01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CAS02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CAS03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CAS04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CAS05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CAS06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CAS07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CAS08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CAS09 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CAS10 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CAS11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CAS12 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CAS13 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CAS14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CAS15 = source.ToFloatValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CAS16 = source.ToFloatValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CAS17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CAS18 = source.ToFloatValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .CAS19 = source.ToFloatValue(18)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Claims Adjustment</summary>
    '''<remarks>To supply adjustment reason codes and amounts as needed for an entire claim or for a particular service within the claim being paid</remarks>
    Public Interface CAS
        Inherits ISegment

        '''<summary>Claim Adjustment Group Code</summary>
        '''<remarks></remarks>
        Property CAS01 As String

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS02 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS03 is the amount of adjustment.</remarks>
        Property CAS03 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS04 is the units of service being adjusted.</remarks>
        Property CAS04 As Decimal?

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS05 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS06 is the amount of the adjustment.</remarks>
        Property CAS06 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS07 is the units of service being adjusted.</remarks>
        Property CAS07 As Decimal?

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS08 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS09 is the amount of the adjustment.</remarks>
        Property CAS09 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS10 is the units of service being adjusted.</remarks>
        Property CAS10 As Decimal?

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS11 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS12 is the amount of the adjustment.</remarks>
        Property CAS12 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS13 is the units of service being adjusted.</remarks>
        Property CAS13 As Decimal?

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS14 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS15 is the amount of the adjustment.</remarks>
        Property CAS15 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS16 is the units of service being adjusted.</remarks>
        Property CAS16 As Decimal?

        '''<summary>Claim Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property CAS17 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CAS18 is the amount of the adjustment.</remarks>
        Property CAS18 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CAS19 is the units of service being adjusted.</remarks>
        Property CAS19 As Decimal?

    End Interface
End NameSpace