Namespace Segments
    '''<summary>Enteral or Parenteral Therapy Certification</summary>
    '''<remarks>To supply information regarding certification of medical necessity for enteral or parenteral nutrition therapy</remarks>
    Partial Friend Class CR4_Obj
        Inherits Segment
        Implements CR4
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRulePaired({8, 9}),
                                                 New SyntaxRulePaired({10, 11}),
                                                 New SyntaxRulePaired({12, 13}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("CR4")
            Elements.AddRange({CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1322),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1344),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element65),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1346),
                                      CType(Nothing, DataElements.Element1347),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR401 As String Implements CR4.CR401
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

        Friend Property CR402 As String Implements CR4.CR402
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1322).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1322
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1322).Value = value
                End If
            End Set
        End Property

        Friend Property CR403 As String Implements CR4.CR403
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element355
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR404 As Decimal? Implements CR4.CR404
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element380
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR405 As String Implements CR4.CR405
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element355
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR406 As Decimal? Implements CR4.CR406
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element380
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR407 As String Implements CR4.CR407
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1344).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1344
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1344).Value = value
                End If
            End Set
        End Property

        Friend Property CR408 As String Implements CR4.CR408
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element355
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR409 As Decimal? Implements CR4.CR409
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

        Friend Property CR410 As String Implements CR4.CR410
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element355
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR411 As Decimal? Implements CR4.CR411
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element65).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element65
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element65).Value = value
                End If
            End Set
        End Property

        Friend Property CR412 As String Implements CR4.CR412
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element355
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR413 As Decimal? Implements CR4.CR413
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element81
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property CR414 As Decimal? Implements CR4.CR414
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element380
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR415 As String Implements CR4.CR415
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element352
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR416 As String Implements CR4.CR416
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element1346).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element1346
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element1346).Value = value
                End If
            End Set
        End Property

        Friend Property CR417 As String Implements CR4.CR417
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1347).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1347
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1347).Value = value
                End If
            End Set
        End Property

        Friend Property CR418 As Decimal? Implements CR4.CR418
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element380
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR419 As Decimal? Implements CR4.CR419
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element380
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR420 As String Implements CR4.CR420
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element352
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR421 As Decimal? Implements CR4.CR421
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element380
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR422 As Decimal? Implements CR4.CR422
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element954
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property CR423 As Decimal? Implements CR4.CR423
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element380
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR424 As Decimal? Implements CR4.CR424
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.Element380
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR425 As Decimal? Implements CR4.CR425
            Get
                Return If(Elements(24) IsNot Nothing, CType(Elements(24), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(24) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(24) = New DataElements.Element954
                End If

                If Elements(24) IsNot Nothing Then
                    CType(Elements(24), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property CR426 As Decimal? Implements CR4.CR426
            Get
                Return If(Elements(25) IsNot Nothing, CType(Elements(25), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(25) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(25) = New DataElements.Element380
                End If

                If Elements(25) IsNot Nothing Then
                    CType(Elements(25), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR427 As Decimal? Implements CR4.CR427
            Get
                Return If(Elements(26) IsNot Nothing, CType(Elements(26), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(26) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(26) = New DataElements.Element954
                End If

                If Elements(26) IsNot Nothing Then
                    CType(Elements(26), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property CR428 As Decimal? Implements CR4.CR428
            Get
                Return If(Elements(27) IsNot Nothing, CType(Elements(27), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(27) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(27) = New DataElements.Element380
                End If

                If Elements(27) IsNot Nothing Then
                    CType(Elements(27), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR429 As String Implements CR4.CR429
            Get
                Return If(Elements(28) IsNot Nothing, CType(Elements(28), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(28) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(28) = New DataElements.Element352
                End If

                If Elements(28) IsNot Nothing Then
                    CType(Elements(28), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR4
            Dim rval As New CR4_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR401 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR402 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR403 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR404 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR405 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR406 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR407 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR408 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR409 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CR410 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CR411 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CR412 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CR413 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CR414 = source.ToFloatValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CR415 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CR416 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CR417 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CR418 = source.ToFloatValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .CR419 = source.ToFloatValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .CR420 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .CR421 = source.ToFloatValue(20)
                End If
                If source.Elements.Count > 21 Then
                    .CR422 = source.ToFloatValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .CR423 = source.ToFloatValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .CR424 = source.ToFloatValue(23)
                End If
                If source.Elements.Count > 24 Then
                    .CR425 = source.ToFloatValue(24)
                End If
                If source.Elements.Count > 25 Then
                    .CR426 = source.ToFloatValue(25)
                End If
                If source.Elements.Count > 26 Then
                    .CR427 = source.ToFloatValue(26)
                End If
                If source.Elements.Count > 27 Then
                    .CR428 = source.ToFloatValue(27)
                End If
                If source.Elements.Count > 28 Then
                    .CR429 = source.ToStringValue(28)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Enteral or Parenteral Therapy Certification</summary>
    '''<remarks>To supply information regarding certification of medical necessity for enteral or parenteral nutrition therapy</remarks>
    Public Interface CR4
        Inherits ISegment

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR401 is enteral or parenteral indicator. A "Y" value indicates enteral; an "N" value indicates parenteral.</remarks>
        Property CR401 As String

        '''<summary>Certification Type Code</summary>
        '''<remarks></remarks>
        Property CR402 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR403 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR404 is the estimated duration of therapy.</remarks>
        Property CR404 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR405 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR406 is the time period covered by this certification.</remarks>
        Property CR406 As Decimal?

        '''<summary>Non-Visit Code</summary>
        '''<remarks></remarks>
        Property CR407 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR408 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR409 is the age of the patient.</remarks>
        Property CR409 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR410 As String

        '''<summary>Height</summary>
        '''<remarks>CR411 is the height of the patient.</remarks>
        Property CR411 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR412 As String

        '''<summary>Weight</summary>
        '''<remarks>CR413 is the weight of the patient.</remarks>
        Property CR413 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR414 is the number of times the patient is fed per week for parenteral claims or the number of times the patient is fed per day for enteral claims.</remarks>
        Property CR414 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>CR415 is the product name.</remarks>
        Property CR415 As String

        '''<summary>Nutrient Administration Method Code</summary>
        '''<remarks></remarks>
        Property CR416 As String

        '''<summary>Nutrient Administration Technique Code</summary>
        '''<remarks></remarks>
        Property CR417 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR418 is the total number of calories per day of all nutrients prescribed.</remarks>
        Property CR418 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR419 is the total number of calories per day prescribed for this product.</remarks>
        Property CR419 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>CR420 is the amino acid name.</remarks>
        Property CR420 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR421 is the number of milliliters of amino acid solution used in the prescription per day.</remarks>
        Property CR421 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>CR422 is the percentage of concentration of amino acid used in the prescription.</remarks>
        Property CR422 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR423 is the number of grams of amino acid used per day.</remarks>
        Property CR423 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR424 is the number of milliliters of dextrose solution used in the prescription per day.</remarks>
        Property CR424 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>CR425 is the percentage of concentration of dextrose used in the prescription.</remarks>
        Property CR425 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR426 is the number of milliliters of lipids used in the prescription.</remarks>
        Property CR426 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>CR427 is the percentage of concentration of lipids used in the prescription.</remarks>
        Property CR427 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR428 is the number of times per week lipids are used in the prescription.</remarks>
        Property CR428 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>CR429 is the special circumstances or medical justification.</remarks>
        Property CR429 As String

    End Interface
End NameSpace