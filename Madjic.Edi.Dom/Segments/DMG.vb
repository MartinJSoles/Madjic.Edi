Namespace Segments
    '''<summary>Demographic Information</summary>
    '''<remarks>To supply demographic information</remarks>
    Partial Friend Class DMG_Obj
        Inherits Segment
        Implements DMG,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.DMG,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.DMG,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.DMG,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.DMG
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRulePaired({10, 11}),
                                                 New SyntaxRuleConditional(11, {5})}

        Public Sub New()
            MyBase.New("DMG")
            Elements.AddRange({CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element1068),
                                      CType(Nothing, DataElements.Element1067),
                                      New RepeatingCompositeElementList(Of DataElements.Composite.C056_Obj)(10, Function() New DataElements.Composite.C056_Obj),
                                      CType(Nothing, DataElements.Element1066),
                                      CType(Nothing, DataElements.Element26),
                                      CType(Nothing, DataElements.Element659),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DMG01 As String Implements DMG.DMG01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG.DMG01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG.DMG01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.DMG.DMG01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.DMG.DMG01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG.DMG01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG.DMG01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG.DMG01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG.DMG01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG.DMG01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG.DMG01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG.DMG01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG.DMG01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.DMG.DMG01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.DMG.DMG01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1250
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property DMG02 As String Implements DMG.DMG02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG.DMG02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG.DMG02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.DMG.DMG02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.DMG.DMG02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG.DMG02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG.DMG02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG.DMG02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG.DMG02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG.DMG02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG.DMG02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG.DMG02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG.DMG02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.DMG.DMG02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.DMG.DMG02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1251
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property DMG03 As String Implements DMG.DMG03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG.DMG03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG.DMG03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.DMG.DMG03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.DMG.DMG03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.DMG.DMG03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.DMG.DMG03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.DMG.DMG03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.DMG.DMG03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.DMG.DMG03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.DMG.DMG03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.DMG.DMG03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.DMG.DMG03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.DMG.DMG03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.DMG.DMG03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1068).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1068
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1068).Value = value
                End If
            End Set
        End Property

        Friend Property DMG04 As String Implements DMG.DMG04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1067).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1067
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1067).Value = value
                End If
            End Set
        End Property


        Private _Facade As DataElements.Composite.RepeatingC056List
        Friend ReadOnly Property DMG05 As DataElements.Composite.RepeatingC056List Implements DMG.DMG05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG05
            Get
                If _Facade Is Nothing Then
                    _Facade = New DataElements.Composite.RepeatingC056List(CType(Elements(4), RepeatingCompositeElementList(Of DataElements.Composite.C056_Obj)))
                End If

                Return _Facade
            End Get
        End Property

        Friend Property DMG06 As String Implements DMG.DMG06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1066).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1066
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1066).Value = value
                End If
            End Set
        End Property

        Friend Property DMG07 As String Implements DMG.DMG07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element26
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Property DMG08 As String Implements DMG.DMG08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element659).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element659
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element659).Value = value
                End If
            End Set
        End Property

        Friend Property DMG09 As Decimal? Implements DMG.DMG09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element380
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property DMG10 As String Implements DMG.DMG10, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG10, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1270
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property DMG11 As String Implements DMG.DMG11, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.DMG.DMG11, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100B.DMG.DMG11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1271
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DMG
            Dim rval As New DMG_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DMG01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DMG02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DMG03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DMG04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    CType(.Elements(4), RepeatingCompositeElementList(Of DataElements.Composite.C056_Obj)).AddFromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .DMG06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .DMG07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .DMG08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .DMG09 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .DMG10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .DMG11 = source.ToStringValue(10)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Demographic Information</summary>
    '''<remarks>To supply demographic information</remarks>
    Public Interface DMG
        Inherits ISegment

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property DMG01 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>DMG02 is the date of birth.</remarks>
        Property DMG02 As String

        '''<summary>Gender Code</summary>
        '''<remarks></remarks>
        Property DMG03 As String

        '''<summary>Marital Status Code</summary>
        '''<remarks></remarks>
        Property DMG04 As String

        '''<summary>Composite Race or Ethnicity Information</summary>
        '''<remarks></remarks>
        ReadOnly Property DMG05 As DataElements.Composite.RepeatingC056List

        '''<summary>Citizenship Status Code</summary>
        '''<remarks></remarks>
        Property DMG06 As String

        '''<summary>Country Code</summary>
        '''<remarks>DMG07 is the country of citizenship.</remarks>
        Property DMG07 As String

        '''<summary>Basis of Verification Code</summary>
        '''<remarks></remarks>
        Property DMG08 As String

        '''<summary>Quantity</summary>
        '''<remarks>DMG09 is the age in years.</remarks>
        Property DMG09 As Decimal?

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property DMG10 As String

        '''<summary>Industry Code</summary>
        '''<remarks>DMG11 is used to specify how the information in DMG05, including repeats of C056, was collected.</remarks>
        Property DMG11 As String

    End Interface
End NameSpace