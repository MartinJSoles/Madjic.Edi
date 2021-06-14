Namespace Segments
    '''<summary>Industry Code Identification</summary>
    '''<remarks>To identify standard industry codes</remarks>
    Partial Friend Class LQ_Obj
        Inherits Segment
        Implements LQ,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.LQ
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(1, {2})}

        Public Sub New()
            MyBase.New("LQ")
            Elements.AddRange({CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LQ01 As String Implements LQ.LQ01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ.LQ01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.LQ.LQ01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1270
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property LQ02 As String Implements LQ.LQ02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.LQ.LQ02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2440.LQ.LQ02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1271
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LQ
            Dim rval As New LQ_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LQ01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .LQ02 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Industry Code Identification</summary>
    '''<remarks>To identify standard industry codes</remarks>
    Public Interface LQ
        Inherits ISegment

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property LQ01 As String

        '''<summary>Industry Code</summary>
        '''<remarks></remarks>
        Property LQ02 As String

    End Interface
End NameSpace