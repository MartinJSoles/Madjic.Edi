Namespace Segments
    '''<summary>Retirement Product</summary>
    '''<remarks>To specify the retirement product characteristics</remarks>
    Partial Friend Class RP_Obj
        Inherits Segment
        Implements RP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("RP")
            Elements.AddRange({CType(Nothing, DataElements.Element875),
                                      CType(Nothing, DataElements.Element1205),
                                      CType(Nothing, DataElements.Element1203),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1295),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1296),
                                      CType(Nothing, DataElements.Element151),
                                      CType(Nothing, DataElements.Element1204)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property RP01 As String Implements RP.RP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element875).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element875
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element875).Value = value
                End If
            End Set
        End Property

        Friend Property RP02 As String Implements RP.RP02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1205).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1205
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1205).Value = value
                End If
            End Set
        End Property

        Friend Property RP03 As String Implements RP.RP03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1203).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1203
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1203).Value = value
                End If
            End Set
        End Property

        Friend Property RP04 As String Implements RP.RP04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element352
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property RP05 As String Implements RP.RP05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1295).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1295
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1295).Value = value
                End If
            End Set
        End Property

        Friend Property RP06 As String Implements RP.RP06
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

        Friend Property RP07 As String Implements RP.RP07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1296).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1296
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1296).Value = value
                End If
            End Set
        End Property

        Friend Property RP08 As String Implements RP.RP08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element151).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element151
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element151).Value = value
                End If
            End Set
        End Property

        Friend Property RP09 As String Implements RP.RP09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1204).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1204
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1204).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As RP
            Dim rval As New RP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .RP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .RP02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .RP03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .RP04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .RP05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .RP06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .RP07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .RP08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .RP09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Retirement Product</summary>
    '''<remarks>To specify the retirement product characteristics</remarks>
    Public Interface RP
        Inherits ISegment

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property RP01 As String

        '''<summary>Insurance Line Code</summary>
        '''<remarks></remarks>
        Property RP02 As String

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property RP03 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property RP04 As String

        '''<summary>Participant Status Code</summary>
        '''<remarks></remarks>
        Property RP05 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>RP06 is the eligibility indicator. A "Y" value indicates the participant is eligible for plan allocations; an "N" value indicates the participant is not eligible for plan allocations.</remarks>
        Property RP06 As String

        '''<summary>Special Processing Type</summary>
        '''<remarks></remarks>
        Property RP07 As String

        '''<summary>Authority</summary>
        '''<remarks>RP08 specifies the authorizations granted for transfer of funds via the telephone.</remarks>
        Property RP08 As String

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property RP09 As String

    End Interface
End NameSpace