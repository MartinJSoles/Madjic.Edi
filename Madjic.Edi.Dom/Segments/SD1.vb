Namespace Segments
    '''<summary>Safety Data</summary>
    '''<remarks>To provide safety data information to recipients of the transaction, including identification of the hazard that the material being described represents, and the organization or party which declared this material to be a hazard or established exposure limits or other guidelines for that material</remarks>
    Partial Friend Class SD1_Obj
        Inherits Segment
        Implements SD1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleListConditional(3, {5, 6}),
                                                 New SyntaxRuleRequired({5, 6}),
                                                 New SyntaxRuleConditional(5, {3}),
                                                 New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("SD1")
            Elements.AddRange({CType(Nothing, DataElements.Element349),
                                      CType(Nothing, DataElements.Element821),
                                      CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element822),
                                      CType(Nothing, DataElements.Element751),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Element26)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SD101 As String Implements SD1.SD101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element349).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element349
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element349).Value = value
                End If
            End Set
        End Property

        Friend Property SD102 As String Implements SD1.SD102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element821).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element821
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element821).Value = value
                End If
            End Set
        End Property

        Friend Property SD103 As String Implements SD1.SD103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element559
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property SD104 As String Implements SD1.SD104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element822).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element822
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element822).Value = value
                End If
            End Set
        End Property

        Friend Property SD105 As String Implements SD1.SD105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element751).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element751
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element751).Value = value
                End If
            End Set
        End Property

        Friend Property SD106 As String Implements SD1.SD106
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element352
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property SD107 As String Implements SD1.SD107
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element156
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property SD108 As String Implements SD1.SD108
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element26
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SD1
            Dim rval As New SD1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SD101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SD102 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SD103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SD104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SD105 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SD106 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SD107 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SD108 = source.ToStringValue(7)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Safety Data</summary>
    '''<remarks>To provide safety data information to recipients of the transaction, including identification of the hazard that the material being described represents, and the organization or party which declared this material to be a hazard or established exposure limits or other guidelines for that material</remarks>
    Public Interface SD1
        Inherits ISegment

        '''<summary>Item Description Type</summary>
        '''<remarks>SD101 indicates the format of this safety data information.</remarks>
        Property SD101 As String

        '''<summary>Safety Characteristic/Hazard Code</summary>
        '''<remarks></remarks>
        Property SD102 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks>SD103 identifies the organization responsible for the code used in SD105 or the free-form text in SD106.</remarks>
        Property SD103 As String

        '''<summary>Source Subqualifier</summary>
        '''<remarks>SD104 is a reference that indicates the table or text maintained by the source qualifier (SD103).</remarks>
        Property SD104 As String

        '''<summary>Product Description Code</summary>
        '''<remarks>SD105 is a code from the organization list which provides specific data about a safety characteristic or hazard.</remarks>
        Property SD105 As String

        '''<summary>Description</summary>
        '''<remarks>SD106 is a free-form description of a safety characteristic or hazard.</remarks>
        Property SD106 As String

        '''<summary>State or Province Code</summary>
        '''<remarks>SD107 specifies the state or province issuing the regulation that applies to the safety data included in this segment.</remarks>
        Property SD107 As String

        '''<summary>Country Code</summary>
        '''<remarks>SD108 specifies the country issuing the regulation that applies to the safety data included in this segment.</remarks>
        Property SD108 As String

    End Interface
End NameSpace