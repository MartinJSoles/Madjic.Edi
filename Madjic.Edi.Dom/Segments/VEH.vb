Namespace Segments
    '''<summary>Vehicle Information</summary>
    '''<remarks>To provide descriptions that identify a specific vehicle</remarks>
    Partial Friend Class VEH_Obj
        Inherits Segment
        Implements VEH
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleListConditional(4, {5, 7}),
                                                 New SyntaxRuleConditional(5, {4}),
                                                 New SyntaxRuleConditional(6, {4, 5}),
                                                 New SyntaxRuleConditional(7, {4}),
                                                 New SyntaxRulePaired({18, 19})}

        Public Sub New()
            MyBase.New("VEH")
            Elements.AddRange({CType(Nothing, DataElements.Element554),
                                      CType(Nothing, DataElements.Element539),
                                      CType(Nothing, DataElements.Element1095),
                                      CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element82),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Element310),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element610),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element610),
                                      CType(Nothing, DataElements.Element306),
                                      CType(Nothing, DataElements.Element26),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element26)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property VEH01 As Decimal? Implements VEH.VEH01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element554).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element554
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element554).Value = value
                End If
            End Set
        End Property

        Friend Property VEH02 As String Implements VEH.VEH02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element539).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element539
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element539).Value = value
                End If
            End Set
        End Property

        Friend Property VEH03 As Decimal? Implements VEH.VEH03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1095).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1095
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1095).Value = value
                End If
            End Set
        End Property

        Friend Property VEH04 As String Implements VEH.VEH04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element559
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property VEH05 As String Implements VEH.VEH05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element127
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property VEH06 As String Implements VEH.VEH06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element127
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property VEH07 As String Implements VEH.VEH07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element127
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property VEH08 As Decimal? Implements VEH.VEH08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element82).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element82
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element82).Value = value
                End If
            End Set
        End Property

        Friend Property VEH09 As String Implements VEH.VEH09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element127
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property VEH10 As String Implements VEH.VEH10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element156
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property VEH11 As String Implements VEH.VEH11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element310).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element310
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element310).Value = value
                End If
            End Set
        End Property

        Friend Property VEH12 As String Implements VEH.VEH12
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

        Friend Property VEH13 As Decimal? Implements VEH.VEH13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element610).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element610
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element610).Value = value
                End If
            End Set
        End Property

        Friend Property VEH14 As String Implements VEH.VEH14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1073
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property VEH15 As Decimal? Implements VEH.VEH15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element610).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element610
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element610).Value = value
                End If
            End Set
        End Property

        Friend Property VEH16 As String Implements VEH.VEH16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element306
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Property VEH17 As String Implements VEH.VEH17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element26
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Property VEH18 As String Implements VEH.VEH18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element93
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property VEH19 As String Implements VEH.VEH19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element26
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As VEH
            Dim rval As New VEH_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .VEH01 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .VEH02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .VEH03 = source.ToDecimalValue(2, 0)
                End If
                If source.Elements.Count > 3 Then
                    .VEH04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .VEH05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .VEH06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .VEH07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .VEH08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .VEH09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .VEH10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .VEH11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .VEH12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .VEH13 = source.ToDecimalValue(12, 2)
                End If
                If source.Elements.Count > 13 Then
                    .VEH14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .VEH15 = source.ToDecimalValue(14, 2)
                End If
                If source.Elements.Count > 15 Then
                    .VEH16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .VEH17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .VEH18 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .VEH19 = source.ToStringValue(18)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Vehicle Information</summary>
    '''<remarks>To provide descriptions that identify a specific vehicle</remarks>
    Public Interface VEH
        Inherits ISegment

        '''<summary>Assigned Number</summary>
        '''<remarks></remarks>
        Property VEH01 As Decimal?

        '''<summary>Vehicle Identification Number</summary>
        '''<remarks></remarks>
        Property VEH02 As String

        '''<summary>Year</summary>
        '''<remarks></remarks>
        Property VEH03 As Decimal?

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks>VEH04 applies to VEH05, VEH06, and VEH07.</remarks>
        Property VEH04 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>VEH05 is the vehicle make.</remarks>
        Property VEH05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>VEH06 is the vehicle model.</remarks>
        Property VEH06 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>VEH07 is the vehicle style.</remarks>
        Property VEH07 As String

        '''<summary>Length</summary>
        '''<remarks>VEH08 is the length of a vehicle measured in feet.</remarks>
        Property VEH08 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks>VEH09 is the vehicle reference number.</remarks>
        Property VEH09 As String

        '''<summary>State or Province Code</summary>
        '''<remarks>VEH10 is the vehicle registration state or province.</remarks>
        Property VEH10 As String

        '''<summary>Location Identifier</summary>
        '''<remarks>VEH11 is used to identify a territory as defined by trading partners.</remarks>
        Property VEH11 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>VEH12 is the used car indicator. A "Y" indicates the vehicle is a used vehicle; an "N" indicates the vehicle is a new vehicle. A value of "U" indicating 'unknown' cannot be used.</remarks>
        Property VEH12 As String

        '''<summary>Amount</summary>
        '''<remarks>VEH13 is the original cost of the vehicle when it was new (i.e., OCN - original cost new).</remarks>
        Property VEH13 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>VEH14 is the vehicle altered indicator. A "Y" indicates the vehicle was altered; an "N" indicates the vehicle was not altered. A value of "U" indicating 'unknown' cannot be used.</remarks>
        Property VEH14 As String

        '''<summary>Amount</summary>
        '''<remarks>VEH15 is the value of alterations for a vehicle.</remarks>
        Property VEH15 As Decimal?

        '''<summary>Action Code</summary>
        '''<remarks></remarks>
        Property VEH16 As String

        '''<summary>Country Code</summary>
        '''<remarks>VEH17 is the Country of the State in VEH10.</remarks>
        Property VEH17 As String

        '''<summary>Name</summary>
        '''<remarks>VEH18 is the Name of the Vehicle Owner.</remarks>
        Property VEH18 As String

        '''<summary>Country Code</summary>
        '''<remarks>VEH19 is the Residence Country of the Vehicle Owner in VEH18.</remarks>
        Property VEH19 As String

    End Interface
End NameSpace