Namespace Segments
    '''<summary>Supporting Documentation</summary>
    '''<remarks>To specify information in response to a codified questionnaire document</remarks>
    Partial Friend Class FRM_Obj
        Inherits Segment
        Implements FRM,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({2, 3, 4, 5}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("FRM")
            Elements.AddRange({CType(Nothing, DataElements.Element350),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element332)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property FRM01 As String Implements FRM.FRM01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM.FRM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element350).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element350
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element350).Value = value
                End If
            End Set
        End Property

        Friend Property FRM02 As String Implements FRM.FRM02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM.FRM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1073
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property FRM03 As String Implements FRM.FRM03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM.FRM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property FRM04 As Date? Implements FRM.FRM04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM.FRM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element373
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property FRM05 As Decimal? Implements FRM.FRM05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.FRM.FRM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element332).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element332
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element332).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As FRM
            Dim rval As New FRM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .FRM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .FRM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .FRM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .FRM04 = source.ToDateValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .FRM05 = source.ToFloatValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Supporting Documentation</summary>
    '''<remarks>To specify information in response to a codified questionnaire document</remarks>
    Public Interface FRM
        Inherits ISegment

        '''<summary>Assigned Identification</summary>
        '''<remarks>FRM01 is the question number on a questionnaire or codified form.</remarks>
        Property FRM01 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>FRM02, FRM03, FRM04 and FRM05 are responses which only have meaning in reference to the question identified in FRM01.</remarks>
        Property FRM02 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property FRM03 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property FRM04 As Date?

        '''<summary>Percent, Decimal Format</summary>
        '''<remarks></remarks>
        Property FRM05 As Decimal?

    End Interface
End NameSpace