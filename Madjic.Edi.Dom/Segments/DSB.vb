Namespace Segments
    '''<summary>Disability Information</summary>
    '''<remarks>To supply disability information</remarks>
    Partial Friend Class DSB_Obj
        Inherits Segment
        Implements DSB,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({7, 8}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("DSB")
            Elements.AddRange({CType(Nothing, DataElements.Element1146),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1149),
                                      CType(Nothing, DataElements.Element1154),
                                      CType(Nothing, DataElements.Element1161),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element235),
                                      CType(Nothing, DataElements.Element1137)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DSB01 As String Implements DSB.DSB01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB.DSB01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1146).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1146
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1146).Value = value
                End If
            End Set
        End Property

        Friend Property DSB02 As Decimal? Implements DSB.DSB02
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

        Friend Property DSB03 As String Implements DSB.DSB03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1149).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1149
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1149).Value = value
                End If
            End Set
        End Property

        Friend Property DSB04 As String Implements DSB.DSB04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1154).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1154
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1154).Value = value
                End If
            End Set
        End Property

        Friend Property DSB05 As String Implements DSB.DSB05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1161).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1161
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1161).Value = value
                End If
            End Set
        End Property

        Friend Property DSB06 As Decimal? Implements DSB.DSB06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element782
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property DSB07 As String Implements DSB.DSB07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB.DSB07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element235).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element235
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element235).Value = value
                End If
            End Set
        End Property

        Friend Property DSB08 As String Implements DSB.DSB08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2200.DSB.DSB08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1137).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1137
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1137).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DSB
            Dim rval As New DSB_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DSB01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DSB02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DSB03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DSB04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .DSB05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .DSB06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .DSB07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .DSB08 = source.ToStringValue(7)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Disability Information</summary>
    '''<remarks>To supply disability information</remarks>
    Public Interface DSB
        Inherits ISegment

        '''<summary>Disability Type Code</summary>
        '''<remarks></remarks>
        Property DSB01 As String

        '''<summary>Quantity</summary>
        '''<remarks>DSB02 is scheduled work days before the disability.</remarks>
        Property DSB02 As Decimal?

        '''<summary>Occupation Code</summary>
        '''<remarks></remarks>
        Property DSB03 As String

        '''<summary>Work Intensity Code</summary>
        '''<remarks></remarks>
        Property DSB04 As String

        '''<summary>Product Option Code</summary>
        '''<remarks></remarks>
        Property DSB05 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>DSB06 is the maximum amount of disability coverage to which the insured is entitled.</remarks>
        Property DSB06 As Decimal?

        '''<summary>Product/Service ID Qualifier</summary>
        '''<remarks></remarks>
        Property DSB07 As String

        '''<summary>Medical Code Value</summary>
        '''<remarks>DSB08 is the functional status code for the disability.</remarks>
        Property DSB08 As String

    End Interface
End NameSpace