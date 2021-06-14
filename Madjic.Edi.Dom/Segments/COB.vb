Namespace Segments
    '''<summary>Coordination of Benefits</summary>
    '''<remarks>To supply information on coordination of benefits</remarks>
    Partial Friend Class COB_Obj
        Inherits Segment
        Implements COB,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB

        Public Sub New()
            MyBase.New("COB")
            Elements.AddRange({CType(Nothing, DataElements.Element1138),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1143),
                                      CType(Nothing, DataElements.Element1365)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property COB01 As String Implements COB.COB01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB.COB01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1138).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1138
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1138).Value = value
                End If
            End Set
        End Property

        Friend Property COB02 As String Implements COB.COB02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB.COB02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element127
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property COB03 As String Implements COB.COB03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB.COB03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1143).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1143
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1143).Value = value
                End If
            End Set
        End Property

        Friend Property COB04 As String Implements COB.COB04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2320.COB.COB04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1365
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1365).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As COB
            Dim rval As New COB_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .COB01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .COB02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .COB03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .COB04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Coordination of Benefits</summary>
    '''<remarks>To supply information on coordination of benefits</remarks>
    Public Interface COB
        Inherits ISegment

        '''<summary>Payer Responsibility Sequence Number Code</summary>
        '''<remarks></remarks>
        Property COB01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>COB02 is the policy number.</remarks>
        Property COB02 As String

        '''<summary>Coordination of Benefits Code</summary>
        '''<remarks></remarks>
        Property COB03 As String

        '''<summary>Service Type Code</summary>
        '''<remarks></remarks>
        Property COB04 As String

    End Interface
End NameSpace