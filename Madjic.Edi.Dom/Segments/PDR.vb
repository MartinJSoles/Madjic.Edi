Namespace Segments
    '''<summary>Property Description - Real</summary>
    '''<remarks>To provide a description of real property</remarks>
    Partial Friend Class PDR_Obj
        Inherits Segment
        Implements PDR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PDR")
            Elements.AddRange({CType(Nothing, DataElements.Element1074),
                                      CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Element689)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PDR01 As String Implements PDR.PDR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1074).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1074
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1074).Value = value
                End If
            End Set
        End Property

        Friend Property PDR02 As String Implements PDR.PDR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1270
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property PDR03 As String Implements PDR.PDR03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1271
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property PDR04 As String Implements PDR.PDR04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element689).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element689
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element689).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PDR
            Dim rval As New PDR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PDR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PDR02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PDR03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PDR04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Property Description - Real</summary>
    '''<remarks>To provide a description of real property</remarks>
    Public Interface PDR
        Inherits ISegment

        '''<summary>Type of Real Estate Asset Code</summary>
        '''<remarks></remarks>
        Property PDR01 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property PDR02 As String

        '''<summary>Industry Code</summary>
        '''<remarks></remarks>
        Property PDR03 As String

        '''<summary>Occupancy Code</summary>
        '''<remarks></remarks>
        Property PDR04 As String

    End Interface
End NameSpace