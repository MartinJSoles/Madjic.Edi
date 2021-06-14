Namespace Segments
    '''<summary>Peer Review Organization or Utilization Review</summary>
    '''<remarks>To specify the results of the utilization review</remarks>
    Partial Friend Class UR_Obj
        Inherits Segment
        Implements UR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("UR")
            Elements.AddRange({CType(Nothing, DataElements.Element1318),
                                      CType(Nothing, DataElements.Element380)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property UR01 As String Implements UR.UR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1318).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1318
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1318).Value = value
                End If
            End Set
        End Property

        Friend Property UR02 As Decimal? Implements UR.UR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element380
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As UR
            Dim rval As New UR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .UR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .UR02 = source.ToFloatValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Peer Review Organization or Utilization Review</summary>
    '''<remarks>To specify the results of the utilization review</remarks>
    Public Interface UR
        Inherits ISegment

        '''<summary>Approval Code</summary>
        '''<remarks></remarks>
        Property UR01 As String

        '''<summary>Quantity</summary>
        '''<remarks>UR02 is the number of grace days.</remarks>
        Property UR02 As Decimal?

    End Interface
End NameSpace