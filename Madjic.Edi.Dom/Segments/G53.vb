Namespace Segments
    '''<summary>Maintenance Type</summary>
    '''<remarks>To identify the specific type of item maintenance</remarks>
    Partial Friend Class G53_Obj
        Inherits Segment
        Implements G53
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("G53")
            Elements.AddRange({CType(Nothing, DataElements.Element875)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property G5301 As String Implements G53.G5301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element875).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element875
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element875).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As G53
            Dim rval As New G53_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .G5301 = source.ToStringValue(0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Maintenance Type</summary>
    '''<remarks>To identify the specific type of item maintenance</remarks>
    Public Interface G53
        Inherits ISegment

        '''<summary>Maintenance Type Code</summary>
        '''<remarks></remarks>
        Property G5301 As String

    End Interface
End NameSpace