Namespace Segments
    '''<summary>Durable Medical Equipment Service</summary>
    '''<remarks>To specify the claim service detail for durable medical equipment</remarks>
    Partial Friend Class SV5_Obj
        Inherits Segment
        Implements SV5,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({4, 5}),
                                                 New SyntaxRuleConditional(6, {4}),
                                                 New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("SV5")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element923)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV501 As DataElements.Composite.C003 Implements SV5.SV501
            Get
                Return CType(Elements(0), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(0) = value
            End Set
        End Property

        Private Property SV501_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.SV5_01.C003 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV501
            Get
                Return CType(SV501, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.SV5_01.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV5.SV5_01.C003)
                SV501 = value
            End Set
        End Property

        Friend Property SV502 As String Implements SV5.SV502, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV502
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element355
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property SV503 As Decimal? Implements SV5.SV503, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV503
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SV504 As Decimal? Implements SV5.SV504, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV504
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

        Friend Property SV505 As Decimal? Implements SV5.SV505, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV505
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element782
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property SV506 As String Implements SV5.SV506, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV5.SV506
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element594
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property SV507 As String Implements SV5.SV507
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element923).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element923
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element923).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV5
            Dim rval As New SV5_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .SV502 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SV503 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV504 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SV505 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV506 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SV507 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Durable Medical Equipment Service</summary>
    '''<remarks>To specify the claim service detail for durable medical equipment</remarks>
    Public Interface SV5
        Inherits ISegment

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV501 As DataElements.Composite.C003

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property SV502 As String

        '''<summary>Quantity</summary>
        '''<remarks>SV503 is the length of medical treatment required.</remarks>
        Property SV503 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV504 is the rental price.</remarks>
        Property SV504 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV505 is the purchase price.</remarks>
        Property SV505 As Decimal?

        '''<summary>Frequency Code</summary>
        '''<remarks>SV506 is the frequency at which the rental equipment is billed.</remarks>
        Property SV506 As String

        '''<summary>Prognosis Code</summary>
        '''<remarks></remarks>
        Property SV507 As String

    End Interface
End NameSpace