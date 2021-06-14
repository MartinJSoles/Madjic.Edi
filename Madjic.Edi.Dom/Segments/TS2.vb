Namespace Segments
    '''<summary>Transaction Supplemental Statistics</summary>
    '''<remarks>To provide supplemental summary control information by provider fiscal year and bill type</remarks>
    Partial Friend Class TS2_Obj
        Inherits Segment
        Implements TS2,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2

        Public Sub New()
            MyBase.New("TS2")
            Elements.AddRange({CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TS201 As Decimal? Implements TS2.TS201, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element782
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS202 As Decimal? Implements TS2.TS202, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS202
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

        Friend Property TS203 As Decimal? Implements TS2.TS203, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS203
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

        Friend Property TS204 As Decimal? Implements TS2.TS204, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS204
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

        Friend Property TS205 As Decimal? Implements TS2.TS205, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS205
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

        Friend Property TS206 As Decimal? Implements TS2.TS206, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS206
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

        Friend Property TS207 As Decimal? Implements TS2.TS207, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS207
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element380
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS208 As Decimal? Implements TS2.TS208, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS208
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

        Friend Property TS209 As Decimal? Implements TS2.TS209, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS209
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element782
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS210 As Decimal? Implements TS2.TS210, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS210
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element380
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS211 As Decimal? Implements TS2.TS211, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS211
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element380
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS212 As Decimal? Implements TS2.TS212, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS212
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

        Friend Property TS213 As Decimal? Implements TS2.TS213, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS213
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element380
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS214 As Decimal? Implements TS2.TS214, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS214
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element380
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS215 As Decimal? Implements TS2.TS215, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS215
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element782
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS216 As Decimal? Implements TS2.TS216, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS216
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element380
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property TS217 As Decimal? Implements TS2.TS217, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS217
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element782
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS218 As Decimal? Implements TS2.TS218, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS218
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element782
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TS219 As Decimal? Implements TS2.TS219, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.TS2.TS219
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element782
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TS2
            Dim rval As New TS2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TS201 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TS202 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TS203 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TS204 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .TS205 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .TS206 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .TS207 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .TS208 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .TS209 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .TS210 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .TS211 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .TS212 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .TS213 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .TS214 = source.ToFloatValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .TS215 = source.ToFloatValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .TS216 = source.ToFloatValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .TS217 = source.ToFloatValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .TS218 = source.ToFloatValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .TS219 = source.ToFloatValue(18)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Supplemental Statistics</summary>
    '''<remarks>To provide supplemental summary control information by provider fiscal year and bill type</remarks>
    Public Interface TS2
        Inherits ISegment

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS201 is the total diagnosis related group (DRG) amount.</remarks>
        Property TS201 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS202 is the total federal specific amount.</remarks>
        Property TS202 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS203 is the total hospital specific amount.</remarks>
        Property TS203 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS204 is the total disproportionate share amount.</remarks>
        Property TS204 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS205 is the total capital amount.</remarks>
        Property TS205 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS206 is the total indirect medical education amount.</remarks>
        Property TS206 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS207 is the total number of outlier days.</remarks>
        Property TS207 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS208 is the total day outlier amount.</remarks>
        Property TS208 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS209 is the total cost outlier amount.</remarks>
        Property TS209 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS210 is the diagnosis related group (DRG) average length of stay.</remarks>
        Property TS210 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS211 is the total number of discharges.</remarks>
        Property TS211 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS212 is the total number of cost report days.</remarks>
        Property TS212 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS213 is the total number of covered days.</remarks>
        Property TS213 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS214 is total number of non-covered days.</remarks>
        Property TS214 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS215 is the total Medicare Secondary Payer (MSP) pass- through amount calculated for a non-Medicare payer.</remarks>
        Property TS215 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>TS216 is the average diagnosis-related group (DRG) weight.</remarks>
        Property TS216 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS217 is the total prospective payment system (PPS) capital, federal-specific portion, diagnosis-related group (DRG) amount.</remarks>
        Property TS217 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS218 is the total prospective payment system (PPS) capital, hospital-specific portion, diagnosis-related group (DRG) amount.</remarks>
        Property TS218 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>TS219 is the total prospective payment system (PPS) disproportionate share, hospital diagnosis-related group (DRG) amount.</remarks>
        Property TS219 As Decimal?

    End Interface
End NameSpace