Namespace Segments
    '''<summary>Health Care Services Delivery</summary>
    '''<remarks>To specify the delivery pattern of health care services</remarks>
    Partial Friend Class HSD_Obj
        Inherits Segment
        Implements HSD,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRuleConditional(6, {5})}

        Public Sub New()
            MyBase.New("HSD")
            Elements.AddRange({CType(Nothing, DataElements.Element673),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element1167),
                                      CType(Nothing, DataElements.Element615),
                                      CType(Nothing, DataElements.Element616),
                                      CType(Nothing, DataElements.Element678),
                                      CType(Nothing, DataElements.Element679)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HSD01 As String Implements HSD.HSD01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element673).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element673
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element673).Value = value
                End If
            End Set
        End Property

        Friend Property HSD02 As Decimal? Implements HSD.HSD02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element380
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property HSD03 As String Implements HSD.HSD03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD03
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

        Friend Property HSD04 As Decimal? Implements HSD.HSD04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1167).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1167
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1167).Value = value
                End If
            End Set
        End Property

        Friend Property HSD05 As String Implements HSD.HSD05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element615).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element615
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element615).Value = value
                End If
            End Set
        End Property

        Friend Property HSD06 As Decimal? Implements HSD.HSD06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element616).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element616
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element616).Value = value
                End If
            End Set
        End Property

        Friend Property HSD07 As String Implements HSD.HSD07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element678).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element678
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element678).Value = value
                End If
            End Set
        End Property

        Friend Property HSD08 As String Implements HSD.HSD08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.HSD.HSD08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.HSD.HSD08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HSD.HSD08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HSD.HSD08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HSD.HSD08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HSD.HSD08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element679).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element679
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element679).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HSD
            Dim rval As New HSD_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HSD01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HSD02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HSD03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HSD04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .HSD05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .HSD06 = source.ToDecimalValue(5, 0)
                End If
                If source.Elements.Count > 6 Then
                    .HSD07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .HSD08 = source.ToStringValue(7)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Care Services Delivery</summary>
    '''<remarks>To specify the delivery pattern of health care services</remarks>
    Public Interface HSD
        Inherits ISegment

        '''<summary>Quantity Qualifier</summary>
        '''<remarks></remarks>
        Property HSD01 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property HSD02 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property HSD03 As String

        '''<summary>Sample Selection Modulus</summary>
        '''<remarks></remarks>
        Property HSD04 As Decimal?

        '''<summary>Time Period Qualifier</summary>
        '''<remarks></remarks>
        Property HSD05 As String

        '''<summary>Number of Periods</summary>
        '''<remarks></remarks>
        Property HSD06 As Decimal?

        '''<summary>Ship/Delivery or Calendar Pattern Code</summary>
        '''<remarks></remarks>
        Property HSD07 As String

        '''<summary>Ship/Delivery Pattern Time Code</summary>
        '''<remarks></remarks>
        Property HSD08 As String

    End Interface
End NameSpace