Namespace Segments
    '''<summary>Percent Amounts</summary>
    '''<remarks>To qualify percent amounts and supply percent amounts</remarks>
    Partial Friend Class PCT_Obj
        Inherits Segment
        Implements PCT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("PCT")
            Elements.AddRange({CType(Nothing, DataElements.Element1004),
                                      CType(Nothing, DataElements.Element954)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PCT01 As String Implements PCT.PCT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1004).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1004
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1004).Value = value
                End If
            End Set
        End Property

        Friend Property PCT02 As Decimal? Implements PCT.PCT02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element954
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PCT
            Dim rval As New PCT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PCT01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PCT02 = source.ToFloatValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Percent Amounts</summary>
    '''<remarks>To qualify percent amounts and supply percent amounts</remarks>
    Public Interface PCT
        Inherits ISegment

        '''<summary>Percent Qualifier</summary>
        '''<remarks></remarks>
        Property PCT01 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks></remarks>
        Property PCT02 As Decimal?

    End Interface
End NameSpace