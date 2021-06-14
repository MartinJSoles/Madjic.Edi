Namespace Segments
    '''<summary>Note/Special Instruction</summary>
    '''<remarks>To transmit information in a free-form format, if necessary, for comment or special instruction</remarks>
    Partial Friend Class NTE_Obj
        Inherits Segment
        Implements NTE,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.NTE,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE_1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.NTE,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE_1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.NTE
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({2})}

        Public Sub New()
            MyBase.New("NTE")
            Elements.AddRange({CType(Nothing, DataElements.Element363),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property NTE01 As String Implements NTE.NTE01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.NTE.NTE01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE.NTE01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE_1.NTE01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.NTE.NTE01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE.NTE01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE_1.NTE01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.NTE.NTE01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element363).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element363
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element363).Value = value
                End If
            End Set
        End Property

        Friend Property NTE02 As String Implements NTE.NTE02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.NTE.NTE02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE.NTE02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.NTE_1.NTE02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.NTE.NTE02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE.NTE02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.NTE_1.NTE02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.NTE.NTE02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element352
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As NTE
            Dim rval As New NTE_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .NTE01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .NTE02 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Note/Special Instruction</summary>
    '''<remarks>To transmit information in a free-form format, if necessary, for comment or special instruction</remarks>
    Public Interface NTE
        Inherits ISegment

        '''<summary>Note Reference Code</summary>
        '''<remarks></remarks>
        Property NTE01 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property NTE02 As String

    End Interface
End NameSpace