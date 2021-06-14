Namespace Segments
    '''<summary>Interchange Acknowledgment</summary>
    '''<remarks>To report the status of processing a received interchange header and trailer or the non-delivery by a network provider</remarks>
    Partial Friend Class TA1_Obj
        Inherits Segment
        Implements TA1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5})}

        Public Sub New()
            MyBase.New("TA1")
            Elements.AddRange({CType(Nothing, DataElements.ElementI12),
                                      CType(Nothing, DataElements.ElementI08),
                                      CType(Nothing, DataElements.ElementI09),
                                      CType(Nothing, DataElements.ElementI17),
                                      CType(Nothing, DataElements.ElementI18)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TA101 As Decimal? Implements TA1.TA101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.ElementI12).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.ElementI12
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.ElementI12).Value = value
                End If
            End Set
        End Property

        Friend Property TA102 As Date? Implements TA1.TA102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.ElementI08).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.ElementI08
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.ElementI08).Value = value
                End If
            End Set
        End Property

        Friend Property TA103 As TimeSpan? Implements TA1.TA103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.ElementI09).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.ElementI09
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.ElementI09).Value = value
                End If
            End Set
        End Property

        Friend Property TA104 As String Implements TA1.TA104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.ElementI17).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.ElementI17
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.ElementI17).Value = value
                End If
            End Set
        End Property

        Friend Property TA105 As String Implements TA1.TA105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.ElementI18).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.ElementI18
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.ElementI18).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TA1
            Dim rval As New TA1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TA101 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .TA102 = source.ToDateValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TA103 = source.ToTimeSpanValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TA104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .TA105 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Interchange Acknowledgment</summary>
    '''<remarks>To report the status of processing a received interchange header and trailer or the non-delivery by a network provider</remarks>
    Public Interface TA1
        Inherits ISegment

        '''<summary>Interchange Control Number</summary>
        '''<remarks></remarks>
        Property TA101 As Decimal?

        '''<summary>Interchange Date</summary>
        '''<remarks></remarks>
        Property TA102 As Date?

        '''<summary>Interchange Time</summary>
        '''<remarks></remarks>
        Property TA103 As Timespan?

        '''<summary>Interchange Acknowledgment Code</summary>
        '''<remarks></remarks>
        Property TA104 As String

        '''<summary>Interchange Note Code</summary>
        '''<remarks></remarks>
        Property TA105 As String

    End Interface
End NameSpace