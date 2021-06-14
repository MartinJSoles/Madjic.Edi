Namespace Segments
    '''<summary>Adjustment Amount</summary>
    '''<remarks>To specify the characteristics of an adjustment</remarks>
    Partial Friend Class AD1_Obj
        Inherits Segment
        Implements AD1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("AD1")
            Elements.AddRange({CType(Nothing, DataElements.Element426),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1129),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element9)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AD101 As String Implements AD1.AD101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element426).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element426
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element426).Value = value
                End If
            End Set
        End Property

        Friend Property AD102 As Decimal? Implements AD1.AD102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element782
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property AD103 As String Implements AD1.AD103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1129).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1129
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1129).Value = value
                End If
            End Set
        End Property

        Friend Property AD104 As String Implements AD1.AD104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element594
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property AD105 As String Implements AD1.AD105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element9).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element9
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element9).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AD1
            Dim rval As New AD1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AD101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AD102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .AD103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .AD104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .AD105 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Adjustment Amount</summary>
    '''<remarks>To specify the characteristics of an adjustment</remarks>
    Public Interface AD1
        Inherits ISegment

        '''<summary>Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property AD101 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>AD102 is the adjustment amount.</remarks>
        Property AD102 As Decimal?

        '''<summary>Adjustment Reason Code Characteristic</summary>
        '''<remarks></remarks>
        Property AD103 As String

        '''<summary>Frequency Code</summary>
        '''<remarks>AD104 is frequency of the AD102 monetary amount.</remarks>
        Property AD104 As String

        '''<summary>Late Reason Code</summary>
        '''<remarks></remarks>
        Property AD105 As String

    End Interface
End NameSpace