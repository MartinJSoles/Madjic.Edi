Namespace Segments
    '''<summary>Life Coverage</summary>
    '''<remarks>To provide information on life coverage</remarks>
    Partial Friend Class LC_Obj
        Inherits Segment
        Implements LC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("LC")
            Elements.AddRange({CType(Nothing, DataElements.Element875),
                                      CType(Nothing, DataElements.Element1203),
                                      CType(Nothing, DataElements.Element1205),
                                      CType(Nothing, DataElements.Element1204),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1161),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LC01 As String Implements LC.LC01
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

        Friend Property LC02 As String Implements LC.LC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1203).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1203
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1203).Value = value
                End If
            End Set
        End Property

        Friend Property LC03 As String Implements LC.LC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1205).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1205
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1205).Value = value
                End If
            End Set
        End Property

        Friend Property LC04 As String Implements LC.LC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1204).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1204
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1204).Value = value
                End If
            End Set
        End Property

        Friend Property LC05 As Decimal? Implements LC.LC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element380
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property LC06 As String Implements LC.LC06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1161).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1161
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1161).Value = value
                End If
            End Set
        End Property

        Friend Property LC07 As String Implements LC.LC07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1073
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LC
            Dim rval As New LC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .LC02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .LC03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .LC04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .LC05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .LC06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .LC07 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Life Coverage</summary>
    '''<remarks>To provide information on life coverage</remarks>
    Public Interface LC
        Inherits ISegment

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property LC01 As String

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property LC02 As String

        '''<summary>Insurance Line Code</summary>
        '''<remarks></remarks>
        Property LC03 As String

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property LC04 As String

        '''<summary>Quantity</summary>
        '''<remarks>LC05 is the salary multiplier.</remarks>
        Property LC05 As Decimal?

        '''<summary>Product Option Code</summary>
        '''<remarks></remarks>
        Property LC06 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>LC07 is the employee signature on file indicator. A "Y" value indicates the employee signature has been obtained and is on file; an "N" value indicates the employee signature has not been obtained.</remarks>
        Property LC07 As String

    End Interface
End NameSpace