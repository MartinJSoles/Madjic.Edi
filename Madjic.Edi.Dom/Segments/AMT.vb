Namespace Segments
    '''<summary>Monetary Amount Information</summary>
    '''<remarks>To indicate the total monetary amount</remarks>
    Partial Friend Class AMT_Obj
        Inherits Segment
        Implements AMT,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.AMT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_2,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT_1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.AMT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.AMT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_2,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.AMT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.AMT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.AMT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_2,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT_1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.AMT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("AMT")
            Elements.AddRange({CType(Nothing, DataElements.Element522),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element478)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AMT01 As String Implements AMT.AMT01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT.AMT01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1.AMT01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT.AMT01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT.AMT01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT.AMT01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.AMT.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_1.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_2.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT_1.AMT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.AMT.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.AMT.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_1.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_2.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.AMT.AMT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.AMT.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.AMT.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_1.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_2.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT_1.AMT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.AMT.AMT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element522).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element522
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element522).Value = value
                End If
            End Set
        End Property

        Friend Property AMT02 As Decimal? Implements AMT.AMT02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT.AMT02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1.AMT02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.AMT.AMT02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.AMT.AMT02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.AMT.AMT02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.AMT.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.AMT.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_1.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.AMT_2.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.AMT_1.AMT02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2430.AMT.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.AMT.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_1.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.AMT_2.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.AMT.AMT02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2430.AMT.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.AMT.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_1.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.AMT_2.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.AMT_1.AMT02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2430.AMT.AMT02
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

        Friend Property AMT03 As String Implements AMT.AMT03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element478).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element478
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element478).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AMT
            Dim rval As New AMT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AMT01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AMT02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .AMT03 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Monetary Amount Information</summary>
    '''<remarks>To indicate the total monetary amount</remarks>
    Public Interface AMT
        Inherits ISegment

        '''<summary>Amount Qualifier Code</summary>
        '''<remarks></remarks>
        Property AMT01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property AMT02 As Decimal?

        '''<summary>Credit/Debit Flag Code</summary>
        '''<remarks></remarks>
        Property AMT03 As String

    End Interface
End NameSpace