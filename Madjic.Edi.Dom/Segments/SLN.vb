Namespace Segments
    '''<summary>Subline Item Detail</summary>
    '''<remarks>To specify product subline detail item data</remarks>
    Partial Friend Class SLN_Obj
        Inherits Segment
        Implements SLN,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({4, 5}),
                                                 New SyntaxRuleConditional(7, {6}),
                                                 New SyntaxRuleConditional(8, {6}),
                                                 New SyntaxRulePaired({9, 10}),
                                                 New SyntaxRulePaired({11, 12}),
                                                 New SyntaxRulePaired({13, 14}),
                                                 New SyntaxRulePaired({15, 16}),
                                                 New SyntaxRulePaired({17, 18}),
                                                 New SyntaxRulePaired({19, 20}),
                                                 New SyntaxRulePaired({21, 22}),
                                                 New SyntaxRulePaired({23, 24}),
                                                 New SyntaxRulePaired({25, 26}),
                                                 New SyntaxRulePaired({27, 28}),
                                                 New SyntaxRuleAllRequired({1, 3})}

        Public Sub New()
            MyBase.New("SLN")
            Elements.AddRange({CType(Nothing, DataElements.Element350),
                                      CType(Nothing, DataElements.Element350),
                                      CType(Nothing, DataElements.Element662),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element212),
                                      CType(Nothing, DataElements.Element639),
                                      CType(Nothing, DataElements.Element662),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SLN01 As String Implements SLN.SLN01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN.SLN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element350
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element350).Value = value
                End If
            End Set
        End Property

        Friend Property SLN02 As String Implements SLN.SLN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element350
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element350).Value = value
                End If
            End Set
        End Property

        Friend Property SLN03 As String Implements SLN.SLN03, Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN.SLN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element662).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element662
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element662).Value = value
                End If
            End Set
        End Property

        Friend Property SLN04 As Decimal? Implements SLN.SLN04, Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN.SLN04
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

        Friend Property SLN05 As DataElements.Composite.C001 Implements SLN.SLN05
            Get
                Return CType(Elements(4), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(4) = value
            End Set
        End Property

        Private Property SLN05_IFace As Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001 Implements Transactions.Transaction820.Transaction820_A1.Segments.Loop2315A.SLN.SLN05
            Get
                Return CType(SLN05, Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001)
            End Get
            Set(value As Transactions.Transaction820.Transaction820_A1.Composites.Loop2315A.SLN.SLN_05.C001)
                SLN05 = value
            End Set
        End Property

        Friend Property SLN06 As Decimal? Implements SLN.SLN06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element212).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element212
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element212).Value = value
                End If
            End Set
        End Property

        Friend Property SLN07 As String Implements SLN.SLN07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element639).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element639
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element639).Value = value
                End If
            End Set
        End Property

        Friend Property SLN08 As String Implements SLN.SLN08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element662).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element662
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element662).Value = value
                End If
            End Set
        End Property

        Friend Property SLN09 As String Implements SLN.SLN09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element235
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN10 As String Implements SLN.SLN10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element234
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN11 As String Implements SLN.SLN11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element235
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN12 As String Implements SLN.SLN12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element234
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN13 As String Implements SLN.SLN13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element235
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN14 As String Implements SLN.SLN14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element234
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN15 As String Implements SLN.SLN15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element235
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN16 As String Implements SLN.SLN16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element234
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN17 As String Implements SLN.SLN17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element235
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN18 As String Implements SLN.SLN18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element234
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN19 As String Implements SLN.SLN19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element235
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN20 As String Implements SLN.SLN20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element234
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN21 As String Implements SLN.SLN21
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element235
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN22 As String Implements SLN.SLN22
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element234
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN23 As String Implements SLN.SLN23
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element235
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN24 As String Implements SLN.SLN24
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.Element234
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN25 As String Implements SLN.SLN25
            Get
                Return If(Elements(24) IsNot Nothing, CType(Elements(24), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(24) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(24) = New DataElements.Element235
                End If

                If Elements(24) IsNot Nothing Then
                    CType(Elements(24), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN26 As String Implements SLN.SLN26
            Get
                Return If(Elements(25) IsNot Nothing, CType(Elements(25), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(25) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(25) = New DataElements.Element234
                End If

                If Elements(25) IsNot Nothing Then
                    CType(Elements(25), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SLN27 As String Implements SLN.SLN27
            Get
                Return If(Elements(26) IsNot Nothing, CType(Elements(26), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(26) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(26) = New DataElements.Element235
                End If

                If Elements(26) IsNot Nothing Then
                    CType(Elements(26), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property SLN28 As String Implements SLN.SLN28
            Get
                Return If(Elements(27) IsNot Nothing, CType(Elements(27), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(27) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(27) = New DataElements.Element234
                End If

                If Elements(27) IsNot Nothing Then
                    CType(Elements(27), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SLN
            Dim rval As New SLN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SLN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SLN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SLN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SLN04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .SLN06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SLN07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SLN08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SLN09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SLN10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .SLN11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .SLN12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .SLN13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .SLN14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .SLN15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .SLN16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .SLN17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .SLN18 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .SLN19 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .SLN20 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .SLN21 = source.ToStringValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .SLN22 = source.ToStringValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .SLN23 = source.ToStringValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .SLN24 = source.ToStringValue(23)
                End If
                If source.Elements.Count > 24 Then
                    .SLN25 = source.ToStringValue(24)
                End If
                If source.Elements.Count > 25 Then
                    .SLN26 = source.ToStringValue(25)
                End If
                If source.Elements.Count > 26 Then
                    .SLN27 = source.ToStringValue(26)
                End If
                If source.Elements.Count > 27 Then
                    .SLN28 = source.ToStringValue(27)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Subline Item Detail</summary>
    '''<remarks>To specify product subline detail item data</remarks>
    Public Interface SLN
        Inherits ISegment

        '''<summary>Assigned Identification</summary>
        '''<remarks>SLN01 is the identifying number for the subline item.</remarks>
        Property SLN01 As String

        '''<summary>Assigned Identification</summary>
        '''<remarks>SLN02 is the identifying number for the subline level. The subline level is analogous to the level code used in a bill of materials.</remarks>
        Property SLN02 As String

        '''<summary>Relationship Code</summary>
        '''<remarks>SLN03 is the configuration code indicating the relationship of the subline item to the baseline item.</remarks>
        Property SLN03 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property SLN04 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property SLN05 As DataElements.Composite.C001

        '''<summary>Unit Price</summary>
        '''<remarks></remarks>
        Property SLN06 As Decimal?

        '''<summary>Basis of Unit Price Code</summary>
        '''<remarks></remarks>
        Property SLN07 As String

        '''<summary>Relationship Code</summary>
        '''<remarks>SLN08 is a code indicating the relationship of the price or amount to the associated segment.</remarks>
        Property SLN08 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks>SLN09 through SLN28 provide for ten different product/service IDs for each item. For example: Case, Color, Drawing No., U.P.C. No., ISBN No., Model No., or SKU.</remarks>
        Property SLN09 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN10 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN11 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN12 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN13 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN14 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN15 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN16 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN17 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN18 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN19 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN20 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN21 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN22 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN23 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN24 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN25 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN26 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property SLN27 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property SLN28 As String

    End Interface
End NameSpace