Namespace Segments
    '''<summary>Pacemaker Certification</summary>
    '''<remarks>To supply information related to Pacemaker registry</remarks>
    Partial Friend Class CR8_Obj
        Inherits Segment
        Implements CR8
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5, 6, 7, 8, 9})}

        Public Sub New()
            MyBase.New("CR8")
            Elements.AddRange({CType(Nothing, DataElements.Element1403),
                                      CType(Nothing, DataElements.Element1404),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR801 As String Implements CR8.CR801
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1403).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1403
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1403).Value = value
                End If
            End Set
        End Property

        Friend Property CR802 As String Implements CR8.CR802
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1404).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1404
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1404).Value = value
                End If
            End Set
        End Property

        Friend Property CR803 As Date? Implements CR8.CR803
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

        Friend Property CR804 As Date? Implements CR8.CR804
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element373
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property CR805 As String Implements CR8.CR805
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

        Friend Property CR806 As String Implements CR8.CR806
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

        Friend Property CR807 As String Implements CR8.CR807
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

        Friend Property CR808 As String Implements CR8.CR808
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1073
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CR809 As String Implements CR8.CR809
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR8
            Dim rval As New CR8_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR801 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR802 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR803 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR804 = source.ToDateValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR805 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR806 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR807 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR808 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR809 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Pacemaker Certification</summary>
    '''<remarks>To supply information related to Pacemaker registry</remarks>
    Public Interface CR8
        Inherits ISegment

        '''<summary>Implant Type Code</summary>
        '''<remarks></remarks>
        Property CR801 As String

        '''<summary>Implant Status Code</summary>
        '''<remarks></remarks>
        Property CR802 As String

        '''<summary>Date</summary>
        '''<remarks>CR803 is the warranty expiration date.</remarks>
        Property CR803 As Date?

        '''<summary>Date</summary>
        '''<remarks>CR804 is the implant date.</remarks>
        Property CR804 As Date?

        '''<summary>Reference Identification</summary>
        '''<remarks>CR805 is the manufacturer identification.</remarks>
        Property CR805 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>CR806 is the model number.</remarks>
        Property CR806 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>CR807 is the serial number.</remarks>
        Property CR807 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR808 indicates if leads were left in the patient. A "Y" value indicates leads were left in patient; an "N" value indicates leads were not left in patient.</remarks>
        Property CR808 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CR809 indicates if the pacemaker was returned to the manufacturer. A "Y" value indicates the pacemaker was returned to the manufacturer; an "N" value indicates the pacemaker was not returned to the manufacturer.</remarks>
        Property CR809 As String

    End Interface
End NameSpace