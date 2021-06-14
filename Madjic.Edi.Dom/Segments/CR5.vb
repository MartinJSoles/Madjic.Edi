Namespace Segments
    '''<summary>Oxygen Therapy Certification</summary>
    '''<remarks>To supply information regarding certification of medical necessity for home oxygen therapy</remarks>
    Partial Friend Class CR5_Obj
        Inherits Segment
        Implements CR5,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5

        Public Sub New()
            MyBase.New("CR5")
            Elements.AddRange({CType(Nothing, DataElements.Element1322),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1348),
                                      CType(Nothing, DataElements.Element1348),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1349),
                                      CType(Nothing, DataElements.Element1350),
                                      CType(Nothing, DataElements.Element1350),
                                      CType(Nothing, DataElements.Element1350),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1382),
                                      CType(Nothing, DataElements.Element1348)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR501 As String Implements CR5.CR501
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1322).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1322
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1322).Value = value
                End If
            End Set
        End Property

        Friend Property CR502 As Decimal? Implements CR5.CR502
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

        Friend Property CR503 As String Implements CR5.CR503, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR503, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR503
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1348).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1348
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1348).Value = value
                End If
            End Set
        End Property

        Friend Property CR504 As String Implements CR5.CR504, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR504, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR504
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1348).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1348
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1348).Value = value
                End If
            End Set
        End Property

        Friend Property CR505 As String Implements CR5.CR505, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR505
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element352
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR506 As Decimal? Implements CR5.CR506, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR506, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR506
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element380
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR507 As Decimal? Implements CR5.CR507, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR507, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR507
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

        Friend Property CR508 As Decimal? Implements CR5.CR508, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR508, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR508
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element380
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR509 As String Implements CR5.CR509, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR509, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR509
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element352
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR510 As Decimal? Implements CR5.CR510, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR510
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

        Friend Property CR511 As Decimal? Implements CR5.CR511, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR511
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

        Friend Property CR512 As String Implements CR5.CR512, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR512
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1349).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1349
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1349).Value = value
                End If
            End Set
        End Property

        Friend Property CR513 As String Implements CR5.CR513, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR513
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element1350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element1350
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element1350).Value = value
                End If
            End Set
        End Property

        Friend Property CR514 As String Implements CR5.CR514, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR514
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1350
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1350).Value = value
                End If
            End Set
        End Property

        Friend Property CR515 As String Implements CR5.CR515, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR515
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1350
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1350).Value = value
                End If
            End Set
        End Property

        Friend Property CR516 As Decimal? Implements CR5.CR516, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR516, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR516
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

        Friend Property CR517 As String Implements CR5.CR517, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR517, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR517
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1382).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1382
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1382).Value = value
                End If
            End Set
        End Property

        Friend Property CR518 As String Implements CR5.CR518, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR5.CR518, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR5.CR518
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element1348).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element1348
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element1348).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR5
            Dim rval As New CR5_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR501 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR502 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR503 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR504 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR505 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR506 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR507 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR508 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR509 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CR510 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CR511 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CR512 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CR513 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CR514 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CR515 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CR516 = source.ToFloatValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CR517 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CR518 = source.ToStringValue(17)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Oxygen Therapy Certification</summary>
    '''<remarks>To supply information regarding certification of medical necessity for home oxygen therapy</remarks>
    Public Interface CR5
        Inherits ISegment

        '''<summary>Certification Type Code</summary>
        '''<remarks></remarks>
        Property CR501 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR502 is the number of months covered by this certification.</remarks>
        Property CR502 As Decimal?

        '''<summary>Oxygen Equipment Type Code</summary>
        '''<remarks></remarks>
        Property CR503 As String

        '''<summary>Oxygen Equipment Type Code</summary>
        '''<remarks></remarks>
        Property CR504 As String

        '''<summary>Description</summary>
        '''<remarks>CR505 is the reason for equipment.</remarks>
        Property CR505 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR506 is the oxygen flow rate in liters per minute.</remarks>
        Property CR506 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR507 is the number of times per day the patient must use oxygen.</remarks>
        Property CR507 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR508 is the number of hours per period of oxygen use.</remarks>
        Property CR508 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>CR509 is the special orders for the respiratory therapist.</remarks>
        Property CR509 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR510 is the arterial blood gas.</remarks>
        Property CR510 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR511 is the oxygen saturation.</remarks>
        Property CR511 As Decimal?

        '''<summary>Oxygen Test Condition Code</summary>
        '''<remarks></remarks>
        Property CR512 As String

        '''<summary>Oxygen Test Findings Code</summary>
        '''<remarks></remarks>
        Property CR513 As String

        '''<summary>Oxygen Test Findings Code</summary>
        '''<remarks></remarks>
        Property CR514 As String

        '''<summary>Oxygen Test Findings Code</summary>
        '''<remarks></remarks>
        Property CR515 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR516 is the oxygen flow rate for a portable oxygen system in liters per minute.</remarks>
        Property CR516 As Decimal?

        '''<summary>Oxygen Delivery System Code</summary>
        '''<remarks></remarks>
        Property CR517 As String

        '''<summary>Oxygen Equipment Type Code</summary>
        '''<remarks></remarks>
        Property CR518 As String

    End Interface
End NameSpace