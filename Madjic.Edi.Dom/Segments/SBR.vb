Namespace Segments
    '''<summary>Subscriber Information</summary>
    '''<remarks>To record information specific to the primary insured and the insurance carrier for that insured</remarks>
    Partial Friend Class SBR_Obj
        Inherits Segment
        Implements SBR,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SBR")
            Elements.AddRange({CType(Nothing, DataElements.Element1138),
                                      CType(Nothing, DataElements.Element1069),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element1336),
                                      CType(Nothing, DataElements.Element1143),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element1032)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SBR01 As String Implements SBR.SBR01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR.SBR01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR.SBR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1138).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1138
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1138).Value = value
                End If
            End Set
        End Property

        Friend Property SBR02 As String Implements SBR.SBR02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR.SBR02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR.SBR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1069).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1069
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1069).Value = value
                End If
            End Set
        End Property

        Friend Property SBR03 As String Implements SBR.SBR03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR.SBR03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR.SBR03
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

        Friend Property SBR04 As String Implements SBR.SBR04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR.SBR04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR.SBR04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element93
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property SBR05 As String Implements SBR.SBR05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1336).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1336
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1336).Value = value
                End If
            End Set
        End Property

        Friend Property SBR06 As String Implements SBR.SBR06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1143).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1143
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1143).Value = value
                End If
            End Set
        End Property

        Friend Property SBR07 As String Implements SBR.SBR07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1073
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SBR08 As String Implements SBR.SBR08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element584).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element584
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element584).Value = value
                End If
            End Set
        End Property

        Friend Property SBR09 As String Implements SBR.SBR09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.SBR.SBR09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.SBR.SBR09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.SBR.SBR09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.SBR.SBR09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.SBR.SBR09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.SBR.SBR09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1032).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1032
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1032).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SBR
            Dim rval As New SBR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SBR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SBR02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SBR03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SBR04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SBR05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SBR06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SBR07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SBR08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SBR09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Subscriber Information</summary>
    '''<remarks>To record information specific to the primary insured and the insurance carrier for that insured</remarks>
    Public Interface SBR
        Inherits ISegment

        '''<summary>Payer Responsibility Sequence Number Code</summary>
        '''<remarks></remarks>
        Property SBR01 As String

        '''<summary>Individual Relationship Code</summary>
        '''<remarks>SBR02 specifies the relationship to the person insured.</remarks>
        Property SBR02 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>SBR03 is policy or group number.</remarks>
        Property SBR03 As String

        '''<summary>Name</summary>
        '''<remarks>SBR04 is plan name.</remarks>
        Property SBR04 As String

        '''<summary>Insurance Type Code</summary>
        '''<remarks></remarks>
        Property SBR05 As String

        '''<summary>Coordination of Benefits Code</summary>
        '''<remarks></remarks>
        Property SBR06 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SBR07 is destination payer code. A "Y" value indicates the payer is the destination payer; an "N" value indicates the payer is not the destination payer.</remarks>
        Property SBR07 As String

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property SBR08 As String

        '''<summary>Claim Filing Indicator Code</summary>
        '''<remarks></remarks>
        Property SBR09 As String

    End Interface
End NameSpace