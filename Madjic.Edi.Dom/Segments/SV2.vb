Namespace Segments
    '''<summary>Institutional Service</summary>
    '''<remarks>To specify the service line item detail for a health care institution</remarks>
    Partial Friend Class SV2_Obj
        Inherits Segment
        Implements SV2,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({1, 2}),
                                                 New SyntaxRulePaired({4, 5})}

        Public Sub New()
            MyBase.New("SV2")
            Elements.AddRange({CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1371),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1345),
                                      CType(Nothing, DataElements.Element1337)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV201 As String Implements SV2.SV201, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV201, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV201, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element234
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SV202 As DataElements.Composite.C003 Implements SV2.SV202, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV202, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV202
            Get
                Return CType(Elements(1), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(1) = value
            End Set
        End Property

        Private Property SV202_IFace As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.SV2_02.C003 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV202
            Get
                Return CType(SV202, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.SV2_02.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2400.SV2.SV2_02.C003)
                SV202 = value
            End Set
        End Property

        Friend Property SV203 As Decimal? Implements SV2.SV203, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV203, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV203, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV203
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

        Friend Property SV204 As String Implements SV2.SV204, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV204, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV204, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV204
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element355
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property SV205 As Decimal? Implements SV2.SV205, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV205, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV205, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV205
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element380
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SV206 As Decimal? Implements SV2.SV206, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV206, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV206
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1371).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1371
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1371).Value = value
                End If
            End Set
        End Property

        Friend Property SV207 As Decimal? Implements SV2.SV207, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.SV2.SV207
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

        Friend Property SV208 As String Implements SV2.SV208
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1073
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV209 As String Implements SV2.SV209, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV209
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1345).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1345
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1345).Value = value
                End If
            End Set
        End Property

        Friend Property SV210 As String Implements SV2.SV210, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV2.SV210, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV2.SV210
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1337).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1337
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1337).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV2
            Dim rval As New SV2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SV201 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .Elements(1) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(1), reader)
                End If
                If source.Elements.Count > 2 Then
                    .SV203 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV204 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SV205 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV206 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SV207 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SV208 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SV209 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SV210 = source.ToStringValue(9)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Institutional Service</summary>
    '''<remarks>To specify the service line item detail for a health care institution</remarks>
    Public Interface SV2
        Inherits ISegment

        '''<summary>Product/Service ID</summary>
        '''<remarks>SV201 is the revenue code.</remarks>
        Property SV201 As String

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV202 As DataElements.Composite.C003

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV203 is the submitted service line item amount.</remarks>
        Property SV203 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property SV204 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property SV205 As Decimal?

        '''<summary>Unit Rate</summary>
        '''<remarks></remarks>
        Property SV206 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV207 is a non-covered service amount.</remarks>
        Property SV207 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV208 is the detail service line indicator. A "Y" value indicates a detail service line; an "N" value indicates a summary service line.</remarks>
        Property SV208 As String

        '''<summary>Nursing Home Residential Status Code</summary>
        '''<remarks></remarks>
        Property SV209 As String

        '''<summary>Level of Care Code</summary>
        '''<remarks></remarks>
        Property SV210 As String

    End Interface
End NameSpace