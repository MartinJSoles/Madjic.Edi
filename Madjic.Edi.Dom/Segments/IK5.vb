Namespace Segments
    '''<summary>Implementation Transaction Set Response Trailer</summary>
    '''<remarks>To acknowledge acceptance or rejection and report implementation errors in a transaction set</remarks>
    Partial Friend Class IK5_Obj
        Inherits Segment
        Implements IK5,
                   Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("IK5")
            Elements.AddRange({CType(Nothing, DataElements.Element717),
                                      CType(Nothing, DataElements.Element618),
                                      CType(Nothing, DataElements.Element618),
                                      CType(Nothing, DataElements.Element618),
                                      CType(Nothing, DataElements.Element618),
                                      CType(Nothing, DataElements.Element618)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property IK501 As String Implements IK5.IK501, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK501
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element717).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element717
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element717).Value = value
                End If
            End Set
        End Property

        Friend Property IK502 As String Implements IK5.IK502, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK502
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element618).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element618
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element618).Value = value
                End If
            End Set
        End Property

        Friend Property IK503 As String Implements IK5.IK503, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK503
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element618).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element618
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element618).Value = value
                End If
            End Set
        End Property

        Friend Property IK504 As String Implements IK5.IK504, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK504
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element618).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element618
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element618).Value = value
                End If
            End Set
        End Property

        Friend Property IK505 As String Implements IK5.IK505, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK505
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element618).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element618
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element618).Value = value
                End If
            End Set
        End Property

        Friend Property IK506 As String Implements IK5.IK506, Transactions.Transaction999.Transaction999.Segments.Loop1000.IK5.IK506
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element618).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element618
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element618).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IK5
            Dim rval As New IK5_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .IK501 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .IK502 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .IK503 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IK504 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .IK505 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .IK506 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Implementation Transaction Set Response Trailer</summary>
    '''<remarks>To acknowledge acceptance or rejection and report implementation errors in a transaction set</remarks>
    Public Interface IK5
        Inherits ISegment

        '''<summary>Transaction Set Acknowledgment Code</summary>
        '''<remarks></remarks>
        Property IK501 As String

        '''<summary>Implementation Transaction Set Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK502 As String

        '''<summary>Implementation Transaction Set Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK503 As String

        '''<summary>Implementation Transaction Set Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK504 As String

        '''<summary>Implementation Transaction Set Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK505 As String

        '''<summary>Implementation Transaction Set Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK506 As String

    End Interface
End NameSpace