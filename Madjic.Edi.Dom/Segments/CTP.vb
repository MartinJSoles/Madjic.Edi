Namespace Segments
    '''<summary>Pricing Information</summary>
    '''<remarks>To specify pricing information</remarks>
    Partial Friend Class CTP_Obj
        Inherits Segment
        Implements CTP,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.CTP,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.CTP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({4, 5}),
                                                 New SyntaxRuleConditional(6, {7}),
                                                 New SyntaxRuleConditional(9, {2}),
                                                 New SyntaxRuleConditional(10, {2}),
                                                 New SyntaxRuleConditional(11, {3})}

        Public Sub New()
            MyBase.New("CTP")
            Elements.AddRange({CType(Nothing, DataElements.Element687),
                                      CType(Nothing, DataElements.Element236),
                                      CType(Nothing, DataElements.Element212),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element648),
                                      CType(Nothing, DataElements.Element649),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element639),
                                      CType(Nothing, DataElements.Element499),
                                      CType(Nothing, DataElements.Element289)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CTP01 As String Implements CTP.CTP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element687).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element687
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element687).Value = value
                End If
            End Set
        End Property

        Friend Property CTP02 As String Implements CTP.CTP02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element236).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element236
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element236).Value = value
                End If
            End Set
        End Property

        Friend Property CTP03 As Decimal? Implements CTP.CTP03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element212).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element212
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element212).Value = value
                End If
            End Set
        End Property

        Friend Property CTP04 As Decimal? Implements CTP.CTP04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.CTP.CTP04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.CTP.CTP04
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

        Friend Property CTP05 As DataElements.Composite.C001 Implements CTP.CTP05
            Get
                Return CType(Elements(4), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(4) = value
            End Set
        End Property

        Private Property CTP05_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2410.CTP.CTP_05.C001 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2410.CTP.CTP05
            Get
                Return CType(CTP05, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2410.CTP.CTP_05.C001)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2410.CTP.CTP_05.C001)
                CTP05 = value
            End Set
        End Property

        Private Property CTP05_IFace_1 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2410.CTP.CTP_05.C001 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2410.CTP.CTP05
            Get
                Return CType(CTP05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2410.CTP.CTP_05.C001)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2410.CTP.CTP_05.C001)
                CTP05 = value
            End Set
        End Property

        Friend Property CTP06 As String Implements CTP.CTP06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element648).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element648
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element648).Value = value
                End If
            End Set
        End Property

        Friend Property CTP07 As Decimal? Implements CTP.CTP07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element649).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element649
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element649).Value = value
                End If
            End Set
        End Property

        Friend Property CTP08 As Decimal? Implements CTP.CTP08
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

        Friend Property CTP09 As String Implements CTP.CTP09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element639).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element639
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element639).Value = value
                End If
            End Set
        End Property

        Friend Property CTP10 As String Implements CTP.CTP10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element499).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element499
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element499).Value = value
                End If
            End Set
        End Property

        Friend Property CTP11 As Decimal? Implements CTP.CTP11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element289).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element289
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element289).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CTP
            Dim rval As New CTP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CTP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CTP02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CTP03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CTP04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .CTP06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CTP07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CTP08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CTP09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CTP10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CTP11 = source.ToDecimalValue(10, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Pricing Information</summary>
    '''<remarks>To specify pricing information</remarks>
    Public Interface CTP
        Inherits ISegment

        '''<summary>Class of Trade Code</summary>
        '''<remarks></remarks>
        Property CTP01 As String

        '''<summary>Price Identifier Code</summary>
        '''<remarks></remarks>
        Property CTP02 As String

        '''<summary>Unit Price</summary>
        '''<remarks>See Figures Appendix for an example detailing the use of CTP03 and CTP04.</remarks>
        Property CTP03 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property CTP04 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property CTP05 As DataElements.Composite.C001

        '''<summary>Price Multiplier Qualifier</summary>
        '''<remarks></remarks>
        Property CTP06 As String

        '''<summary>Multiplier</summary>
        '''<remarks>CTP07 is a multiplier factor to arrive at a final discounted price. A multiplier of .90 would be the factor if a 10% discount is given.</remarks>
        Property CTP07 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>CTP08 is the rebate amount.</remarks>
        Property CTP08 As Decimal?

        '''<summary>Basis of Unit Price Code</summary>
        '''<remarks></remarks>
        Property CTP09 As String

        '''<summary>Condition Value</summary>
        '''<remarks></remarks>
        Property CTP10 As String

        '''<summary>Multiple Price Quantity</summary>
        '''<remarks></remarks>
        Property CTP11 As Decimal?

    End Interface
End NameSpace