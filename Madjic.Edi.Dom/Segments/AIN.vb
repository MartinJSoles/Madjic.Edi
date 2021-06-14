Namespace Segments
    '''<summary>Income</summary>
    '''<remarks>To provide type and amount of income obtained</remarks>
    Partial Friend Class AIN_Obj
        Inherits Segment
        Implements AIN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("AIN")
            Elements.AddRange({CType(Nothing, DataElements.Element1186),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element522),
                                      CType(Nothing, DataElements.Element1685),
                                      CType(Nothing, DataElements.Element1687),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AIN01 As String Implements AIN.AIN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1186).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1186
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1186).Value = value
                End If
            End Set
        End Property

        Friend Property AIN02 As String Implements AIN.AIN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element594
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property AIN03 As Decimal? Implements AIN.AIN03
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

        Friend Property AIN04 As Decimal? Implements AIN.AIN04
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

        Friend Property AIN05 As String Implements AIN.AIN05
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

        Friend Property AIN06 As String Implements AIN.AIN06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element127
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property AIN07 As String Implements AIN.AIN07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element522).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element522
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element522).Value = value
                End If
            End Set
        End Property

        Friend Property AIN08 As String Implements AIN.AIN08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1685).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1685
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1685).Value = value
                End If
            End Set
        End Property

        Friend Property AIN09 As Decimal? Implements AIN.AIN09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1687).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1687
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1687).Value = value
                End If
            End Set
        End Property

        Friend Property AIN10 As String Implements AIN.AIN10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element355
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property AIN11 As Decimal? Implements AIN.AIN11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element380
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property AIN12 As String Implements AIN.AIN12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1271
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property AIN13 As String Implements AIN.AIN13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element352
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AIN
            Dim rval As New AIN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AIN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AIN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .AIN03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .AIN04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .AIN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .AIN06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .AIN07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .AIN08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .AIN09 = source.ToFloatValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .AIN10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .AIN11 = source.ToFloatValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .AIN12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .AIN13 = source.ToStringValue(12)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Income</summary>
    '''<remarks>To provide type and amount of income obtained</remarks>
    Public Interface AIN
        Inherits ISegment

        '''<summary>Type of Income Code</summary>
        '''<remarks></remarks>
        Property AIN01 As String

        '''<summary>Frequency Code</summary>
        '''<remarks></remarks>
        Property AIN02 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property AIN03 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property AIN04 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks></remarks>
        Property AIN05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property AIN06 As String

        '''<summary>Amount Qualifier Code</summary>
        '''<remarks></remarks>
        Property AIN07 As String

        '''<summary>Tax Treatment Code</summary>
        '''<remarks></remarks>
        Property AIN08 As String

        '''<summary>Earnings Rate of Pay</summary>
        '''<remarks></remarks>
        Property AIN09 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property AIN10 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property AIN11 As Decimal?

        '''<summary>Industry Code</summary>
        '''<remarks></remarks>
        Property AIN12 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property AIN13 As String

    End Interface
End NameSpace