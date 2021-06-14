Namespace Segments
    '''<summary>Loop Header</summary>
    '''<remarks>To indicate that the next segment begins a loop</remarks>
    Partial Friend Class LS_Obj
        Inherits Segment
        Implements LS,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.LS,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.LS,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("LS")
            Elements.AddRange({CType(Nothing, DataElements.Element447)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LS01 As String Implements LS.LS01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.LS.LS01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.LS.LS01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LS.LS01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element447).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element447
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element447).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LS
            Dim rval As New LS_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LS01 = source.ToStringValue(0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Loop Header</summary>
    '''<remarks>To indicate that the next segment begins a loop</remarks>
    Public Interface LS
        Inherits ISegment

        '''<summary>Loop Identifier Code</summary>
        '''<remarks></remarks>
        Property LS01 As String

    End Interface
End NameSpace