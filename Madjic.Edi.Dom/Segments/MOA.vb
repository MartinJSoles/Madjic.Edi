Namespace Segments
    '''<summary>Medicare Outpatient Adjudication</summary>
    '''<remarks>To convey claim-level data related to the adjudication of Medicare claims not related to an inpatient setting</remarks>
    Partial Friend Class MOA_Obj
        Inherits Segment
        Implements MOA,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA

        Public Sub New()
            MyBase.New("MOA")
            Elements.AddRange({CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property MOA01 As Decimal? Implements MOA.MOA01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element954
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property MOA02 As Decimal? Implements MOA.MOA02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA02
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

        Friend Property MOA03 As String Implements MOA.MOA03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MOA04 As String Implements MOA.MOA04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA04
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

        Friend Property MOA05 As String Implements MOA.MOA05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element127
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MOA06 As String Implements MOA.MOA06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA06
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

        Friend Property MOA07 As String Implements MOA.MOA07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element127
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property MOA08 As Decimal? Implements MOA.MOA08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA08
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

        Friend Property MOA09 As Decimal? Implements MOA.MOA09, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.MOA.MOA09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.MOA.MOA09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.MOA.MOA09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.MOA.MOA09
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As MOA
            Dim rval As New MOA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .MOA01 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .MOA02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .MOA03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .MOA04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .MOA05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .MOA06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .MOA07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .MOA08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .MOA09 = source.ToFloatValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Medicare Outpatient Adjudication</summary>
    '''<remarks>To convey claim-level data related to the adjudication of Medicare claims not related to an inpatient setting</remarks>
    Public Interface MOA
        Inherits ISegment

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>MOA01 is the reimbursement rate.</remarks>
        Property MOA01 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MOA02 is the claim Health Care Financing Administration Common Procedural Coding System (HCPCS) payable amount.</remarks>
        Property MOA02 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>MOA03 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MOA03 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MOA04 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MOA04 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MOA05 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MOA05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MOA06 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MOA06 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>MOA07 is the Claim Payment Remark Code. See Code Source 411.</remarks>
        Property MOA07 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>MOA08 is the End Stage Renal Disease (ESRD) payment amount.</remarks>
        Property MOA08 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>MOA09 is the professional component amount billed but not payable.</remarks>
        Property MOA09 As Decimal?

    End Interface
End NameSpace