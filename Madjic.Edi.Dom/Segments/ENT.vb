Namespace Segments
    '''<summary>Entity</summary>
    '''<remarks>To designate the entities which are parties to a transaction and specify a reference meaningful to those entities</remarks>
    Partial Friend Class ENT_Obj
        Inherits Segment
        Implements ENT,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3, 4}),
                                                 New SyntaxRulePaired({5, 6, 7}),
                                                 New SyntaxRulePaired({8, 9})}

        Public Sub New()
            MyBase.New("ENT")
            Elements.AddRange({CType(Nothing, DataElements.Element554),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ENT01 As Decimal? Implements ENT.ENT01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT.ENT01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT.ENT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element554).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element554
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element554).Value = value
                End If
            End Set
        End Property

        Friend Property ENT02 As String Implements ENT.ENT02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT.ENT02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT.ENT02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element98
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property ENT03 As String Implements ENT.ENT03, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT.ENT03, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT.ENT03
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

        Friend Property ENT04 As String Implements ENT.ENT04, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000A.ENT.ENT04, Transactions.Transaction820.Transaction820_A1.Segments.Loop2000B.ENT.ENT04
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

        Friend Property ENT05 As String Implements ENT.ENT05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element98
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property ENT06 As String Implements ENT.ENT06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element66
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property ENT07 As String Implements ENT.ENT07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element67
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property ENT08 As String Implements ENT.ENT08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element128
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property ENT09 As String Implements ENT.ENT09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element127
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ENT
            Dim rval As New ENT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ENT01 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .ENT02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ENT03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .ENT04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .ENT05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .ENT06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .ENT07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .ENT08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .ENT09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Entity</summary>
    '''<remarks>To designate the entities which are parties to a transaction and specify a reference meaningful to those entities</remarks>
    Public Interface ENT
        Inherits ISegment

        '''<summary>Assigned Number</summary>
        '''<remarks></remarks>
        Property ENT01 As Decimal?

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property ENT02 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property ENT03 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property ENT04 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property ENT05 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property ENT06 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property ENT07 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property ENT08 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property ENT09 As String

    End Interface
End NameSpace