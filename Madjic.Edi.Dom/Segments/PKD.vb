Namespace Segments
    '''<summary>Packaging Description</summary>
    '''<remarks>To specify a package description and other information</remarks>
    Partial Friend Class PKD_Obj
        Inherits Segment
        Implements PKD
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(2, {1}),
                                                 New SyntaxRuleConditional(3, {2})}

        Public Sub New()
            MyBase.New("PKD")
            Elements.AddRange({CType(Nothing, DataElements.Element103),
                                      CType(Nothing, DataElements.Element822),
                                      CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element754),
                                      CType(Nothing, DataElements.Element102)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PKD01 As String Implements PKD.PKD01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element103).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element103
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element103).Value = value
                End If
            End Set
        End Property

        Friend Property PKD02 As String Implements PKD.PKD02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element822).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element822
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element822).Value = value
                End If
            End Set
        End Property

        Friend Property PKD03 As String Implements PKD.PKD03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element559
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property PKD04 As String Implements PKD.PKD04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element754).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element754
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element754).Value = value
                End If
            End Set
        End Property

        Friend Property PKD05 As String Implements PKD.PKD05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element102).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element102
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element102).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PKD
            Dim rval As New PKD_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PKD01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PKD02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PKD03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PKD04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PKD05 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Packaging Description</summary>
    '''<remarks>To specify a package description and other information</remarks>
    Public Interface PKD
        Inherits ISegment

        '''<summary>Packaging Code</summary>
        '''<remarks></remarks>
        Property PKD01 As String

        '''<summary>Source Subqualifier</summary>
        '''<remarks></remarks>
        Property PKD02 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks></remarks>
        Property PKD03 As String

        '''<summary>Packaging Description Code</summary>
        '''<remarks></remarks>
        Property PKD04 As String

        '''<summary>Ownership Code</summary>
        '''<remarks></remarks>
        Property PKD05 As String

    End Interface
End NameSpace