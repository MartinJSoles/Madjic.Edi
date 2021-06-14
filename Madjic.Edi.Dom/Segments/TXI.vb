Namespace Segments
    '''<summary>Tax Information</summary>
    '''<remarks>To specify tax information</remarks>
    Partial Friend Class TXI_Obj
        Inherits Segment
        Implements TXI
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("TXI")
            Elements.AddRange({CType(Nothing, DataElements.Element963),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element955),
                                      CType(Nothing, DataElements.Element956),
                                      CType(Nothing, DataElements.Element441),
                                      CType(Nothing, DataElements.Element662),
                                      CType(Nothing, DataElements.Element828),
                                      CType(Nothing, DataElements.Element325),
                                      CType(Nothing, DataElements.Element350)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TXI01 As String Implements TXI.TXI01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element963).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element963
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element963).Value = value
                End If
            End Set
        End Property

        Friend Property TXI02 As Decimal? Implements TXI.TXI02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element782
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property TXI03 As Decimal? Implements TXI.TXI03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element954
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property TXI04 As String Implements TXI.TXI04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element955).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element955
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element955).Value = value
                End If
            End Set
        End Property

        Friend Property TXI05 As String Implements TXI.TXI05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element956).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element956
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element956).Value = value
                End If
            End Set
        End Property

        Friend Property TXI06 As String Implements TXI.TXI06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element441).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element441
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element441).Value = value
                End If
            End Set
        End Property

        Friend Property TXI07 As String Implements TXI.TXI07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element662).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element662
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element662).Value = value
                End If
            End Set
        End Property

        Friend Property TXI08 As Decimal? Implements TXI.TXI08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element828).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element828
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element828).Value = value
                End If
            End Set
        End Property

        Friend Property TXI09 As String Implements TXI.TXI09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element325).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element325
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element325).Value = value
                End If
            End Set
        End Property

        Friend Property TXI10 As String Implements TXI.TXI10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element350
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element350).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TXI
            Dim rval As New TXI_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TXI01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TXI02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TXI03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TXI04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .TXI05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .TXI06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .TXI07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .TXI08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .TXI09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .TXI10 = source.ToStringValue(9)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Tax Information</summary>
    '''<remarks>To specify tax information</remarks>
    Public Interface TXI
        Inherits ISegment

        '''<summary>Tax Type Code</summary>
        '''<remarks></remarks>
        Property TXI01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property TXI02 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks></remarks>
        Property TXI03 As Decimal?

        '''<summary>Tax Jurisdiction Code Qualifier</summary>
        '''<remarks></remarks>
        Property TXI04 As String

        '''<summary>Tax Jurisdiction Code</summary>
        '''<remarks></remarks>
        Property TXI05 As String

        '''<summary>Tax Exempt Code</summary>
        '''<remarks></remarks>
        Property TXI06 As String

        '''<summary>Relationship Code</summary>
        '''<remarks></remarks>
        Property TXI07 As String

        '''<summary>Dollar Basis For Percent</summary>
        '''<remarks></remarks>
        Property TXI08 As Decimal?

        '''<summary>Tax Identification Number</summary>
        '''<remarks></remarks>
        Property TXI09 As String

        '''<summary>Assigned Identification</summary>
        '''<remarks></remarks>
        Property TXI10 As String

    End Interface
End NameSpace