Namespace Segments
    '''<summary>Measurements</summary>
    '''<remarks>To specify physical measurements or counts, including dimensions, tolerances, variances, and weights<br /><br />(See Figures Appendix for example of use of C001)</remarks>
    Partial Friend Class MEA_Obj
        Inherits Segment
        Implements MEA,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({3, 5, 6, 8}),
                                                 New SyntaxRuleExclusion({4, 12}),
                                                 New SyntaxRuleListConditional(5, {4, 12}),
                                                 New SyntaxRuleListConditional(6, {4, 12}),
                                                 New SyntaxRuleListConditional(7, {3, 5, 6}),
                                                 New SyntaxRuleExclusion({8, 3}),
                                                 New SyntaxRulePaired({11, 12})}

        Public Sub New()
            MyBase.New("MEA")
            Elements.AddRange({CType(Nothing, DataElements.Element737),
                                      CType(Nothing, DataElements.Element738),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element740),
                                      CType(Nothing, DataElements.Element741),
                                      CType(Nothing, DataElements.Element935),
                                      CType(Nothing, DataElements.Element936),
                                      CType(Nothing, DataElements.Element752),
                                      CType(Nothing, DataElements.Element1373),
                                      CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property MEA01 As String Implements MEA.MEA01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA.MEA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element737).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element737
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element737).Value = value
                End If
            End Set
        End Property

        Friend Property MEA02 As String Implements MEA.MEA02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA.MEA02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element738).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element738
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element738).Value = value
                End If
            End Set
        End Property

        Friend Property MEA03 As Decimal? Implements MEA.MEA03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.MEA.MEA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element739
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property MEA04 As DataElements.Composite.C001 Implements MEA.MEA04
            Get
                Return CType(Elements(3), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(3) = value
            End Set
        End Property

        Friend Property MEA05 As Decimal? Implements MEA.MEA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element740).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element740
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element740).Value = value
                End If
            End Set
        End Property

        Friend Property MEA06 As Decimal? Implements MEA.MEA06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element741).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element741
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element741).Value = value
                End If
            End Set
        End Property

        Friend Property MEA07 As String Implements MEA.MEA07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element935).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element935
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element935).Value = value
                End If
            End Set
        End Property

        Friend Property MEA08 As String Implements MEA.MEA08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element936).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element936
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element936).Value = value
                End If
            End Set
        End Property

        Friend Property MEA09 As String Implements MEA.MEA09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element752).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element752
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element752).Value = value
                End If
            End Set
        End Property

        Friend Property MEA10 As String Implements MEA.MEA10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1373).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1373
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1373).Value = value
                End If
            End Set
        End Property

        Friend Property MEA11 As String Implements MEA.MEA11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1270
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property MEA12 As String Implements MEA.MEA12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1271
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As MEA
            Dim rval As New MEA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .MEA01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .MEA02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .MEA03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .MEA05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .MEA06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .MEA07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .MEA08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .MEA09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .MEA10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .MEA11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .MEA12 = source.ToStringValue(11)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Measurements</summary>
    '''<remarks>To specify physical measurements or counts, including dimensions, tolerances, variances, and weights<br /><br />(See Figures Appendix for example of use of C001)</remarks>
    Public Interface MEA
        Inherits ISegment

        '''<summary>Measurement Reference ID Code</summary>
        '''<remarks></remarks>
        Property MEA01 As String

        '''<summary>Measurement Qualifier</summary>
        '''<remarks></remarks>
        Property MEA02 As String

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property MEA03 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks>MEA04 defines the unit of measure for MEA03, MEA05, and MEA06.</remarks>
        Property MEA04 As DataElements.Composite.C001

        '''<summary>Range Minimum</summary>
        '''<remarks>When citing dimensional tolerances, any measurement requiring a sign (+ or -), or any measurement where a positive (+) value cannot be assumed, use MEA05 as the negative (-) value and MEA06 as the positive (+) value.</remarks>
        Property MEA05 As Decimal?

        '''<summary>Range Maximum</summary>
        '''<remarks></remarks>
        Property MEA06 As Decimal?

        '''<summary>Measurement Significance Code</summary>
        '''<remarks></remarks>
        Property MEA07 As String

        '''<summary>Measurement Attribute Code</summary>
        '''<remarks></remarks>
        Property MEA08 As String

        '''<summary>Surface/Layer/Position Code</summary>
        '''<remarks></remarks>
        Property MEA09 As String

        '''<summary>Measurement Method or Device</summary>
        '''<remarks></remarks>
        Property MEA10 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks>MEA11 is the external code list for the unit of measure.</remarks>
        Property MEA11 As String

        '''<summary>Industry Code</summary>
        '''<remarks>MEA12 defines the unit of measure for MEA03, MEA05, and MEA06 from an external code list.</remarks>
        Property MEA12 As String

    End Interface
End NameSpace