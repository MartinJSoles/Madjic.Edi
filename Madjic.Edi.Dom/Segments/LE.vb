Namespace Segments
    '''<summary>Loop Trailer</summary>
    '''<remarks>To indicate that the loop immediately preceding this segment is complete</remarks>
    Partial Friend Class LE_Obj
        Inherits Segment
        Implements LE,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.LE,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.LE,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("LE")
            Elements.AddRange({CType(Nothing, DataElements.Element447)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LE01 As String Implements LE.LE01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.LE.LE01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.LE.LE01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2000.LE.LE01
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LE
            Dim rval As New LE_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LE01 = source.ToStringValue(0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Loop Trailer</summary>
    '''<remarks>To indicate that the loop immediately preceding this segment is complete</remarks>
    Public Interface LE
        Inherits ISegment

        '''<summary>Loop Identifier Code</summary>
        '''<remarks></remarks>
        Property LE01 As String

    End Interface
End NameSpace