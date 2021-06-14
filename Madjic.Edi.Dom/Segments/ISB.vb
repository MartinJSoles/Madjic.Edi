Namespace Segments
    '''<summary>Grade of Service Request Segment</summary>
    '''<remarks>To request a delivery priority for this interchange higher or lower than normally provided</remarks>
    Partial Friend Class ISB_Obj
        Inherits Segment
        Implements ISB
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("ISB")
            Elements.AddRange({CType(Nothing, DataElements.ElementI34)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ISB01 As String Implements ISB.ISB01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.ElementI34).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.ElementI34
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.ElementI34).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ISB
            Dim rval As New ISB_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ISB01 = source.ToStringValue(0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Grade of Service Request Segment</summary>
    '''<remarks>To request a delivery priority for this interchange higher or lower than normally provided</remarks>
    Public Interface ISB
        Inherits ISegment

        '''<summary>Grade of Service Code</summary>
        '''<remarks></remarks>
        Property ISB01 As String

    End Interface
End NameSpace