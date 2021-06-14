Namespace Segments
    '''<summary>Paperwork</summary>
    '''<remarks>To identify the type or transmission or both of paperwork or supporting information</remarks>
    Partial Friend Class PWK_Obj
        Inherits Segment
        Implements PWK,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK_1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.PWK,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.PWK
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PWK")
            Elements.AddRange({CType(Nothing, DataElements.Element755),
                                      CType(Nothing, DataElements.Element756),
                                      CType(Nothing, DataElements.Element757),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Composite.C002_Obj),
                                      CType(Nothing, DataElements.Element1525)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PWK01 As String Implements PWK.PWK01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK.PWK01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK.PWK01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK.PWK01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK.PWK01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK.PWK01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK.PWK01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK_1.PWK01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK.PWK01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.PWK.PWK01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.PWK.PWK01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element755).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element755
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element755).Value = value
                End If
            End Set
        End Property

        Friend Property PWK02 As String Implements PWK.PWK02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK.PWK02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK.PWK02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK.PWK02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK.PWK02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK.PWK02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK.PWK02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK_1.PWK02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK.PWK02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.PWK.PWK02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.PWK.PWK02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element756).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element756
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element756).Value = value
                End If
            End Set
        End Property

        Friend Property PWK03 As Decimal? Implements PWK.PWK03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element757).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element757
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element757).Value = value
                End If
            End Set
        End Property

        Friend Property PWK04 As String Implements PWK.PWK04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element98
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property PWK05 As String Implements PWK.PWK05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK.PWK05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK.PWK05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK.PWK05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK.PWK05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK.PWK05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK.PWK05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK.PWK05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.PWK.PWK05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.PWK.PWK05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element66
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property PWK06 As String Implements PWK.PWK06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK.PWK06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK.PWK06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK.PWK06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK.PWK06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.PWK.PWK06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PWK.PWK06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.PWK.PWK06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.PWK.PWK06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.PWK.PWK06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element67
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property PWK07 As String Implements PWK.PWK07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.PWK.PWK07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.PWK.PWK07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.PWK.PWK07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.PWK.PWK07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element352
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property PWK08 As DataElements.Composite.C002 Implements PWK.PWK08
            Get
                Return CType(Elements(7), DataElements.Composite.C002_Obj)
            End Get
            Set(value As DataElements.Composite.C002)
                Elements(7) = value
            End Set
        End Property

        Friend Property PWK09 As String Implements PWK.PWK09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1525).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1525
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1525).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PWK
            Dim rval As New PWK_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PWK01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PWK02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PWK03 = source.ToDecimalValue(2, 0)
                End If
                If source.Elements.Count > 3 Then
                    .PWK04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PWK05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PWK06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .PWK07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .Elements(7) = DataElements.Composite.C002_Obj.FromReader(source.ToStringValue(7), reader)
                End If
                If source.Elements.Count > 8 Then
                    .PWK09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Paperwork</summary>
    '''<remarks>To identify the type or transmission or both of paperwork or supporting information</remarks>
    Public Interface PWK
        Inherits ISegment

        '''<summary>Report Type Code</summary>
        '''<remarks></remarks>
        Property PWK01 As String

        '''<summary>Report Transmission Code</summary>
        '''<remarks></remarks>
        Property PWK02 As String

        '''<summary>Report Copies Needed</summary>
        '''<remarks></remarks>
        Property PWK03 As Decimal?

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property PWK04 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks>PWK05 and PWK06 may be used to identify the addressee by a code number.</remarks>
        Property PWK05 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property PWK06 As String

        '''<summary>Description</summary>
        '''<remarks>PWK07 may be used to indicate special information to be shown on the specified report.</remarks>
        Property PWK07 As String

        '''<summary>Actions Indicated</summary>
        '''<remarks>PWK08 may be used to indicate action pertaining to a report.</remarks>
        Property PWK08 As DataElements.Composite.C002

        '''<summary>Request Category Code</summary>
        '''<remarks></remarks>
        Property PWK09 As String

    End Interface
End NameSpace