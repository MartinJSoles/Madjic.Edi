Namespace Segments
    '''<summary>Party Identification</summary>
    '''<remarks>To identify a party by type of organization, name, and code</remarks>
    Partial Friend Class N1_Obj
        Inherits Segment
        Implements N1,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({2, 3}),
                                                 New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("N1")
            Elements.AddRange({CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element706),
                                      CType(Nothing, DataElements.Element98)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property N101 As String Implements N1.N101, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1.N101, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1.N101, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1.N101, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1.N101, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1.N101, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1.N101, Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1.N101, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1.N101, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1.N101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element98
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property N102 As String Implements N1.N102, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1.N102, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1.N102, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1.N102, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1.N102, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1.N102, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1.N102, Transactions.Transaction834.Transaction834_A1.Segments.Loop2750.N1.N102, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1.N102, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1.N102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element93
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property N103 As String Implements N1.N103, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1.N103, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1.N103, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1.N103, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1.N103, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1.N103, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1.N103, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1.N103, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1.N103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element66
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property N104 As String Implements N1.N104, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N1.N104, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N1.N104, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N1.N104, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000A.N1.N104, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000B.N1.N104, Transactions.Transaction834.Transaction834_A1.Segments.Loop1000C.N1.N104, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N1.N104, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N1.N104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element67
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property N105 As String Implements N1.N105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element706).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element706
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element706).Value = value
                End If
            End Set
        End Property

        Friend Property N106 As String Implements N1.N106
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element98
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As N1
            Dim rval As New N1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .N101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .N102 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .N103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .N104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .N105 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .N106 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Party Identification</summary>
    '''<remarks>To identify a party by type of organization, name, and code</remarks>
    Public Interface N1
        Inherits ISegment

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property N101 As String

        '''<summary>Name</summary>
        '''<remarks></remarks>
        Property N102 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property N103 As String

        '''<summary>Identification Code</summary>
        '''<remarks>This segment, used alone, provides the most efficient method of providing organizational identification. To obtain this efficiency the "ID Code" (N104) must provide a key to the table maintained by the transaction processing party.</remarks>
        Property N104 As String

        '''<summary>Entity Relationship Code</summary>
        '''<remarks>N105 and N106 further define the type of entity in N101.</remarks>
        Property N105 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property N106 As String

    End Interface
End NameSpace