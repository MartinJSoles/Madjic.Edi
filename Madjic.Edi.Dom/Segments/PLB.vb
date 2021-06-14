Namespace Segments
    '''<summary>Provider Level Adjustment</summary>
    '''<remarks>To convey provider level adjustment information for debit or credit transactions such as, accelerated payments, cost report settlements for a fiscal year and timeliness report penalties unrelated to a specific claim or service</remarks>
    Partial Friend Class PLB_Obj
        Inherits Segment
        Implements PLB,
                   Transactions.Transaction835.Transaction835_W1.Segments.PLB
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRulePaired({7, 8}),
                                                 New SyntaxRulePaired({9, 10}),
                                                 New SyntaxRulePaired({11, 12}),
                                                 New SyntaxRulePaired({13, 14}),
                                                 New SyntaxRuleAllRequired({1, 2, 3, 4})}

        Public Sub New()
            MyBase.New("PLB")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C042_Obj),
                                      CType(Nothing, DataElements.Element782)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PLB01 As String Implements PLB.PLB01, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB01
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

        Friend Property PLB02 As Date? Implements PLB.PLB02, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element373
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property PLB03 As DataElements.Composite.C042 Implements PLB.PLB03, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB03
            Get
                Return CType(Elements(2), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(2) = value
            End Set
        End Property

        Friend Property PLB04 As Decimal? Implements PLB.PLB04, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB04
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

        Friend Property PLB05 As DataElements.Composite.C042 Implements PLB.PLB05, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB05
            Get
                Return CType(Elements(4), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(4) = value
            End Set
        End Property

        Friend Property PLB06 As Decimal? Implements PLB.PLB06, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB06
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

        Friend Property PLB07 As DataElements.Composite.C042 Implements PLB.PLB07, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB07
            Get
                Return CType(Elements(6), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(6) = value
            End Set
        End Property

        Friend Property PLB08 As Decimal? Implements PLB.PLB08, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB08
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

        Friend Property PLB09 As DataElements.Composite.C042 Implements PLB.PLB09, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB09
            Get
                Return CType(Elements(8), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(8) = value
            End Set
        End Property

        Friend Property PLB10 As Decimal? Implements PLB.PLB10, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB10
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

        Friend Property PLB11 As DataElements.Composite.C042 Implements PLB.PLB11, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB11
            Get
                Return CType(Elements(10), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(10) = value
            End Set
        End Property

        Friend Property PLB12 As Decimal? Implements PLB.PLB12, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB12
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

        Friend Property PLB13 As DataElements.Composite.C042 Implements PLB.PLB13, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB13
            Get
                Return CType(Elements(12), DataElements.Composite.C042_Obj)
            End Get
            Set(value As DataElements.Composite.C042)
                Elements(12) = value
            End Set
        End Property

        Friend Property PLB14 As Decimal? Implements PLB.PLB14, Transactions.Transaction835.Transaction835_W1.Segments.PLB.PLB14
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PLB
            Dim rval As New PLB_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PLB01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PLB02 = source.ToDateValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(2), reader)
                End If
                If source.Elements.Count > 3 Then
                    .PLB04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .PLB06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .Elements(6) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(6), reader)
                End If
                If source.Elements.Count > 7 Then
                    .PLB08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .Elements(8) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(8), reader)
                End If
                If source.Elements.Count > 9 Then
                    .PLB10 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .Elements(10) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(10), reader)
                End If
                If source.Elements.Count > 11 Then
                    .PLB12 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .Elements(12) = DataElements.Composite.C042_Obj.FromReader(source.ToStringValue(12), reader)
                End If
                If source.Elements.Count > 13 Then
                    .PLB14 = source.ToFloatValue(13)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Provider Level Adjustment</summary>
    '''<remarks>To convey provider level adjustment information for debit or credit transactions such as, accelerated payments, cost report settlements for a fiscal year and timeliness report penalties unrelated to a specific claim or service</remarks>
    Public Interface PLB
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>PLB01 is the provider number assigned by the payer.</remarks>
        Property PLB01 As String

        '''<summary>Date</summary>
        '''<remarks>PLB02 is the last day of the provider's fiscal year.</remarks>
        Property PLB02 As Date?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB03 is the adjustment information as defined by the payer.</remarks>
        Property PLB03 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB04 is the adjustment amount.</remarks>
        Property PLB04 As Decimal?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB05 is the adjustment information as defined by the payer.</remarks>
        Property PLB05 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB06 is the adjustment amount.</remarks>
        Property PLB06 As Decimal?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB07 is adjustment information as defined by the payer.</remarks>
        Property PLB07 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB08 is the adjustment amount.</remarks>
        Property PLB08 As Decimal?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB09 is adjustment information as defined by the payer.</remarks>
        Property PLB09 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB10 is the adjustment amount.</remarks>
        Property PLB10 As Decimal?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB11 is adjustment information as defined by the payer.</remarks>
        Property PLB11 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB12 is the adjustment amount.</remarks>
        Property PLB12 As Decimal?

        '''<summary>Adjustment Identifier</summary>
        '''<remarks>PLB13 is adjustment information as defined by the payer.</remarks>
        Property PLB13 As DataElements.Composite.C042

        '''<summary>Monetary Amount</summary>
        '''<remarks>PLB14 is the adjustment amount.</remarks>
        Property PLB14 As Decimal?

    End Interface
End NameSpace