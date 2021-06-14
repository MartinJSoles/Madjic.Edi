Namespace Segments
    '''<summary>Deferred Delivery Request Segment</summary>
    '''<remarks>To specify the earliest time when the interchange can be delivered</remarks>
    Partial Friend Class ISE_Obj
        Inherits Segment
        Implements ISE
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("ISE")
            Elements.AddRange({CType(Nothing, DataElements.ElementI35),
                                      CType(Nothing, DataElements.ElementI36),
                                      CType(Nothing, DataElements.ElementI37)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ISE01 As Date? Implements ISE.ISE01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.ElementI35).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.ElementI35
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.ElementI35).Value = value
                End If
            End Set
        End Property

        Friend Property ISE02 As TimeSpan? Implements ISE.ISE02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.ElementI36).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.ElementI36
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.ElementI36).Value = value
                End If
            End Set
        End Property

        Friend Property ISE03 As String Implements ISE.ISE03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.ElementI37).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.ElementI37
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.ElementI37).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ISE
            Dim rval As New ISE_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ISE01 = source.ToDateValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ISE02 = source.ToTimeSpanValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ISE03 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Deferred Delivery Request Segment</summary>
    '''<remarks>To specify the earliest time when the interchange can be delivered</remarks>
    Public Interface ISE
        Inherits ISegment

        '''<summary>Interchange Delivery Date</summary>
        '''<remarks></remarks>
        Property ISE01 As Date?

        '''<summary>Interchange Delivery Time</summary>
        '''<remarks></remarks>
        Property ISE02 As Timespan?

        '''<summary>Interchange Delivery Time Code</summary>
        '''<remarks></remarks>
        Property ISE03 As String

    End Interface
End NameSpace