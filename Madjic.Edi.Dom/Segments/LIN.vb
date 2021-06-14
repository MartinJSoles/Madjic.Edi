Namespace Segments
    '''<summary>Item Identification</summary>
    '''<remarks>To specify basic item identification data</remarks>
    Partial Friend Class LIN_Obj
        Inherits Segment
        Implements LIN,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.LIN,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.LIN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({4, 5}),
                                                 New SyntaxRulePaired({6, 7}),
                                                 New SyntaxRulePaired({8, 9}),
                                                 New SyntaxRulePaired({10, 11}),
                                                 New SyntaxRulePaired({12, 13}),
                                                 New SyntaxRulePaired({14, 15}),
                                                 New SyntaxRulePaired({16, 17}),
                                                 New SyntaxRulePaired({18, 19}),
                                                 New SyntaxRulePaired({20, 21}),
                                                 New SyntaxRulePaired({22, 23}),
                                                 New SyntaxRulePaired({24, 25}),
                                                 New SyntaxRulePaired({26, 27}),
                                                 New SyntaxRulePaired({28, 29}),
                                                 New SyntaxRulePaired({30, 31}),
                                                 New SyntaxRuleAllRequired({2, 3})}

        Public Sub New()
            MyBase.New("LIN")
            Elements.AddRange({CType(Nothing, DataElements.Element350),
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

        Friend Property LIN01 As String Implements LIN.LIN01
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

        Friend Property LIN02 As String Implements LIN.LIN02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.LIN.LIN02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.LIN.LIN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element235
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property LIN03 As String Implements LIN.LIN03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.LIN.LIN03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.LIN.LIN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element234
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property LIN04 As String Implements LIN.LIN04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element235
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property LIN05 As String Implements LIN.LIN05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element234
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property LIN06 As String Implements LIN.LIN06
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

        Friend Property LIN07 As String Implements LIN.LIN07
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

        Friend Property LIN08 As String Implements LIN.LIN08
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

        Friend Property LIN09 As String Implements LIN.LIN09
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

        Friend Property LIN10 As String Implements LIN.LIN10
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

        Friend Property LIN11 As String Implements LIN.LIN11
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

        Friend Property LIN12 As String Implements LIN.LIN12
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

        Friend Property LIN13 As String Implements LIN.LIN13
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

        Friend Property LIN14 As String Implements LIN.LIN14
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

        Friend Property LIN15 As String Implements LIN.LIN15
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

        Friend Property LIN16 As String Implements LIN.LIN16
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

        Friend Property LIN17 As String Implements LIN.LIN17
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

        Friend Property LIN18 As String Implements LIN.LIN18
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

        Friend Property LIN19 As String Implements LIN.LIN19
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

        Friend Property LIN20 As String Implements LIN.LIN20
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

        Friend Property LIN21 As String Implements LIN.LIN21
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

        Friend Property LIN22 As String Implements LIN.LIN22
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

        Friend Property LIN23 As String Implements LIN.LIN23
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

        Friend Property LIN24 As String Implements LIN.LIN24
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

        Friend Property LIN25 As String Implements LIN.LIN25
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

        Friend Property LIN26 As String Implements LIN.LIN26
            Get
                Return If(Elements(25) IsNot Nothing, CType(Elements(25), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(25) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(25) = New DataElements.Element235
                End If

                If Elements(25) IsNot Nothing Then
                    CType(Elements(25), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property LIN27 As String Implements LIN.LIN27
            Get
                Return If(Elements(26) IsNot Nothing, CType(Elements(26), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(26) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(26) = New DataElements.Element234
                End If

                If Elements(26) IsNot Nothing Then
                    CType(Elements(26), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property LIN28 As String Implements LIN.LIN28
            Get
                Return If(Elements(27) IsNot Nothing, CType(Elements(27), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(27) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(27) = New DataElements.Element235
                End If

                If Elements(27) IsNot Nothing Then
                    CType(Elements(27), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property LIN29 As String Implements LIN.LIN29
            Get
                Return If(Elements(28) IsNot Nothing, CType(Elements(28), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(28) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(28) = New DataElements.Element234
                End If

                If Elements(28) IsNot Nothing Then
                    CType(Elements(28), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property LIN30 As String Implements LIN.LIN30
            Get
                Return If(Elements(29) IsNot Nothing, CType(Elements(29), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(29) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(29) = New DataElements.Element235
                End If

                If Elements(29) IsNot Nothing Then
                    CType(Elements(29), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property LIN31 As String Implements LIN.LIN31
            Get
                Return If(Elements(30) IsNot Nothing, CType(Elements(30), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(30) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(30) = New DataElements.Element234
                End If

                If Elements(30) IsNot Nothing Then
                    CType(Elements(30), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LIN
            Dim rval As New LIN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LIN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .LIN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .LIN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .LIN04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .LIN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .LIN06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .LIN07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .LIN08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .LIN09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .LIN10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .LIN11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .LIN12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .LIN13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .LIN14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .LIN15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .LIN16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .LIN17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .LIN18 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .LIN19 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .LIN20 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .LIN21 = source.ToStringValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .LIN22 = source.ToStringValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .LIN23 = source.ToStringValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .LIN24 = source.ToStringValue(23)
                End If
                If source.Elements.Count > 24 Then
                    .LIN25 = source.ToStringValue(24)
                End If
                If source.Elements.Count > 25 Then
                    .LIN26 = source.ToStringValue(25)
                End If
                If source.Elements.Count > 26 Then
                    .LIN27 = source.ToStringValue(26)
                End If
                If source.Elements.Count > 27 Then
                    .LIN28 = source.ToStringValue(27)
                End If
                If source.Elements.Count > 28 Then
                    .LIN29 = source.ToStringValue(28)
                End If
                If source.Elements.Count > 29 Then
                    .LIN30 = source.ToStringValue(29)
                End If
                If source.Elements.Count > 30 Then
                    .LIN31 = source.ToStringValue(30)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Item Identification</summary>
    '''<remarks>To specify basic item identification data</remarks>
    Public Interface LIN
        Inherits ISegment

        '''<summary>Assigned Identification</summary>
        '''<remarks>LIN01 is the line item identification</remarks>
        Property LIN01 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks>LIN02 through LIN31 provide for fifteen different product/service IDs for each item. For example: Case, Color, Drawing No., U.P.C. No., ISBN No., Model No., or SKU.</remarks>
        Property LIN02 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN03 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN04 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN05 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN06 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN07 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN08 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN09 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN10 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN11 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN12 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN13 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN14 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN15 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN16 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN17 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN18 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN19 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN20 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN21 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN22 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN23 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN24 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN25 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN26 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN27 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN28 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN29 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property LIN30 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks></remarks>
        Property LIN31 As String

    End Interface
End NameSpace