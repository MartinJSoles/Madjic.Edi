Namespace Segments
    '''<summary>Home Health Care Certification</summary>
    '''<remarks>To supply information related to the certification of a home health care patient</remarks>
    Partial Friend Class CR6_Obj
        Inherits Segment
        Implements CR6,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRulePaired({9, 10, 11}),
                                                 New SyntaxRulePaired({15, 16, 17}),
                                                 New SyntaxRuleAllRequired({1, 2, 7, 8})}

        Public Sub New()
            MyBase.New("CR6")
            Elements.AddRange({CType(Nothing, DataElements.Element923),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1322),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element1137),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element1384),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR601 As String Implements CR6.CR601, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR601, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR601
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element923).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element923
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element923).Value = value
                End If
            End Set
        End Property

        Friend Property CR602 As Date? Implements CR6.CR602, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR602, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR602
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element373
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR603 As String Implements CR6.CR603, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR603, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR603
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1250
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property CR604 As String Implements CR6.CR604, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR604, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR604
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1251
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property CR605 As Date? Implements CR6.CR605
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element373
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR606 As String Implements CR6.CR606
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1073
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CR607 As String Implements CR6.CR607, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR607, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR607
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

        Friend Property CR608 As String Implements CR6.CR608, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR608, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR6.CR608
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1322).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1322
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1322).Value = value
                End If
            End Set
        End Property

        Friend Property CR609 As Date? Implements CR6.CR609, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR609
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element373
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR610 As String Implements CR6.CR610, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR610
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element235
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property CR611 As String Implements CR6.CR611, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR611
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1137).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1137
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1137).Value = value
                End If
            End Set
        End Property

        Friend Property CR612 As Date? Implements CR6.CR612, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR612
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element373
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR613 As Date? Implements CR6.CR613, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR613
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element373
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR614 As Date? Implements CR6.CR614, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR614
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element373
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR615 As String Implements CR6.CR615, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR615
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1250
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property CR616 As String Implements CR6.CR616, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR616
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element1251
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property CR617 As String Implements CR6.CR617, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR6.CR617
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1384).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1384
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1384).Value = value
                End If
            End Set
        End Property

        Friend Property CR618 As Date? Implements CR6.CR618
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element373
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR619 As Date? Implements CR6.CR619
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element373
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR620 As Date? Implements CR6.CR620
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element373
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR621 As Date? Implements CR6.CR621
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element373
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR6
            Dim rval As New CR6_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR601 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR602 = source.ToDateValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR603 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR604 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR605 = source.ToDateValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR606 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR607 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR608 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR609 = source.ToDateValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CR610 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CR611 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CR612 = source.ToDateValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CR613 = source.ToDateValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CR614 = source.ToDateValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CR615 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CR616 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CR617 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CR618 = source.ToDateValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .CR619 = source.ToDateValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .CR620 = source.ToDateValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .CR621 = source.ToDateValue(20)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Home Health Care Certification</summary>
    '''<remarks>To supply information related to the certification of a home health care patient</remarks>
    Public Interface CR6
        Inherits ISegment

        '''<summary>Prognosis Code</summary>
        '''<remarks></remarks>
        Property CR601 As String

        '''<summary>Date</summary>
        '''<remarks>CR602 is the date covered home health services began.</remarks>
        Property CR602 As Date?

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property CR603 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>CR604 is the certification period covered by this plan of treatment.</remarks>
        Property CR604 As String

        '''<summary>Date</summary>
        '''<remarks>CR605 is the date of onset or exacerbation of the principal diagnosis.</remarks>
        Property CR605 As Date?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>A "Y" value indicates patient is receiving care in a 1861J1 (skilled nursing) facility. An "N" value indicates patient is not receiving care in a 1861J1 facility. A "U" value indicates it is unknown whether or not the patient is receiving care in a 1861J1 facility.</remarks>
        Property CR606 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR607 indicates if the patient is covered by Medicare. A "Y" value indicates the patient is covered by Medicare; an "N" value indicates patient is not covered by Medicare.</remarks>
        Property CR607 As String

        '''<summary>Certification Type Code</summary>
        '''<remarks></remarks>
        Property CR608 As String

        '''<summary>Date</summary>
        '''<remarks>CR609 is the date that the surgery identified in CR611 was performed.</remarks>
        Property CR609 As Date?

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks>CR610 qualifies CR611.</remarks>
        Property CR610 As String

        '''<summary>Medical Code Value</summary>
        '''<remarks>CR611 is the surgical procedure most relevant to the care being rendered.</remarks>
        Property CR611 As String

        '''<summary>Date</summary>
        '''<remarks>CR612 is the date the agency received the verbal orders from the physician for start of care.</remarks>
        Property CR612 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR613 is the date that the patient was last seen by the physician.</remarks>
        Property CR613 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR614 is the date of the home health agency's most recent contact with the physician.</remarks>
        Property CR614 As Date?

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property CR615 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>CR616 is the date range of the most recent inpatient stay.</remarks>
        Property CR616 As String

        '''<summary>Patient Location Code</summary>
        '''<remarks>CR617 indicates the type of facility from which the patient was most recently discharged.</remarks>
        Property CR617 As String

        '''<summary>Date</summary>
        '''<remarks>CR618 is the date of onset or exacerbation of the first secondary diagnosis.</remarks>
        Property CR618 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR619 is the date of onset or exacerbation of the second secondary diagnosis.</remarks>
        Property CR619 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR620 is the date of onset or exacerbation of the third secondary diagnosis.</remarks>
        Property CR620 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR621 is the date of onset or exacerbation of the fourth secondary diagnosis.</remarks>
        Property CR621 As Date?

    End Interface
End NameSpace