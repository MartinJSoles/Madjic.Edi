Namespace Segments
    '''<summary>Insured Benefit</summary>
    '''<remarks>To provide benefit information on insured entities</remarks>
    Partial Friend Class INS_Obj
        Inherits Segment
        Implements INS,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({11, 12}),
                                                 New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("INS")
            Elements.AddRange({CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1069),
                                      CType(Nothing, DataElements.Element875),
                                      CType(Nothing, DataElements.Element1203),
                                      CType(Nothing, DataElements.Element1216),
                                      CType(Nothing, DataElements.Composite.C052_Obj),
                                      CType(Nothing, DataElements.Element1219),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element1220),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element1165),
                                      CType(Nothing, DataElements.Element19),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Element26),
                                      CType(Nothing, DataElements.Element1470)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property INS01 As String Implements INS.INS01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS.INS01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS.INS01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS.INS01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS.INS01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS.INS01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS.INS01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS.INS01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS.INS01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1073
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property INS02 As String Implements INS.INS02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS.INS02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS.INS02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS.INS02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS.INS02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS.INS02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS.INS02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS.INS02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS.INS02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS02
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

        Friend Property INS03 As String Implements INS.INS03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS.INS03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS.INS03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element875).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element875
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element875).Value = value
                End If
            End Set
        End Property

        Friend Property INS04 As String Implements INS.INS04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS.INS04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS.INS04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1203).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1203
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1203).Value = value
                End If
            End Set
        End Property

        Friend Property INS05 As String Implements INS.INS05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1216).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1216
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1216).Value = value
                End If
            End Set
        End Property

        Friend Property INS06 As DataElements.Composite.C052 Implements INS.INS06
            Get
                Return CType(Elements(5), DataElements.Composite.C052_Obj)
            End Get
            Set(value As DataElements.Composite.C052)
                Elements(5) = value
            End Set
        End Property

        Private Property INS06_IFace As Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052 Implements Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS06
            Get
                Return CType(INS06, Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052)
            End Get
            Set(value As Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.C052)
                INS06 = value
            End Set
        End Property

        Friend Property INS07 As String Implements INS.INS07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1219).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1219
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1219).Value = value
                End If
            End Set
        End Property

        Friend Property INS08 As String Implements INS.INS08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.INS.INS08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.INS.INS08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS08
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

        Friend Property INS09 As String Implements INS.INS09, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1220).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1220
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1220).Value = value
                End If
            End Set
        End Property

        Friend Property INS10 As String Implements INS.INS10, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1073
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property INS11 As String Implements INS.INS11, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1250
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property INS12 As String Implements INS.INS12, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1251
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property INS13 As String Implements INS.INS13, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element1165).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element1165
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element1165).Value = value
                End If
            End Set
        End Property

        Friend Property INS14 As String Implements INS.INS14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element19).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element19
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element19).Value = value
                End If
            End Set
        End Property

        Friend Property INS15 As String Implements INS.INS15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element156
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property INS16 As String Implements INS.INS16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element26
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Property INS17 As Decimal? Implements INS.INS17, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS.INS17, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS.INS17, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.INS.INS17, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.INS.INS17, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.INS.INS17, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.INS.INS17, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.INS.INS17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1470
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As INS
            Dim rval As New INS_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .INS01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .INS02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .INS03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .INS04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .INS05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .Elements(5) = DataElements.Composite.C052_Obj.FromReader(source.ToStringValue(5), reader)
                End If
                If source.Elements.Count > 6 Then
                    .INS07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .INS08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .INS09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .INS10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .INS11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .INS12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .INS13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .INS14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .INS15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .INS16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .INS17 = source.ToDecimalValue(16, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Insured Benefit</summary>
    '''<remarks>To provide benefit information on insured entities</remarks>
    Public Interface INS
        Inherits ISegment

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>INS01 indicates status of the insured. A "Y" value indicates the insured is a subscriber: an "N" value indicates the insured is a dependent.</remarks>
        Property INS01 As String

        '''<summary>Individual Relationship Code</summary>
        '''<remarks></remarks>
        Property INS02 As String

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property INS03 As String

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property INS04 As String

        '''<summary>Benefit Status Code</summary>
        '''<remarks></remarks>
        Property INS05 As String

        '''<summary>Medicare Status Code</summary>
        '''<remarks></remarks>
        Property INS06 As DataElements.Composite.C052

        '''<summary>Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying</summary>
        '''<remarks></remarks>
        Property INS07 As String

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property INS08 As String

        '''<summary>Student Status Code</summary>
        '''<remarks></remarks>
        Property INS09 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>INS10 is the handicapped status indicator. A "Y" value indicates an individual is handicapped; an "N" value indicates an individual is not handicapped.</remarks>
        Property INS10 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property INS11 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>INS12 is the date of death.</remarks>
        Property INS12 As String

        '''<summary>Confidentiality Code</summary>
        '''<remarks></remarks>
        Property INS13 As String

        '''<summary>City Name</summary>
        '''<remarks>INS14, INS15, and INS16 identify where the employee works.</remarks>
        Property INS14 As String

        '''<summary>State or Province Code</summary>
        '''<remarks></remarks>
        Property INS15 As String

        '''<summary>Country Code</summary>
        '''<remarks></remarks>
        Property INS16 As String

        '''<summary>Number</summary>
        '''<remarks>INS17 is the number assigned to each family member born with the same birth date. This number identifies birth sequence for multiple births allowing proper tracking and response of benefits for each dependent (i.e., twins, triplets, etc.).</remarks>
        Property INS17 As Decimal?

    End Interface
End NameSpace