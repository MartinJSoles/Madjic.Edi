Namespace Segments
    '''<summary>Immunization Status</summary>
    '''<remarks>To provide the receiving school district or postsecondary institution with a notice of the immunization status of the student</remarks>
    Partial Friend Class IMM_Obj
        Inherits Segment
        Implements IMM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3}),
                                                 New SyntaxRuleConditional(3, {4}),
                                                 New SyntaxRuleAllRequired({1, 6})}

        Public Sub New()
            MyBase.New("IMM")
            Elements.AddRange({CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element1254),
                                      CType(Nothing, DataElements.Element755),
                                      CType(Nothing, DataElements.Element1270)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property IMM01 As String Implements IMM.IMM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1271
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property IMM02 As String Implements IMM.IMM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1250
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property IMM03 As String Implements IMM.IMM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1251
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property IMM04 As String Implements IMM.IMM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1254).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1254
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1254).Value = value
                End If
            End Set
        End Property

        Friend Property IMM05 As String Implements IMM.IMM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element755).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element755
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element755).Value = value
                End If
            End Set
        End Property

        Friend Property IMM06 As String Implements IMM.IMM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1270
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IMM
            Dim rval As New IMM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .IMM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .IMM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .IMM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IMM04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .IMM05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .IMM06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Immunization Status</summary>
    '''<remarks>To provide the receiving school district or postsecondary institution with a notice of the immunization status of the student</remarks>
    Public Interface IMM
        Inherits ISegment

        '''<summary>Industry Code</summary>
        '''<remarks>IMM01 and IMM06 refer to Immunization Type.</remarks>
        Property IMM01 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property IMM02 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>IMM03 gives the date of the immunization.</remarks>
        Property IMM03 As String

        '''<summary>Immunization Status Code</summary>
        '''<remarks></remarks>
        Property IMM04 As String

        '''<summary>Report Type Code</summary>
        '''<remarks></remarks>
        Property IMM05 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property IMM06 As String

    End Interface
End NameSpace