Namespace Segments
    '''<summary>Baseline Item Data (Invoice)</summary>
    '''<remarks>To specify the basic and most frequently used line item data for the invoice and related transactions</remarks>
    Partial Friend Class IT1_Obj
        Inherits Segment
        Implements IT1,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3, 4}),
                                                 New SyntaxRulePaired({6, 7}),
                                                 New SyntaxRulePaired({8, 9}),
                                                 New SyntaxRulePaired({10, 11}),
                                                 New SyntaxRulePaired({12, 13}),
                                                 New SyntaxRulePaired({14, 15}),
                                                 New SyntaxRulePaired({16, 17}),
                                                 New SyntaxRulePaired({18, 19}),
                                                 New SyntaxRulePaired({20, 21}),
                                                 New SyntaxRulePaired({22, 23}),
                                                 New SyntaxRulePaired({24, 25})}

        Public Sub New()
            MyBase.New("IT1")
            Elements.AddRange({CType(Nothing, DataElements.Element350),
                                      CType(Nothing, DataElements.Element358),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element212),
                                      CType(Nothing, DataElements.Element639),
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

        Friend Property IT101 As String Implements IT1.IT101, Transactions.Transaction820.Transaction820_A1.Segments.Loop2310A.IT1.IT101
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

        Friend Property IT102 As Decimal? Implements IT1.IT102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element358).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element358
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element358).Value = value
                End If
            End Set
        End Property

        Friend Property IT103 As String Implements IT1.IT103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element355
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property IT104 As Decimal? Implements IT1.IT104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element212).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element212
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element212).Value = value
                End If
            End Set
        End Property

        Friend Property IT105 As String Implements IT1.IT105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element639).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element639
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element639).Value = value
                End If
            End Set
        End Property

        Friend Property IT106 As String Implements IT1.IT106
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element235
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT107 As String Implements IT1.IT107
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element234
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT108 As String Implements IT1.IT108
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element235
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT109 As String Implements IT1.IT109
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element234
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT110 As String Implements IT1.IT110
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element235
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT111 As String Implements IT1.IT111
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element234
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT112 As String Implements IT1.IT112
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element235
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT113 As String Implements IT1.IT113
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element234
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT114 As String Implements IT1.IT114
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element235
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT115 As String Implements IT1.IT115
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element234
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT116 As String Implements IT1.IT116
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element235
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT117 As String Implements IT1.IT117
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element234
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT118 As String Implements IT1.IT118
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element235
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT119 As String Implements IT1.IT119
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element234
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT120 As String Implements IT1.IT120
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element235
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT121 As String Implements IT1.IT121
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element234
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT122 As String Implements IT1.IT122
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element235
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT123 As String Implements IT1.IT123
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element234
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property IT124 As String Implements IT1.IT124
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.Element235
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property IT125 As String Implements IT1.IT125
            Get
                Return If(Elements(24) IsNot Nothing, CType(Elements(24), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(24) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(24) = New DataElements.Element234
                End If

                If Elements(24) IsNot Nothing Then
                    CType(Elements(24), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IT1
            Dim rval As New IT1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .IT101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .IT102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .IT103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IT104 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .IT105 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .IT106 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .IT107 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .IT108 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .IT109 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .IT110 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .IT111 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .IT112 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .IT113 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .IT114 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .IT115 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .IT116 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .IT117 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .IT118 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .IT119 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .IT120 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .IT121 = source.ToStringValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .IT122 = source.ToStringValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .IT123 = source.ToStringValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .IT124 = source.ToStringValue(23)
                End If
                If source.Elements.Count > 24 Then
                    .IT125 = source.ToStringValue(24)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Baseline Item Data (Invoice)</summary>
    '''<remarks>To specify the basic and most frequently used line item data for the invoice and related transactions</remarks>
    Public Interface IT1
        Inherits ISegment

        '''<summary>Assigned Identification</summary>
        '''<remarks>IT101 is the line item identification.</remarks>
        Property IT101 As String

        '''<summary>Quantity Invoiced</summary>
        '''<remarks></remarks>
        Property IT102 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property IT103 As String

        '''<summary>Unit Price</summary>
        '''<remarks></remarks>
        Property IT104 As Decimal?

        '''<summary>Basis of Unit Price Code</summary>
        '''<remarks></remarks>
        Property IT105 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks>IT106 through IT125 provide for ten different product/service IDs for each item. For example: Case, Color, Drawing No., U.P.C. No., ISBN No., Model No., or SKU.</remarks>
        Property IT106 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT107 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT108 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT109 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT110 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT111 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT112 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT113 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT114 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT115 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT116 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT117 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT118 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT119 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT120 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT121 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT122 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT123 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property IT124 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property IT125 As String

    End Interface
End NameSpace