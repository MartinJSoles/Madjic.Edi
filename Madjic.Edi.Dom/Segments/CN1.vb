Namespace Segments
    '''<summary>Contract Information</summary>
    '''<remarks>To specify basic data about the contract or contract line item</remarks>
    Partial Friend Class CN1_Obj
        Inherits Segment
        Implements CN1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("CN1")
            Elements.AddRange({CType(Nothing, DataElements.Element1166),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element332),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element338),
                                      CType(Nothing, DataElements.Element799)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CN101 As String Implements CN1.CN101, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN101, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN101, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN101, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN101, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1166).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1166
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1166).Value = value
                End If
            End Set
        End Property

        Friend Property CN102 As Decimal? Implements CN1.CN102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN102, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN102, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN102, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN102
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

        Friend Property CN103 As Decimal? Implements CN1.CN103, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN103, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN103, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN103, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN103, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element332).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element332
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element332).Value = value
                End If
            End Set
        End Property

        Friend Property CN104 As String Implements CN1.CN104, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN104, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN104, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN104, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN104, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN104
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

        Friend Property CN105 As Decimal? Implements CN1.CN105, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN105, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN105, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN105, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN105, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element338).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element338
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element338).Value = value
                End If
            End Set
        End Property

        Friend Property CN106 As String Implements CN1.CN106, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CN1.CN106, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CN1.CN106, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CN1.CN106, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.CN1.CN106, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CN1.CN106
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element799).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element799
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element799).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CN1
            Dim rval As New CN1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CN101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CN102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CN103 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CN104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CN105 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CN106 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Contract Information</summary>
    '''<remarks>To specify basic data about the contract or contract line item</remarks>
    Public Interface CN1
        Inherits ISegment

        '''<summary>Contract Type Code</summary>
        '''<remarks></remarks>
        Property CN101 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CN102 is the contract amount.</remarks>
        Property CN102 As Decimal?

        '''<summary>Percent, Decimal Format</summary>
        '''<remarks>CN103 is the allowance or charge percent.</remarks>
        Property CN103 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>CN104 is the contract code.</remarks>
        Property CN104 As String

        '''<summary>Terms Discount Percent</summary>
        '''<remarks></remarks>
        Property CN105 As Decimal?

        '''<summary>Version Identifier</summary>
        '''<remarks>CN106 is an additional identifying number for the contract.</remarks>
        Property CN106 As String

    End Interface
End NameSpace