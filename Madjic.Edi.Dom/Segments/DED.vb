Namespace Segments
    '''<summary>Deductions</summary>
    '''<remarks>To specify payment related information for child support payment deductions</remarks>
    Partial Friend Class DED_Obj
        Inherits Segment
        Implements DED
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5, 6})}

        Public Sub New()
            MyBase.New("DED")
            Elements.AddRange({CType(Nothing, DataElements.Element1511),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element610),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DED01 As String Implements DED.DED01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1511).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1511
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1511).Value = value
                End If
            End Set
        End Property

        Friend Property DED02 As String Implements DED.DED02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element127
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property DED03 As Date? Implements DED.DED03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element373
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property DED04 As Decimal? Implements DED.DED04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element610).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element610
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element610).Value = value
                End If
            End Set
        End Property

        Friend Property DED05 As String Implements DED.DED05
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

        Friend Property DED06 As String Implements DED.DED06
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

        Friend Property DED07 As String Implements DED.DED07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element93
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property DED08 As String Implements DED.DED08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element127
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property DED09 As String Implements DED.DED09
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DED
            Dim rval As New DED_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DED01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DED02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DED03 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DED04 = source.ToDecimalValue(3, 2)
                End If
                If source.Elements.Count > 4 Then
                    .DED05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .DED06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .DED07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .DED08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .DED09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Deductions</summary>
    '''<remarks>To specify payment related information for child support payment deductions</remarks>
    Public Interface DED
        Inherits ISegment

        '''<summary>Type of Deduction</summary>
        '''<remarks></remarks>
        Property DED01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property DED02 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property DED03 As Date?

        '''<summary>Amount</summary>
        '''<remarks></remarks>
        Property DED04 As Decimal?

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property DED05 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks></remarks>
        Property DED06 As String

        '''<summary>Name</summary>
        '''<remarks></remarks>
        Property DED07 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property DED08 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks></remarks>
        Property DED09 As String

    End Interface
End NameSpace