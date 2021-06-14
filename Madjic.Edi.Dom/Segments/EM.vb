Namespace Segments
    '''<summary>Equipment Characteristics</summary>
    '''<remarks>To send additional information regarding a specific piece of equipment</remarks>
    Partial Friend Class EM_Obj
        Inherits Segment
        Implements EM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(2, {1}),
                                                 New SyntaxRuleConditional(4, {3})}

        Public Sub New()
            MyBase.New("EM")
            Elements.AddRange({CType(Nothing, DataElements.Element188),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element184),
                                      CType(Nothing, DataElements.Element183),
                                      CType(Nothing, DataElements.Element26),
                                      CType(Nothing, DataElements.Element1429),
                                      CType(Nothing, DataElements.Element373)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property EM01 As String Implements EM.EM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element188).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element188
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element188).Value = value
                End If
            End Set
        End Property

        Friend Property EM02 As Decimal? Implements EM.EM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element81
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property EM03 As String Implements EM.EM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element184).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element184
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element184).Value = value
                End If
            End Set
        End Property

        Friend Property EM04 As Decimal? Implements EM.EM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element183).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element183
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element183).Value = value
                End If
            End Set
        End Property

        Friend Property EM05 As String Implements EM.EM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element26
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Property EM06 As String Implements EM.EM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1429).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1429
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1429).Value = value
                End If
            End Set
        End Property

        Friend Property EM07 As Date? Implements EM.EM07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element373
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As EM
            Dim rval As New EM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .EM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .EM02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .EM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .EM04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .EM05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .EM06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .EM07 = source.ToDateValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Equipment Characteristics</summary>
    '''<remarks>To send additional information regarding a specific piece of equipment</remarks>
    Public Interface EM
        Inherits ISegment

        '''<summary>Weight Unit Code</summary>
        '''<remarks></remarks>
        Property EM01 As String

        '''<summary>Weight</summary>
        '''<remarks>EM02 is the maximum load weight.</remarks>
        Property EM02 As Decimal?

        '''<summary>Volume Unit Qualifier</summary>
        '''<remarks></remarks>
        Property EM03 As String

        '''<summary>Volume</summary>
        '''<remarks>EM04 is the maximum load volume.</remarks>
        Property EM04 As Decimal?

        '''<summary>Country Code</summary>
        '''<remarks>EM05 is the country of manufacture.</remarks>
        Property EM05 As String

        '''<summary>Construction Type</summary>
        '''<remarks></remarks>
        Property EM06 As String

        '''<summary>Date</summary>
        '''<remarks>EM07 is the last inspection date for convention of safe container.</remarks>
        Property EM07 As Date?

    End Interface
End NameSpace