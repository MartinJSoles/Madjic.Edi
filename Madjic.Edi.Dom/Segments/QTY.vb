Namespace Segments
    '''<summary>Quantity Information</summary>
    '''<remarks>To specify quantity information</remarks>
    Partial Friend Class QTY_Obj
        Inherits Segment
        Implements QTY,
                   Transactions.Transaction834.Transaction834_A1.Segments.QTY,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY_1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({2, 4}),
                                                 New SyntaxRuleExclusion({2, 4}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("QTY")
            Elements.AddRange({CType(Nothing, DataElements.Element673),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element61)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property QTY01 As String Implements QTY.QTY01, Transactions.Transaction834.Transaction834_A1.Segments.QTY.QTY01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY.QTY01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY.QTY01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY.QTY01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY_1.QTY01
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

        Friend Property QTY02 As Decimal? Implements QTY.QTY02, Transactions.Transaction834.Transaction834_A1.Segments.QTY.QTY02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.QTY.QTY02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.QTY.QTY02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY.QTY02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.QTY_1.QTY02
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

        Friend Property QTY03 As DataElements.Composite.C001 Implements QTY.QTY03
            Get
                Return CType(Elements(2), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(2) = value
            End Set
        End Property

        Friend Property QTY04 As String Implements QTY.QTY04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element61).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element61
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element61).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As QTY
            Dim rval As New QTY_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .QTY01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .QTY02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(2), reader)
                End If
                If source.Elements.Count > 3 Then
                    .QTY04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Quantity Information</summary>
    '''<remarks>To specify quantity information</remarks>
    Public Interface QTY
        Inherits ISegment

        '''<summary>Quantity Qualifier</summary>
        '''<remarks></remarks>
        Property QTY01 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property QTY02 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property QTY03 As DataElements.Composite.C001

        '''<summary>Free-form Information</summary>
        '''<remarks>QTY04 is used when the quantity is non-numeric.</remarks>
        Property QTY04 As String

    End Interface
End NameSpace