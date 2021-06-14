Namespace Segments
    '''<summary>Investment Vehicle Selection</summary>
    '''<remarks>To specify type of investment vehicle or account and other basic data about the investment</remarks>
    Partial Friend Class INV_Obj
        Inherits Segment
        Implements INV
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleExclusion({2, 3, 4}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("INV")
            Elements.AddRange({CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element782)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property INV01 As String Implements INV.INV01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element352
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property INV02 As Decimal? Implements INV.INV02
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

        Friend Property INV03 As Decimal? Implements INV.INV03
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

        Friend Property INV04 As Decimal? Implements INV.INV04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element380
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property INV05 As String Implements INV.INV05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element156
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property INV06 As String Implements INV.INV06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element352
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property INV07 As Decimal? Implements INV.INV07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element782
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As INV
            Dim rval As New INV_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .INV01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .INV02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .INV03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .INV04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .INV05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .INV06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .INV07 = source.ToFloatValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Investment Vehicle Selection</summary>
    '''<remarks>To specify type of investment vehicle or account and other basic data about the investment</remarks>
    Public Interface INV
        Inherits ISegment

        '''<summary>Description</summary>
        '''<remarks>INV01 is the investment fund description of the "receiving" or "to" investment fund.</remarks>
        Property INV01 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>INV02 is the percent of contribution amount to be deposited into the investment fund described in INV01.</remarks>
        Property INV02 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>INV03 is the dollar amount to be deposited into the investment fund described in INV01.</remarks>
        Property INV03 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>INV04 is the number of units or shares to be invested in the investment fund described in INV01.</remarks>
        Property INV04 As Decimal?

        '''<summary>State or Province Code</summary>
        '''<remarks>INV05 is the state of sale for the investment fund described in INV01.</remarks>
        Property INV05 As String

        '''<summary>Description</summary>
        '''<remarks>INV06 is the "originating" or "from" investment fund description for an interfund transfer.</remarks>
        Property INV06 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>INV07 is the current balance of the investment fund described in INV01.</remarks>
        Property INV07 As Decimal?

    End Interface
End NameSpace