Namespace Segments
    '''<summary>Health Coverage</summary>
    '''<remarks>To provide information on health coverage</remarks>
    Partial Friend Class HD_Obj
        Inherits Segment
        Implements HD,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("HD")
            Elements.AddRange({CType(Nothing, DataElements.Element875),
                                      CType(Nothing, DataElements.Element1203),
                                      CType(Nothing, DataElements.Element1205),
                                      CType(Nothing, DataElements.Element1204),
                                      CType(Nothing, DataElements.Element1207),
                                      CType(Nothing, DataElements.Element609),
                                      CType(Nothing, DataElements.Element609),
                                      CType(Nothing, DataElements.Element1209),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1211),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HD01 As String Implements HD.HD01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD.HD01
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

        Friend Property HD02 As String Implements HD.HD02
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

        Friend Property HD03 As String Implements HD.HD03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD.HD03
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

        Friend Property HD04 As String Implements HD.HD04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD.HD04
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

        Friend Property HD05 As String Implements HD.HD05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD.HD05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1207).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1207
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1207).Value = value
                End If
            End Set
        End Property

        Friend Property HD06 As Decimal? Implements HD.HD06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element609).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element609
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element609).Value = value
                End If
            End Set
        End Property

        Friend Property HD07 As Decimal? Implements HD.HD07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element609).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element609
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element609).Value = value
                End If
            End Set
        End Property

        Friend Property HD08 As String Implements HD.HD08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1209).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1209
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1209).Value = value
                End If
            End Set
        End Property

        Friend Property HD09 As String Implements HD.HD09, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.HD.HD09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1073
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property HD10 As String Implements HD.HD10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1211).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1211
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1211).Value = value
                End If
            End Set
        End Property

        Friend Property HD11 As String Implements HD.HD11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1073
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HD
            Dim rval As New HD_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HD01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HD02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HD03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HD04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .HD05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .HD06 = source.ToDecimalValue(5, 0)
                End If
                If source.Elements.Count > 6 Then
                    .HD07 = source.ToDecimalValue(6, 0)
                End If
                If source.Elements.Count > 7 Then
                    .HD08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .HD09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .HD10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .HD11 = source.ToStringValue(10)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Coverage</summary>
    '''<remarks>To provide information on health coverage</remarks>
    Public Interface HD
        Inherits ISegment

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property HD01 As String

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property HD02 As String

        '''<summary>Insurance Line Code</summary>
        '''<remarks></remarks>
        Property HD03 As String

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property HD04 As String

        '''<summary>Coverage Level Code</summary>
        '''<remarks></remarks>
        Property HD05 As String

        '''<summary>Count</summary>
        '''<remarks>HD06 is the number of collateral dependents for the primary insured. A collateral dependent is a relative related by blood or marriage who resides in the home and is dependent on the employee for support.</remarks>
        Property HD06 As Decimal?

        '''<summary>Count</summary>
        '''<remarks>HD07 is the number of sponsored dependents for the primary insured. A sponsored dependent is a dependent between the ages of 19 and 25 who is not in school.</remarks>
        Property HD07 As Decimal?

        '''<summary>Underwriting Decision Code</summary>
        '''<remarks></remarks>
        Property HD08 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>HD09 is a late enrollee indicator. A "Y" value indicates the insured is a late enrollee, which can result in a reduction of benefits; an "N" value indicates the insured is a regular enrollee.</remarks>
        Property HD09 As String

        '''<summary>Drug House Code</summary>
        '''<remarks></remarks>
        Property HD10 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>HD11 is a prescription drug service coverage indicator. A "Y" value indicates that prescription drug service coverage applies; an "N" value indicates that prescription drug service coverage does not apply.</remarks>
        Property HD11 As String

    End Interface
End NameSpace