Namespace Segments
    '''<summary>Currency</summary>
    '''<remarks>To specify the currency (dollars, pounds, francs, etc.) used in a transaction</remarks>
    Partial Friend Class CUR_Obj
        Inherits Segment
        Implements CUR,
                   Transactions.Transaction820.Transaction820_A1.Segments.CUR,
                   Transactions.Transaction835.Transaction835_W1.Segments.CUR,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.CUR,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.CUR,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.CUR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(8, {7}),
                                                 New SyntaxRuleConditional(9, {7}),
                                                 New SyntaxRuleListConditional(10, {11, 12}),
                                                 New SyntaxRuleConditional(11, {10}),
                                                 New SyntaxRuleConditional(12, {10}),
                                                 New SyntaxRuleListConditional(13, {14, 15}),
                                                 New SyntaxRuleConditional(14, {13}),
                                                 New SyntaxRuleConditional(15, {13}),
                                                 New SyntaxRuleListConditional(16, {17, 18}),
                                                 New SyntaxRuleConditional(17, {16}),
                                                 New SyntaxRuleConditional(18, {16}),
                                                 New SyntaxRuleListConditional(19, {20, 21}),
                                                 New SyntaxRuleConditional(20, {19}),
                                                 New SyntaxRuleConditional(21, {19}),
                                                 New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("CUR")
            Elements.AddRange({CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element100),
                                      CType(Nothing, DataElements.Element280),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element100),
                                      CType(Nothing, DataElements.Element669),
                                      CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CUR01 As String Implements CUR.CUR01, Transactions.Transaction820.Transaction820_A1.Segments.CUR.CUR01, Transactions.Transaction835.Transaction835_W1.Segments.CUR.CUR01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.CUR.CUR01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.CUR.CUR01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.CUR.CUR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element98
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property CUR02 As String Implements CUR.CUR02, Transactions.Transaction820.Transaction820_A1.Segments.CUR.CUR02, Transactions.Transaction835.Transaction835_W1.Segments.CUR.CUR02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.CUR.CUR02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.CUR.CUR02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.CUR.CUR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element100).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element100
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element100).Value = value
                End If
            End Set
        End Property

        Friend Property CUR03 As Decimal? Implements CUR.CUR03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element280).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element280
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element280).Value = value
                End If
            End Set
        End Property

        Friend Property CUR04 As String Implements CUR.CUR04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element98
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property CUR05 As String Implements CUR.CUR05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element100).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element100
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element100).Value = value
                End If
            End Set
        End Property

        Friend Property CUR06 As String Implements CUR.CUR06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element669).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element669
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element669).Value = value
                End If
            End Set
        End Property

        Friend Property CUR07 As String Implements CUR.CUR07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element374
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property CUR08 As Date? Implements CUR.CUR08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element373
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CUR09 As TimeSpan? Implements CUR.CUR09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element337
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property CUR10 As String Implements CUR.CUR10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element374
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property CUR11 As Date? Implements CUR.CUR11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element373
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CUR12 As TimeSpan? Implements CUR.CUR12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element337
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property CUR13 As String Implements CUR.CUR13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element374
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property CUR14 As Date? Implements CUR.CUR14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element373
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CUR15 As TimeSpan? Implements CUR.CUR15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element337
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property CUR16 As String Implements CUR.CUR16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element374
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property CUR17 As Date? Implements CUR.CUR17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element373
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CUR18 As TimeSpan? Implements CUR.CUR18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element337
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property CUR19 As String Implements CUR.CUR19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element374
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property CUR20 As Date? Implements CUR.CUR20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element373
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CUR21 As TimeSpan? Implements CUR.CUR21
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element337
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CUR
            Dim rval As New CUR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CUR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CUR02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CUR03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CUR04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CUR05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CUR06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CUR07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CUR08 = source.ToDateValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CUR09 = source.ToTimeSpanValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CUR10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CUR11 = source.ToDateValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CUR12 = source.ToTimeSpanValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CUR13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CUR14 = source.ToDateValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CUR15 = source.ToTimeSpanValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CUR16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CUR17 = source.ToDateValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CUR18 = source.ToTimeSpanValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .CUR19 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .CUR20 = source.ToDateValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .CUR21 = source.ToTimeSpanValue(20)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Currency</summary>
    '''<remarks>To specify the currency (dollars, pounds, francs, etc.) used in a transaction</remarks>
    Public Interface CUR
        Inherits ISegment

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property CUR01 As String

        '''<summary>Currency Code</summary>
        '''<remarks></remarks>
        Property CUR02 As String

        '''<summary>Exchange Rate</summary>
        '''<remarks></remarks>
        Property CUR03 As Decimal?

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property CUR04 As String

        '''<summary>Currency Code</summary>
        '''<remarks></remarks>
        Property CUR05 As String

        '''<summary>Currency Market/Exchange Code</summary>
        '''<remarks></remarks>
        Property CUR06 As String

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property CUR07 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property CUR08 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property CUR09 As Timespan?

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property CUR10 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property CUR11 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property CUR12 As Timespan?

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property CUR13 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property CUR14 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property CUR15 As Timespan?

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property CUR16 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property CUR17 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property CUR18 As Timespan?

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property CUR19 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property CUR20 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property CUR21 As Timespan?

    End Interface
End NameSpace