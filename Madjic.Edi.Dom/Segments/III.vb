Namespace Segments
    '''<summary>Information</summary>
    '''<remarks>To report information</remarks>
    Partial Friend Class III_Obj
        Inherits Segment
        Implements III,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2115C.III,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2115D.III
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRuleListConditional(3, {4, 5})}

        Public Sub New()
            MyBase.New("III")
            Elements.AddRange({CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Element1136),
                                      CType(Nothing, DataElements.Element933),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element752),
                                      CType(Nothing, DataElements.Element752),
                                      CType(Nothing, DataElements.Element752)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property III01 As String Implements III.III01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III.III01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III.III01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115C.III.III01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115D.III.III01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1270
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property III02 As String Implements III.III02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III.III02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III.III02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115C.III.III02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115D.III.III02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1271
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property III03 As String Implements III.III03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115C.III.III03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115D.III.III03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1136).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1136
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1136).Value = value
                End If
            End Set
        End Property

        Friend Property III04 As String Implements III.III04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115C.III.III04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2115D.III.III04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element933).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element933
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element933).Value = value
                End If
            End Set
        End Property

        Friend Property III05 As Decimal? Implements III.III05
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

        Friend Property III06 As DataElements.Composite.C001 Implements III.III06
            Get
                Return CType(Elements(5), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(5) = value
            End Set
        End Property

        Friend Property III07 As String Implements III.III07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element752).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element752
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element752).Value = value
                End If
            End Set
        End Property

        Friend Property III08 As String Implements III.III08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element752).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element752
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element752).Value = value
                End If
            End Set
        End Property

        Friend Property III09 As String Implements III.III09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element752).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element752
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element752).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As III
            Dim rval As New III_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .III01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .III02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .III03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .III04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .III05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .Elements(5) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(5), reader)
                End If
                If source.Elements.Count > 6 Then
                    .III07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .III08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .III09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Information</summary>
    '''<remarks>To report information</remarks>
    Public Interface III
        Inherits ISegment

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property III01 As String

        '''<summary>Industry Code</summary>
        '''<remarks></remarks>
        Property III02 As String

        '''<summary>Code Category</summary>
        '''<remarks>III03 is used to categorize III04.</remarks>
        Property III03 As String

        '''<summary>Free-form Message Text</summary>
        '''<remarks></remarks>
        Property III04 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property III05 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property III06 As DataElements.Composite.C001

        '''<summary>Surface/Layer/Position Code</summary>
        '''<remarks></remarks>
        Property III07 As String

        '''<summary>Surface/Layer/Position Code</summary>
        '''<remarks></remarks>
        Property III08 As String

        '''<summary>Surface/Layer/Position Code</summary>
        '''<remarks></remarks>
        Property III09 As String

    End Interface
End NameSpace