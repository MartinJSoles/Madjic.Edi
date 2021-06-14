Namespace Segments
    '''<summary>Royalty Payment</summary>
    '''<remarks>To specify remittance information about royalty payments</remarks>
    Partial Friend Class RYL_Obj
        Inherits Segment
        Implements RYL
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("RYL")
            Elements.AddRange({CType(Nothing, DataElements.Element554),
                                      CType(Nothing, DataElements.Element1035),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property RYL01 As Decimal? Implements RYL.RYL01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element554).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element554
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element554).Value = value
                End If
            End Set
        End Property

        Friend Property RYL02 As String Implements RYL.RYL02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1035).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1035
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1035).Value = value
                End If
            End Set
        End Property

        Friend Property RYL03 As String Implements RYL.RYL03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element66
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property RYL04 As String Implements RYL.RYL04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element67
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As RYL
            Dim rval As New RYL_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .RYL01 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .RYL02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .RYL03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .RYL04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Royalty Payment</summary>
    '''<remarks>To specify remittance information about royalty payments</remarks>
    Public Interface RYL
        Inherits ISegment

        '''<summary>Assigned Number</summary>
        '''<remarks></remarks>
        Property RYL01 As Decimal?

        '''<summary>Name Last or Organization Name</summary>
        '''<remarks></remarks>
        Property RYL02 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property RYL03 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property RYL04 As String

    End Interface
End NameSpace