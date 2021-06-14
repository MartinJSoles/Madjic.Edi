Namespace Segments
    '''<summary>Chiropractic Certification</summary>
    '''<remarks>To supply information related to the chiropractic service rendered to a patient</remarks>
    Partial Friend Class CR2_Obj
        Inherits Segment
        Implements CR2,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRuleConditional(4, {3}),
                                                 New SyntaxRulePaired({5, 6})}

        Public Sub New()
            MyBase.New("CR2")
            Elements.AddRange({CType(Nothing, DataElements.Element609),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1367),
                                      CType(Nothing, DataElements.Element1367),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1342),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR201 As Decimal? Implements CR2.CR201, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR201, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2.CR201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element609).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element609
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element609).Value = value
                End If
            End Set
        End Property

        Friend Property CR202 As Decimal? Implements CR2.CR202, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR202, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2.CR202
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element380
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR203 As String Implements CR2.CR203, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR203, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2.CR203
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1367).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1367
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1367).Value = value
                End If
            End Set
        End Property

        Friend Property CR204 As String Implements CR2.CR204, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR204, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR2.CR204
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1367).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1367
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1367).Value = value
                End If
            End Set
        End Property

        Friend Property CR205 As String Implements CR2.CR205
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

        Friend Property CR206 As Decimal? Implements CR2.CR206
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

        Friend Property CR207 As Decimal? Implements CR2.CR207
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element380
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR208 As String Implements CR2.CR208, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR208, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR2.CR208
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1342).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1342
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1342).Value = value
                End If
            End Set
        End Property

        Friend Property CR209 As String Implements CR2.CR209, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR209
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1073
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CR210 As String Implements CR2.CR210, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR210, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR2.CR210
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element352
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR211 As String Implements CR2.CR211, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR211, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR2.CR211
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element352
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR212 As String Implements CR2.CR212, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR2.CR212
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1073
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR2
            Dim rval As New CR2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR201 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .CR202 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR203 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR204 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR205 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR206 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR207 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR208 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR209 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CR210 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CR211 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CR212 = source.ToStringValue(11)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Chiropractic Certification</summary>
    '''<remarks>To supply information related to the chiropractic service rendered to a patient</remarks>
    Public Interface CR2
        Inherits ISegment

        '''<summary>Count</summary>
        '''<remarks>CR201 is the number this treatment is in the series.</remarks>
        Property CR201 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR202 is the total number of treatments in the series.</remarks>
        Property CR202 As Decimal?

        '''<summary>Subluxation Level Code</summary>
        '''<remarks>When both CR203 and CR204 are present, CR203 is the beginning level of subluxation and CR204 is the ending level of subluxation.</remarks>
        Property CR203 As String

        '''<summary>Subluxation Level Code</summary>
        '''<remarks></remarks>
        Property CR204 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR205 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR206 is the time period involved in the treatment series.</remarks>
        Property CR206 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>CR207 is the number of treatments rendered in the month of service.</remarks>
        Property CR207 As Decimal?

        '''<summary>Nature of Condition Code</summary>
        '''<remarks></remarks>
        Property CR208 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR209 is complication indicator. A "Y" value indicates a complicated condition; an "N" value indicates an uncomplicated condition.</remarks>
        Property CR209 As String

        '''<summary>Description</summary>
        '''<remarks>CR210 is a description of the patient's condition.</remarks>
        Property CR210 As String

        '''<summary>Description</summary>
        '''<remarks>CR211 is an additional description of the patient's condition.</remarks>
        Property CR211 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR212 is X-rays availability indicator. A "Y" value indicates X-rays are maintained and available for carrier review; an "N" value indicates X-rays are not maintained and available for carrier review.</remarks>
        Property CR212 As String

    End Interface
End NameSpace