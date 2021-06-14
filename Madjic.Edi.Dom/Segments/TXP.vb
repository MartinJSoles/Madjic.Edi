Namespace Segments
    '''<summary>Tax Payment</summary>
    '''<remarks>To identify tax payment data</remarks>
    Partial Friend Class TXP_Obj
        Inherits Segment
        Implements TXP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5})}

        Public Sub New()
            MyBase.New("TXP")
            Elements.AddRange({CType(Nothing, DataElements.Element325),
                                      CType(Nothing, DataElements.Element1049),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element817),
                                      CType(Nothing, DataElements.Element1051),
                                      CType(Nothing, DataElements.Element817),
                                      CType(Nothing, DataElements.Element1051),
                                      CType(Nothing, DataElements.Element817),
                                      CType(Nothing, DataElements.Element1051),
                                      CType(Nothing, DataElements.Element1050)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TXP01 As String Implements TXP.TXP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element325).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element325
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element325).Value = value
                End If
            End Set
        End Property

        Friend Property TXP02 As String Implements TXP.TXP02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1049).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1049
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1049).Value = value
                End If
            End Set
        End Property

        Friend Property TXP03 As Date? Implements TXP.TXP03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element373
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property TXP04 As String Implements TXP.TXP04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element817).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element817
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element817).Value = value
                End If
            End Set
        End Property

        Friend Property TXP05 As Decimal? Implements TXP.TXP05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1051).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1051
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1051).Value = value
                End If
            End Set
        End Property

        Friend Property TXP06 As String Implements TXP.TXP06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element817).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element817
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element817).Value = value
                End If
            End Set
        End Property

        Friend Property TXP07 As Decimal? Implements TXP.TXP07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1051).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1051
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1051).Value = value
                End If
            End Set
        End Property

        Friend Property TXP08 As String Implements TXP.TXP08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element817).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element817
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element817).Value = value
                End If
            End Set
        End Property

        Friend Property TXP09 As Decimal? Implements TXP.TXP09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1051).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1051
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1051).Value = value
                End If
            End Set
        End Property

        Friend Property TXP10 As String Implements TXP.TXP10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1050).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1050
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1050).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TXP
            Dim rval As New TXP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TXP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TXP02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TXP03 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TXP04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .TXP05 = source.ToDecimalValue(4, 2)
                End If
                If source.Elements.Count > 5 Then
                    .TXP06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .TXP07 = source.ToDecimalValue(6, 2)
                End If
                If source.Elements.Count > 7 Then
                    .TXP08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .TXP09 = source.ToDecimalValue(8, 2)
                End If
                If source.Elements.Count > 9 Then
                    .TXP10 = source.ToStringValue(9)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Tax Payment</summary>
    '''<remarks>To identify tax payment data</remarks>
    Public Interface TXP
        Inherits ISegment

        '''<summary>Tax Identification Number</summary>
        '''<remarks></remarks>
        Property TXP01 As String

        '''<summary>Tax Payment Type Code</summary>
        '''<remarks></remarks>
        Property TXP02 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property TXP03 As Date?

        '''<summary>Tax Information Identification Number</summary>
        '''<remarks></remarks>
        Property TXP04 As String

        '''<summary>Tax Amount</summary>
        '''<remarks></remarks>
        Property TXP05 As Decimal?

        '''<summary>Tax Information Identification Number</summary>
        '''<remarks></remarks>
        Property TXP06 As String

        '''<summary>Tax Amount</summary>
        '''<remarks></remarks>
        Property TXP07 As Decimal?

        '''<summary>Tax Information Identification Number</summary>
        '''<remarks></remarks>
        Property TXP08 As String

        '''<summary>Tax Amount</summary>
        '''<remarks></remarks>
        Property TXP09 As Decimal?

        '''<summary>Taxpayer Verification</summary>
        '''<remarks></remarks>
        Property TXP10 As String

    End Interface
End NameSpace