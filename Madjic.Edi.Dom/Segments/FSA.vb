Namespace Segments
    '''<summary>Flexible Spending Account</summary>
    '''<remarks>To supply flexible spending account information</remarks>
    Partial Friend Class FSA_Obj
        Inherits Segment
        Implements FSA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("FSA")
            Elements.AddRange({CType(Nothing, DataElements.Element875),
                                      CType(Nothing, DataElements.Element1202),
                                      CType(Nothing, DataElements.Element1203),
                                      CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element1204),
                                      CType(Nothing, DataElements.Element1161),
                                      CType(Nothing, DataElements.Element1161),
                                      CType(Nothing, DataElements.Element1161)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property FSA01 As String Implements FSA.FSA01
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

        Friend Property FSA02 As String Implements FSA.FSA02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1202).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1202
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1202).Value = value
                End If
            End Set
        End Property

        Friend Property FSA03 As String Implements FSA.FSA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1203).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1203
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1203).Value = value
                End If
            End Set
        End Property

        Friend Property FSA04 As String Implements FSA.FSA04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element508
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property FSA05 As String Implements FSA.FSA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element594
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property FSA06 As String Implements FSA.FSA06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1204).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1204
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1204).Value = value
                End If
            End Set
        End Property

        Friend Property FSA07 As String Implements FSA.FSA07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1161).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1161
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1161).Value = value
                End If
            End Set
        End Property

        Friend Property FSA08 As String Implements FSA.FSA08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1161).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1161
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1161).Value = value
                End If
            End Set
        End Property

        Friend Property FSA09 As String Implements FSA.FSA09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1161).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1161
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1161).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As FSA
            Dim rval As New FSA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .FSA01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .FSA02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .FSA03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .FSA04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .FSA05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .FSA06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .FSA07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .FSA08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .FSA09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Flexible Spending Account</summary>
    '''<remarks>To supply flexible spending account information</remarks>
    Public Interface FSA
        Inherits ISegment

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property FSA01 As String

        '''<summary>Flexible Spending Account Selection Code</summary>
        '''<remarks></remarks>
        Property FSA02 As String

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property FSA03 As String

        '''<summary>Account Number</summary>
        '''<remarks>FSA04 is the flexible spending account (FSA) policy number.</remarks>
        Property FSA04 As String

        '''<summary>Frequency Code</summary>
        '''<remarks>FSA05 specifies the frequency of contribution.</remarks>
        Property FSA05 As String

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property FSA06 As String

        '''<summary>Product Option Code</summary>
        '''<remarks></remarks>
        Property FSA07 As String

        '''<summary>Product Option Code</summary>
        '''<remarks></remarks>
        Property FSA08 As String

        '''<summary>Product Option Code</summary>
        '''<remarks></remarks>
        Property FSA09 As String

    End Interface
End NameSpace