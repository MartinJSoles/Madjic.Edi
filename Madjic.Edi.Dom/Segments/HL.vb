Namespace Segments
    '''<summary>Hierarchical Level</summary>
    '''<remarks>To identify dependencies among and the content of hierarchically related groups of data segments</remarks>
    Partial Friend Class HL_Obj
        Inherits Segment
        Implements HL,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.HL,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000B.HL,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.HL,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.HL,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.HL,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.HL,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.HL
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 3})}

        Public Sub New()
            MyBase.New("HL")
            Elements.AddRange({CType(Nothing, DataElements.Element628),
                                      CType(Nothing, DataElements.Element734),
                                      CType(Nothing, DataElements.Element735),
                                      CType(Nothing, DataElements.Element736)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HL01 As String Implements HL.HL01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL.HL01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL.HL01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL.HL01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL.HL01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.HL.HL01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000B.HL.HL01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.HL.HL01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.HL.HL01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL.HL01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL.HL01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL.HL01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL.HL01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL.HL01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL.HL01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL.HL01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL.HL01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL.HL01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL.HL01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL.HL01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL.HL01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL.HL01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.HL.HL01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.HL.HL01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.HL.HL01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element628).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element628
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element628).Value = value
                End If
            End Set
        End Property

        Friend Property HL02 As String Implements HL.HL02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL.HL02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL.HL02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL.HL02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000B.HL.HL02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.HL.HL02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.HL.HL02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL.HL02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL.HL02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL.HL02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL.HL02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL.HL02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL.HL02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL.HL02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL.HL02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL.HL02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL.HL02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL.HL02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL.HL02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL.HL02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL.HL02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL.HL02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL.HL02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL.HL02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL.HL02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.HL.HL02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.HL.HL02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element734).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element734
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element734).Value = value
                End If
            End Set
        End Property

        Friend Property HL03 As String Implements HL.HL03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL.HL03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL.HL03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL.HL03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL.HL03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.HL.HL03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000B.HL.HL03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.HL.HL03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.HL.HL03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL.HL03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL.HL03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL.HL03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL.HL03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000E.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL.HL03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL.HL03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL.HL03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL.HL03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL.HL03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL.HL03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL.HL03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL.HL03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL.HL03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.HL.HL03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.HL.HL03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.HL.HL03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element735).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element735
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element735).Value = value
                End If
            End Set
        End Property

        Friend Property HL04 As String Implements HL.HL04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL.HL04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL.HL04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL.HL04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL.HL04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.HL.HL04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000B.HL.HL04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.HL.HL04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.HL.HL04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000A.HL.HL04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000B.HL.HL04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000C.HL.HL04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2000D.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000A.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000B.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000C.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000D.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HL.HL04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000B.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000C.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000D.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HL.HL04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HL.HL04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.HL.HL04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.HL.HL04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.HL.HL04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.HL.HL04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000B.HL.HL04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.HL.HL04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.HL.HL04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000B.HL.HL04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.HL.HL04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element736).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element736
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element736).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HL
            Dim rval As New HL_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HL01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HL02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HL03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HL04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Hierarchical Level</summary>
    '''<remarks>To identify dependencies among and the content of hierarchically related groups of data segments</remarks>
    Public Interface HL
        Inherits ISegment

        '''<summary>Hierarchical ID Number</summary>
        '''<remarks>HL01 shall contain a unique alphanumeric number for each occurrence of the HL segment in the transaction set. For example, HL01 could be used to indicate the number of occurrences of the HL segment, in which case the value of HL01 would be "1" for the initial HL segment and would be incremented by one in each subsequent HL segment within the transaction.</remarks>
        Property HL01 As String

        '''<summary>Hierarchical Parent ID Number</summary>
        '''<remarks>HL02 identifies the hierarchical ID number of the HL segment to which the current HL segment is subordinate.</remarks>
        Property HL02 As String

        '''<summary>Hierarchical Level Code</summary>
        '''<remarks>HL03 indicates the context of the series of segments following the current HL segment up to the next occurrence of an HL segment in the transaction. For example, HL03 is used to indicate that subsequent segments in the HL loop form a logical grouping of data referring to shipment, order, or item-level information.</remarks>
        Property HL03 As String

        '''<summary>Hierarchical Child Code</summary>
        '''<remarks>HL04 indicates whether or not there are subordinate (or child) HL segments related to the current HL segment.</remarks>
        Property HL04 As String

    End Interface
End NameSpace