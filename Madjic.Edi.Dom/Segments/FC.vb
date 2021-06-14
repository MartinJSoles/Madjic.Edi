Namespace Segments
    '''<summary>Financial Contribution</summary>
    '''<remarks>To specify the financial contribution information</remarks>
    Partial Friend Class FC_Obj
        Inherits Segment
        Implements FC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("FC")
            Elements.AddRange({CType(Nothing, DataElements.Element1224),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1470),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property FC01 As String Implements FC.FC01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1224).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1224
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1224).Value = value
                End If
            End Set
        End Property

        Friend Property FC02 As Decimal? Implements FC.FC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element954
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property FC03 As Decimal? Implements FC.FC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element782
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property FC04 As Decimal? Implements FC.FC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1470
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Property FC05 As String Implements FC.FC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1073
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As FC
            Dim rval As New FC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .FC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .FC02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .FC03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .FC04 = source.ToDecimalValue(3, 0)
                End If
                If source.Elements.Count > 4 Then
                    .FC05 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Financial Contribution</summary>
    '''<remarks>To specify the financial contribution information</remarks>
    Public Interface FC
        Inherits ISegment

        '''<summary>Contribution Code</summary>
        '''<remarks></remarks>
        Property FC01 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>FC02 is the percent of salary an employee elects to contribute.</remarks>
        Property FC02 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>FC03 is the dollar amount of the contribution.</remarks>
        Property FC03 As Decimal?

        '''<summary>Number</summary>
        '''<remarks>FC04 is the number of payments per year.</remarks>
        Property FC04 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>FC05 is the billing indicator. A "Y" value indicates that the participant is billed for this type of money; an "N" value indicates that the participant is not billed for this type of money.</remarks>
        Property FC05 As String

    End Interface
End NameSpace