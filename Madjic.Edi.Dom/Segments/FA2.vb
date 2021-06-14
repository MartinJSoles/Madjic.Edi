Namespace Segments
    '''<summary>Accounting Data</summary>
    '''<remarks>To specify the detailed accounting data</remarks>
    Partial Friend Class FA2_Obj
        Inherits Segment
        Implements FA2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("FA2")
            Elements.AddRange({CType(Nothing, DataElements.Element1196),
                                      CType(Nothing, DataElements.Element1195)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property FA201 As String Implements FA2.FA201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1196).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1196
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1196).Value = value
                End If
            End Set
        End Property

        Friend Property FA202 As String Implements FA2.FA202
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1195).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1195
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1195).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As FA2
            Dim rval As New FA2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .FA201 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .FA202 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Accounting Data</summary>
    '''<remarks>To specify the detailed accounting data</remarks>
    Public Interface FA2
        Inherits ISegment

        '''<summary>Breakdown Structure Detail Code</summary>
        '''<remarks></remarks>
        Property FA201 As String

        '''<summary>Financial Information Code</summary>
        '''<remarks></remarks>
        Property FA202 As String

    End Interface
End NameSpace