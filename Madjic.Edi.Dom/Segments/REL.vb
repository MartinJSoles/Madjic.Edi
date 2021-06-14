Namespace Segments
    '''<summary>Relationship</summary>
    '''<remarks>To specify relationship and birth order of entity</remarks>
    Partial Friend Class REL_Obj
        Inherits Segment
        Implements REL
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("REL")
            Elements.AddRange({CType(Nothing, DataElements.Element1069),
                                      CType(Nothing, DataElements.Element1470)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property REL01 As String Implements REL.REL01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1069).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1069
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1069).Value = value
                End If
            End Set
        End Property

        Friend Property REL02 As Decimal? Implements REL.REL02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1470
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As REL
            Dim rval As New REL_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .REL01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .REL02 = source.ToDecimalValue(1, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Relationship</summary>
    '''<remarks>To specify relationship and birth order of entity</remarks>
    Public Interface REL
        Inherits ISegment

        '''<summary>Individual Relationship Code</summary>
        '''<remarks></remarks>
        Property REL01 As String

        '''<summary>Number</summary>
        '''<remarks>REL02 is an ordinal number indicating birth order.</remarks>
        Property REL02 As Decimal?

    End Interface
End NameSpace