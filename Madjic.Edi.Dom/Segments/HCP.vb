Namespace Segments
    '''<summary>Health Care Pricing</summary>
    '''<remarks>To specify pricing or repricing information about a health care claim or line item</remarks>
    Partial Friend Class HCP_Obj
        Inherits Segment
        Implements HCP,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({1, 13}),
                                                 New SyntaxRulePaired({9, 10}),
                                                 New SyntaxRulePaired({11, 12})}

        Public Sub New()
            MyBase.New("HCP")
            Elements.AddRange({CType(Nothing, DataElements.Element1473),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element118),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element901),
                                      CType(Nothing, DataElements.Element1526),
                                      CType(Nothing, DataElements.Element1527)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HCP01 As String Implements HCP.HCP01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1473).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1473
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1473).Value = value
                End If
            End Set
        End Property

        Friend Property HCP02 As Decimal? Implements HCP.HCP02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP02
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

        Friend Property HCP03 As Decimal? Implements HCP.HCP03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP03
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

        Friend Property HCP04 As String Implements HCP.HCP04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element127
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property HCP05 As Decimal? Implements HCP.HCP05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element118).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element118
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element118).Value = value
                End If
            End Set
        End Property

        Friend Property HCP06 As String Implements HCP.HCP06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element127
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property HCP07 As Decimal? Implements HCP.HCP07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP07
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

        Friend Property HCP08 As String Implements HCP.HCP08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element234
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property HCP09 As String Implements HCP.HCP09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP09
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

        Friend Property HCP10 As String Implements HCP.HCP10, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP10, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP10, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP10
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

        Friend Property HCP11 As String Implements HCP.HCP11, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP11, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP11, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP11, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element355
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property HCP12 As Decimal? Implements HCP.HCP12, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP12, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP12, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP12, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element380
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property HCP13 As String Implements HCP.HCP13, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP13, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP13, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP13, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP13, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP13, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element901).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element901
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element901).Value = value
                End If
            End Set
        End Property

        Friend Property HCP14 As String Implements HCP.HCP14, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP14, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP14, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP14, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP14, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP14, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1526).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1526
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1526).Value = value
                End If
            End Set
        End Property

        Friend Property HCP15 As String Implements HCP.HCP15, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HCP.HCP15, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.HCP.HCP15, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HCP.HCP15, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.HCP.HCP15, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HCP.HCP15, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.HCP.HCP15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1527).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1527
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1527).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HCP
            Dim rval As New HCP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HCP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HCP02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HCP03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HCP04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .HCP05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .HCP06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .HCP07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .HCP08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .HCP09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .HCP10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .HCP11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .HCP12 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .HCP13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .HCP14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .HCP15 = source.ToStringValue(14)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Care Pricing</summary>
    '''<remarks>To specify pricing or repricing information about a health care claim or line item</remarks>
    Public Interface HCP
        Inherits ISegment

        '''<summary>Pricing Methodology</summary>
        '''<remarks></remarks>
        Property HCP01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>HCP02 is the allowed amount.</remarks>
        Property HCP02 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>HCP03 is the savings amount.</remarks>
        Property HCP03 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>HCP04 is the repricing organization identification number.</remarks>
        Property HCP04 As String

        '''<summary>Rate</summary>
        '''<remarks>HCP05 is the pricing rate associated with per diem or flat rate repricing.</remarks>
        Property HCP05 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>HCP06 is the approved DRG code.</remarks>
        Property HCP06 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>HCP07 is the approved DRG amount.</remarks>
        Property HCP07 As Decimal?

        '''<summary>Product/Service ID</summary>
        '''<remarks>HCP08 is the approved revenue code.</remarks>
        Property HCP08 As String

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property HCP09 As String

        '''<summary>Product/Service ID</summary>
        '''<remarks>HCP10 is the approved procedure code.</remarks>
        Property HCP10 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property HCP11 As String

        '''<summary>Quantity</summary>
        '''<remarks>HCP12 is the approved service units or inpatient days.</remarks>
        Property HCP12 As Decimal?

        '''<summary>Reject Reason Code</summary>
        '''<remarks>HCP13 is the rejection message returned from the third party organization.</remarks>
        Property HCP13 As String

        '''<summary>Policy Compliance Code</summary>
        '''<remarks></remarks>
        Property HCP14 As String

        '''<summary>Exception Code</summary>
        '''<remarks>HCP15 is the exception reason generated by a third party organization.</remarks>
        Property HCP15 As String

    End Interface
End NameSpace