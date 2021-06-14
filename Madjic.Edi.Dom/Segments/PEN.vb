Namespace Segments
    '''<summary>Pension Information</summary>
    '''<remarks>To specify financial activity for a pension plan</remarks>
    Partial Friend Class PEN_Obj
        Inherits Segment
        Implements PEN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PEN")
            Elements.AddRange({CType(Nothing, DataElements.Element640),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1224),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element1296),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1470),
                                      CType(Nothing, DataElements.Element1262),
                                      CType(Nothing, DataElements.Element875)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PEN01 As String Implements PEN.PEN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element640).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element640
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element640).Value = value
                End If
            End Set
        End Property

        Friend Property PEN02 As Decimal? Implements PEN.PEN02
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

        Friend Property PEN03 As String Implements PEN.PEN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1224).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1224
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1224).Value = value
                End If
            End Set
        End Property

        Friend Property PEN04 As Decimal? Implements PEN.PEN04
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

        Friend Property PEN05 As String Implements PEN.PEN05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1296).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1296
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1296).Value = value
                End If
            End Set
        End Property

        Friend Property PEN06 As String Implements PEN.PEN06
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

        Friend Property PEN07 As Decimal? Implements PEN.PEN07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1470
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Property PEN08 As String Implements PEN.PEN08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1262).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1262
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1262).Value = value
                End If
            End Set
        End Property

        Friend Property PEN09 As String Implements PEN.PEN09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element875).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element875
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element875).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PEN
            Dim rval As New PEN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PEN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PEN02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PEN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PEN04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PEN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PEN06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .PEN07 = source.ToDecimalValue(6, 0)
                End If
                If source.Elements.Count > 7 Then
                    .PEN08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .PEN09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Pension Information</summary>
    '''<remarks>To specify financial activity for a pension plan</remarks>
    Public Interface PEN
        Inherits ISegment

        '''<summary>Transaction Type Code</summary>
        '''<remarks></remarks>
        Property PEN01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property PEN02 As Decimal?

        '''<summary>Contribution Code</summary>
        '''<remarks></remarks>
        Property PEN03 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks></remarks>
        Property PEN04 As Decimal?

        '''<summary>Special Processing Type</summary>
        '''<remarks></remarks>
        Property PEN05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property PEN06 As String

        '''<summary>Number</summary>
        '''<remarks></remarks>
        Property PEN07 As Decimal?

        '''<summary>Loan Type Code</summary>
        '''<remarks></remarks>
        Property PEN08 As String

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property PEN09 As String

    End Interface
End NameSpace