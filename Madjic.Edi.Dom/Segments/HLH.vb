Namespace Segments
    '''<summary>Health Information</summary>
    '''<remarks>To provide health information</remarks>
    Partial Friend Class HLH_Obj
        Inherits Segment
        Implements HLH,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH

        Public Sub New()
            MyBase.New("HLH")
            Elements.AddRange({CType(Nothing, DataElements.Element1212),
                                      CType(Nothing, DataElements.Element65),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1213),
                                      CType(Nothing, DataElements.Element352)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HLH01 As String Implements HLH.HLH01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH.HLH01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1212).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1212
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1212).Value = value
                End If
            End Set
        End Property

        Friend Property HLH02 As Decimal? Implements HLH.HLH02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH.HLH02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element65).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element65
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element65).Value = value
                End If
            End Set
        End Property

        Friend Property HLH03 As Decimal? Implements HLH.HLH03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.HLH.HLH03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element81
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property HLH04 As Decimal? Implements HLH.HLH04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element81
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property HLH05 As String Implements HLH.HLH05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element352
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property HLH06 As String Implements HLH.HLH06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1213).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1213
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1213).Value = value
                End If
            End Set
        End Property

        Friend Property HLH07 As String Implements HLH.HLH07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element352
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HLH
            Dim rval As New HLH_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HLH01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HLH02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HLH03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HLH04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .HLH05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .HLH06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .HLH07 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Information</summary>
    '''<remarks>To provide health information</remarks>
    Public Interface HLH
        Inherits ISegment

        '''<summary>Health-Related Code</summary>
        '''<remarks></remarks>
        Property HLH01 As String

        '''<summary>Height</summary>
        '''<remarks></remarks>
        Property HLH02 As Decimal?

        '''<summary>Weight</summary>
        '''<remarks>HLH03 is the current weight in pounds.</remarks>
        Property HLH03 As Decimal?

        '''<summary>Weight</summary>
        '''<remarks>HLH04 is the previous weight in pounds.</remarks>
        Property HLH04 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>HLH05 is the reason for change in weight.</remarks>
        Property HLH05 As String

        '''<summary>Current Health Condition Code</summary>
        '''<remarks></remarks>
        Property HLH06 As String

        '''<summary>Description</summary>
        '''<remarks>HLH07 describes the reason for last doctor visit.</remarks>
        Property HLH07 As String

    End Interface
End NameSpace