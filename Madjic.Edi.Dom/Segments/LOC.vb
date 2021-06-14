Namespace Segments
    '''<summary>Location</summary>
    '''<remarks>To describe the location in space and time of the axis of an item relative to an origin axis; Euclidean geometry has been assumed with orthogonal axes; the sequence of axes has been chosen in the customary sequence of X, Y, and Z, however, it is possible to just use two-dimensional space rather than three-dimensional space</remarks>
    Partial Friend Class LOC_Obj
        Inherits Segment
        Implements LOC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("LOC")
            Elements.AddRange({CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element729),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element739),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LOC00 As Decimal? Implements LOC.LOC00
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element739
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC01 As String Implements LOC.LOC01
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element128
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property LOC02 As String Implements LOC.LOC02
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property LOC03 As String Implements LOC.LOC03
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

        Friend Property LOC04 As String Implements LOC.LOC04
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

        Friend Property LOC05 As String Implements LOC.LOC05
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element729).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element729
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element729).Value = value
                End If
            End Set
        End Property

        Friend Property LOC06 As String Implements LOC.LOC06
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element128
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property LOC07 As String Implements LOC.LOC07
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

        Friend Property LOC08 As String Implements LOC.LOC08
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element352
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property LOC09 As String Implements LOC.LOC09
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element127
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property LOC10 As Decimal? Implements LOC.LOC10
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element739
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC11 As DataElements.Composite.C001 Implements LOC.LOC11
            Get
                Return CType(Elements(11), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(11) = value
            End Set
        End Property

        Friend Property LOC12 As Decimal? Implements LOC.LOC12
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element739
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC13 As DataElements.Composite.C001 Implements LOC.LOC13
            Get
                Return CType(Elements(13), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(13) = value
            End Set
        End Property

        Friend Property LOC14 As Decimal? Implements LOC.LOC14
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element739
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC15 As DataElements.Composite.C001 Implements LOC.LOC15
            Get
                Return CType(Elements(15), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(15) = value
            End Set
        End Property

        Friend Property LOC16 As Decimal? Implements LOC.LOC16
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element739
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC17 As DataElements.Composite.C001 Implements LOC.LOC17
            Get
                Return CType(Elements(17), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(17) = value
            End Set
        End Property

        Friend Property LOC18 As Decimal? Implements LOC.LOC18
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element739).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element739
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element739).Value = value
                End If
            End Set
        End Property

        Friend Property LOC19 As DataElements.Composite.C001 Implements LOC.LOC19
            Get
                Return CType(Elements(19), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(19) = value
            End Set
        End Property

        Friend Property LOC21 As DataElements.Composite.C001 Implements LOC.LOC21
            Get
                Return CType(Elements(20), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(20) = value
            End Set
        End Property

        Friend Property LOC22 As String Implements LOC.LOC22
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.Element128
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property LOC23 As String Implements LOC.LOC23
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.Element127
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property LOC24 As String Implements LOC.LOC24
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.Element352
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LOC
            Dim rval As New LOC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LOC00 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .LOC01 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .LOC02 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .LOC03 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .LOC04 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .LOC05 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .LOC06 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .LOC07 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .LOC08 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .LOC09 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .LOC10 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .Elements(11) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(11), reader)
                End If
                If source.Elements.Count > 12 Then
                    .LOC12 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .Elements(13) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(13), reader)
                End If
                If source.Elements.Count > 14 Then
                    .LOC14 = source.ToFloatValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .Elements(15) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(15), reader)
                End If
                If source.Elements.Count > 16 Then
                    .LOC16 = source.ToFloatValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .Elements(17) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(17), reader)
                End If
                If source.Elements.Count > 18 Then
                    .LOC18 = source.ToFloatValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .Elements(19) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(19), reader)
                End If
                If source.Elements.Count > 20 Then
                    .Elements(20) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(20), reader)
                End If
                If source.Elements.Count > 21 Then
                    .LOC22 = source.ToStringValue(21)
                End If
                If source.Elements.Count > 22 Then
                    .LOC23 = source.ToStringValue(22)
                End If
                If source.Elements.Count > 23 Then
                    .LOC24 = source.ToStringValue(23)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Location</summary>
    '''<remarks>To describe the location in space and time of the axis of an item relative to an origin axis; Euclidean geometry has been assumed with orthogonal axes; the sequence of axes has been chosen in the customary sequence of X, Y, and Z, however, it is possible to just use two-dimensional space rather than three-dimensional space</remarks>
    Public Interface LOC
        Inherits ISegment

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC00 As Decimal?

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property LOC01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property LOC02 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property LOC03 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property LOC04 As String

        '''<summary>Category</summary>
        '''<remarks></remarks>
        Property LOC05 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property LOC06 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property LOC07 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property LOC08 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property LOC09 As String

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC10 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC11 As DataElements.Composite.C001

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC12 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC13 As DataElements.Composite.C001

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC14 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC15 As DataElements.Composite.C001

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC16 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC17 As DataElements.Composite.C001

        '''<summary>Measurement Value</summary>
        '''<remarks></remarks>
        Property LOC18 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC19 As DataElements.Composite.C001

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property LOC21 As DataElements.Composite.C001

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property LOC22 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property LOC23 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property LOC24 As String

    End Interface
End NameSpace