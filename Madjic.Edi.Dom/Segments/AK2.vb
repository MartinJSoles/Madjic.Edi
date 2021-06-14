Namespace Segments
    '''<summary>Transaction Set Response Header</summary>
    '''<remarks>To start acknowledgment of a single transaction set</remarks>
    Partial Friend Class AK2_Obj
        Inherits Segment
        Implements AK2,
                   Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("AK2")
            Elements.AddRange({CType(Nothing, DataElements.Element143),
                                      CType(Nothing, DataElements.Element329),
                                      CType(Nothing, DataElements.Element1705)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AK201 As String Implements AK2.AK201, Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2.AK201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element143).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element143
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element143).Value = value
                End If
            End Set
        End Property

        Friend Property AK202 As String Implements AK2.AK202, Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2.AK202
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element329).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element329
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element329).Value = value
                End If
            End Set
        End Property

        Friend Property AK203 As String Implements AK2.AK203, Transactions.Transaction999.Transaction999.Segments.Loop1000.AK2.AK203
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1705).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1705
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1705).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AK2
            Dim rval As New AK2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AK201 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AK202 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .AK203 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Set Response Header</summary>
    '''<remarks>To start acknowledgment of a single transaction set</remarks>
    Public Interface AK2
        Inherits ISegment

        '''<summary>Transaction Set Identifier Code</summary>
        '''<remarks></remarks>
        Property AK201 As String

        '''<summary>Transaction Set Control Number</summary>
        '''<remarks></remarks>
        Property AK202 As String

        '''<summary>Implementation Convention Reference</summary>
        '''<remarks></remarks>
        Property AK203 As String

    End Interface
End NameSpace