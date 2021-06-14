Namespace Segments
    '''<summary>Language Use</summary>
    '''<remarks>To specify language, type of usage, and proficiency or fluency</remarks>
    Partial Friend Class LUI_Obj
        Inherits Segment
        Implements LUI,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRuleListConditional(4, {2, 3})}

        Public Sub New()
            MyBase.New("LUI")
            Elements.AddRange({CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1303),
                                      CType(Nothing, DataElements.Element1476)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LUI01 As String Implements LUI.LUI01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI.LUI01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element66
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property LUI02 As String Implements LUI.LUI02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI.LUI02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element67
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property LUI03 As String Implements LUI.LUI03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI.LUI03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element352
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property LUI04 As String Implements LUI.LUI04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.LUI.LUI04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1303).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1303
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1303).Value = value
                End If
            End Set
        End Property

        Friend Property LUI05 As String Implements LUI.LUI05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1476).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1476
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1476).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LUI
            Dim rval As New LUI_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LUI01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .LUI02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .LUI03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .LUI04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .LUI05 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Language Use</summary>
    '''<remarks>To specify language, type of usage, and proficiency or fluency</remarks>
    Public Interface LUI
        Inherits ISegment

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property LUI01 As String

        '''<summary>Identification Code</summary>
        '''<remarks>LUI02 is the language code.</remarks>
        Property LUI02 As String

        '''<summary>Description</summary>
        '''<remarks>LUI03 is the name of the language.</remarks>
        Property LUI03 As String

        '''<summary>Use of Language Indicator</summary>
        '''<remarks></remarks>
        Property LUI04 As String

        '''<summary>Language Proficiency Indicator</summary>
        '''<remarks></remarks>
        Property LUI05 As String

    End Interface
End NameSpace