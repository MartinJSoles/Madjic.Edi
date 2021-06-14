Namespace Segments
    '''<summary>Employment Position</summary>
    '''<remarks>To describe employment position</remarks>
    Partial Friend Class EMS_Obj
        Inherits Segment
        Implements EMS

        Public Sub New()
            MyBase.New("EMS")
            Elements.AddRange({CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1176),
                                      CType(Nothing, DataElements.Element1149),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element332),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element1176)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property EMS01 As String Implements EMS.EMS01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element352
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property EMS02 As String Implements EMS.EMS02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1176).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1176
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1176).Value = value
                End If
            End Set
        End Property

        Friend Property EMS03 As String Implements EMS.EMS03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1149).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1149
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1149).Value = value
                End If
            End Set
        End Property

        Friend Property EMS04 As String Implements EMS.EMS04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element584).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element584
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element584).Value = value
                End If
            End Set
        End Property

        Friend Property EMS05 As String Implements EMS.EMS05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element128
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property EMS06 As String Implements EMS.EMS06
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

        Friend Property EMS07 As String Implements EMS.EMS07
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

        Friend Property EMS08 As String Implements EMS.EMS08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element128
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property EMS09 As String Implements EMS.EMS09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element66
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property EMS10 As String Implements EMS.EMS10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element67
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property EMS11 As Decimal? Implements EMS.EMS11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element332).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element332
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element332).Value = value
                End If
            End Set
        End Property

        Friend Property EMS12 As String Implements EMS.EMS12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element584).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element584
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element584).Value = value
                End If
            End Set
        End Property

        Friend Property EMS13 As String Implements EMS.EMS13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element66
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property EMS14 As String Implements EMS.EMS14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element67
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property EMS15 As String Implements EMS.EMS15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1176).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1176
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1176).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As EMS
            Dim rval As New EMS_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .EMS01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .EMS02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .EMS03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .EMS04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .EMS05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .EMS06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .EMS07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .EMS08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .EMS09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .EMS10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .EMS11 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .EMS12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .EMS13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .EMS14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .EMS15 = source.ToStringValue(14)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Employment Position</summary>
    '''<remarks>To describe employment position</remarks>
    Public Interface EMS
        Inherits ISegment

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property EMS01 As String

        '''<summary>Employment Class Code</summary>
        '''<remarks></remarks>
        Property EMS02 As String

        '''<summary>Occupation Code</summary>
        '''<remarks></remarks>
        Property EMS03 As String

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property EMS04 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property EMS05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property EMS06 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property EMS07 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property EMS08 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property EMS09 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property EMS10 As String

        '''<summary>Percent, Decimal Format</summary>
        '''<remarks></remarks>
        Property EMS11 As Decimal?

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property EMS12 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property EMS13 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property EMS14 As String

        '''<summary>Employment Class Code</summary>
        '''<remarks></remarks>
        Property EMS15 As String

    End Interface
End NameSpace