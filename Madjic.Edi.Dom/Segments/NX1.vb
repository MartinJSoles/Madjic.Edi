Namespace Segments
    '''<summary>Property or Entity Identification</summary>
    '''<remarks>To define the attributes of a property or an entity</remarks>
    Partial Friend Class NX1_Obj
        Inherits Segment
        Implements NX1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("NX1")
            Elements.AddRange({CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element98)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property NX101 As String Implements NX1.NX101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element98
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property NX102 As String Implements NX1.NX102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element98
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property NX103 As String Implements NX1.NX103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element98
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property NX104 As String Implements NX1.NX104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element98
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property NX105 As String Implements NX1.NX105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element98
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As NX1
            Dim rval As New NX1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .NX101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .NX102 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .NX103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .NX104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .NX105 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Property or Entity Identification</summary>
    '''<remarks>To define the attributes of a property or an entity</remarks>
    Public Interface NX1
        Inherits ISegment

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property NX101 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property NX102 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property NX103 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property NX104 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property NX105 As String

    End Interface
End NameSpace