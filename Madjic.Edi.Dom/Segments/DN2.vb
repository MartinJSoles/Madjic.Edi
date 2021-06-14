Namespace Segments
    '''<summary>Tooth Summary</summary>
    '''<remarks>To specify the status of individual teeth</remarks>
    Partial Friend Class DN2_Obj
        Inherits Segment
        Implements DN2,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({4, 5}),
                                                 New SyntaxRuleAllRequired({1, 6})}

        Public Sub New()
            MyBase.New("DN2")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1368),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element1270)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DN201 As String Implements DN2.DN201, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2.DN201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element127
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property DN202 As String Implements DN2.DN202, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2.DN202
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1368).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1368
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1368).Value = value
                End If
            End Set
        End Property

        Friend Property DN203 As Decimal? Implements DN2.DN203
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property DN204 As String Implements DN2.DN204
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1250
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property DN205 As String Implements DN2.DN205
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1251
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property DN206 As String Implements DN2.DN206, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN2.DN206
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1270
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DN2
            Dim rval As New DN2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DN201 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DN202 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DN203 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DN204 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .DN205 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .DN206 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Tooth Summary</summary>
    '''<remarks>To specify the status of individual teeth</remarks>
    Public Interface DN2
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>DN201 is the tooth number.</remarks>
        Property DN201 As String

        '''<summary>Tooth Status Code</summary>
        '''<remarks></remarks>
        Property DN202 As String

        '''<summary>Quantity</summary>
        '''<remarks>DN203 is the measurement expressed in millimeters of the distance between the gingival crest and the base of the tooth pocket.</remarks>
        Property DN203 As Decimal?

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property DN204 As String

        '''<summary>Date Time Period</summary>
        '''<remarks></remarks>
        Property DN205 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks>DN206 designates the code set used to identify the tooth in DN201.</remarks>
        Property DN206 As String

    End Interface
End NameSpace