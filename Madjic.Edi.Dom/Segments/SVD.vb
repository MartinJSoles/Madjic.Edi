Namespace Segments
    '''<summary>Service Line Adjudication</summary>
    '''<remarks>To convey service line adjudication information for coordination of benefits between the initial payers of a health care claim and all subsequent payers</remarks>
    Partial Friend Class SVD_Obj
        Inherits Segment
        Implements SVD,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("SVD")
            Elements.AddRange({CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element554)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SVD01 As String Implements SVD.SVD01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD.SVD01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD.SVD01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element67
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property SVD02 As Decimal? Implements SVD.SVD02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD.SVD02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD.SVD02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD02
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

        Friend Property SVD03 As DataElements.Composite.C003 Implements SVD.SVD03
            Get
                Return CType(Elements(2), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(2) = value
            End Set
        End Property

        Private Property SVD03_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.SVD_03.C003 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD.SVD03
            Get
                Return CType(SVD03, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.SVD_03.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2430.SVD.SVD_03.C003)
                SVD03 = value
            End Set
        End Property

        Private Property SVD03_IFace_1 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.C003 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD.SVD03
            Get
                Return CType(SVD03, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2430.SVD.SVD_03.C003)
                SVD03 = value
            End Set
        End Property

        Private Property SVD03_IFace_2 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.SVD_03.C003 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD03
            Get
                Return CType(SVD03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.SVD_03.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2430.SVD.SVD_03.C003)
                SVD03 = value
            End Set
        End Property

        Friend Property SVD04 As String Implements SVD.SVD04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element234
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SVD05 As Decimal? Implements SVD.SVD05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD.SVD05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD.SVD05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD05
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

        Friend Property SVD06 As Decimal? Implements SVD.SVD06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.SVD.SVD06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.SVD.SVD06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.SVD.SVD06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element554).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element554
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element554).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SVD
            Dim rval As New SVD_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SVD01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SVD02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(2), reader)
                End If
                If source.Elements.Count > 3 Then
                    .SVD04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SVD05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SVD06 = source.ToDecimalValue(5, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Service Line Adjudication</summary>
    '''<remarks>To convey service line adjudication information for coordination of benefits between the initial payers of a health care claim and all subsequent payers</remarks>
    Public Interface SVD
        Inherits ISegment

        '''<summary>Identification Code</summary>
        '''<remarks>SVD01 is the payer identification code.</remarks>
        Property SVD01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>SVD02 is the amount paid for this service line.</remarks>
        Property SVD02 As Decimal?

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks>SVD03 represents the medical procedure code upon which adjudication of this service line was based. This may be different than the submitted medical procedure code.</remarks>
        Property SVD03 As DataElements.Composite.C003

        '''<summary>Product/Service ID</summary>
        '''<remarks>SVD04 is the revenue code.</remarks>
        Property SVD04 As String

        '''<summary>Quantity</summary>
        '''<remarks>SVD05 is the paid units of service.</remarks>
        Property SVD05 As Decimal?

        '''<summary>Assigned Number</summary>
        '''<remarks>SVD06 is only used for bundling of service lines. It references the LX Assigned Number of the service line into which this service line was bundled.</remarks>
        Property SVD06 As Decimal?

    End Interface
End NameSpace