Namespace Segments
    '''<summary>Orthodontic Information</summary>
    '''<remarks>To supply orthodontic information</remarks>
    Partial Friend Class DN1_Obj
        Inherits Segment
        Implements DN1,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1

        Public Sub New()
            MyBase.New("DN1")
            Elements.AddRange({CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element352)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DN101 As Decimal? Implements DN1.DN101, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1.DN101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element380
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property DN102 As Decimal? Implements DN1.DN102, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1.DN102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element380
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property DN103 As String Implements DN1.DN103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1073
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property DN104 As String Implements DN1.DN104, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.DN1.DN104
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DN1
            Dim rval As New DN1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DN101 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DN102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DN103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DN104 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Orthodontic Information</summary>
    '''<remarks>To supply orthodontic information</remarks>
    Public Interface DN1
        Inherits ISegment

        '''<summary>Quantity</summary>
        '''<remarks>DN101 is the estimated number of treatment months.</remarks>
        Property DN101 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>DN102 is the number of treatment months remaining.</remarks>
        Property DN102 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>DN103 is the extra oral traction device indicator. A "Y" value indicates an extra oral traction device; an "N" value indicates no extra oral traction device.</remarks>
        Property DN103 As String

        '''<summary>Description</summary>
        '''<remarks>DN104 is the appliance description.</remarks>
        Property DN104 As String

    End Interface
End NameSpace