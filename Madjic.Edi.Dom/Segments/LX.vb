Namespace Segments
    '''<summary>Transaction Set Line Number</summary>
    '''<remarks>To reference a line number in a transaction set</remarks>
    Partial Friend Class LX_Obj
        Inherits Segment
        Implements LX,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.LX,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.LX,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.LX
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("LX")
            Elements.AddRange({CType(Nothing, DataElements.Element554)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property LX01 As Decimal? Implements LX.LX01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.LX.LX01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2700.LX.LX01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2000.LX.LX01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.LX.LX01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.LX.LX01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2400.LX.LX01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element554).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element554
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element554).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As LX
            Dim rval As New LX_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .LX01 = source.ToDecimalValue(0, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Set Line Number</summary>
    '''<remarks>To reference a line number in a transaction set</remarks>
    Public Interface LX
        Inherits ISegment

        '''<summary>Assigned Number</summary>
        '''<remarks></remarks>
        Property LX01 As Decimal?

    End Interface
End NameSpace