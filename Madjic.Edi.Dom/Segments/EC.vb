Namespace Segments
    '''<summary>Employment Class</summary>
    '''<remarks>To provide class of employment information</remarks>
    Partial Friend Class EC_Obj
        Inherits Segment
        Implements EC,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC

        Public Sub New()
            MyBase.New("EC")
            Elements.AddRange({CType(Nothing, DataElements.Element1176),
                                      CType(Nothing, DataElements.Element1176),
                                      CType(Nothing, DataElements.Element1176),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element1201),
                                      CType(Nothing, DataElements.Element1149)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property EC01 As String Implements EC.EC01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC.EC01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1176).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1176
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1176).Value = value
                End If
            End Set
        End Property

        Friend Property EC02 As String Implements EC.EC02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC.EC02
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

        Friend Property EC03 As String Implements EC.EC03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.EC.EC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1176).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1176
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1176).Value = value
                End If
            End Set
        End Property

        Friend Property EC04 As Decimal? Implements EC.EC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element954
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property EC05 As String Implements EC.EC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1201).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1201
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1201).Value = value
                End If
            End Set
        End Property

        Friend Property EC06 As String Implements EC.EC06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1149).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1149
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1149).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As EC
            Dim rval As New EC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .EC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .EC02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .EC03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .EC04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .EC05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .EC06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Employment Class</summary>
    '''<remarks>To provide class of employment information</remarks>
    Public Interface EC
        Inherits ISegment

        '''<summary>Employment Class Code</summary>
        '''<remarks></remarks>
        Property EC01 As String

        '''<summary>Employment Class Code</summary>
        '''<remarks></remarks>
        Property EC02 As String

        '''<summary>Employment Class Code</summary>
        '''<remarks></remarks>
        Property EC03 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>EC04 is percent of ownership.</remarks>
        Property EC04 As Decimal?

        '''<summary>Information Status Code</summary>
        '''<remarks>EC05 applies to the entire segment.</remarks>
        Property EC05 As String

        '''<summary>Occupation Code</summary>
        '''<remarks></remarks>
        Property EC06 As String

    End Interface
End NameSpace