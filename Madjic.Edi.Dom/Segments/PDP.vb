Namespace Segments
    '''<summary>Property Description - Personal</summary>
    '''<remarks>To provide a description of personal property</remarks>
    Partial Friend Class PDP_Obj
        Inherits Segment
        Implements PDP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PDP")
            Elements.AddRange({CType(Nothing, DataElements.Element1188),
                                      CType(Nothing, DataElements.Element23),
                                      CType(Nothing, DataElements.Element22)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PDP01 As String Implements PDP.PDP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1188).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1188
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1188).Value = value
                End If
            End Set
        End Property

        Friend Property PDP02 As String Implements PDP.PDP02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element23).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element23
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element23).Value = value
                End If
            End Set
        End Property

        Friend Property PDP03 As String Implements PDP.PDP03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element22).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element22
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element22).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PDP
            Dim rval As New PDP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PDP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PDP02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PDP03 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Property Description - Personal</summary>
    '''<remarks>To provide a description of personal property</remarks>
    Public Interface PDP
        Inherits ISegment

        '''<summary>Type of Personal or Business Asset Code</summary>
        '''<remarks></remarks>
        Property PDP01 As String

        '''<summary>Commodity Code Qualifier</summary>
        '''<remarks></remarks>
        Property PDP02 As String

        '''<summary>Commodity Code</summary>
        '''<remarks></remarks>
        Property PDP03 As String

    End Interface
End NameSpace