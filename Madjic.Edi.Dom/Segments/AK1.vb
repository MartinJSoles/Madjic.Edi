Namespace Segments
    '''<summary>Function Group Response Header</summary>
    '''<remarks>To start acknowledgment of a functional group</remarks>
    Partial Friend Class AK1_Obj
        Inherits Segment
        Implements AK1,
                   Transactions.Transaction999.Transaction999.Segments.AK1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("AK1")
            Elements.AddRange({CType(Nothing, DataElements.Element479),
                                      CType(Nothing, DataElements.Element28),
                                      CType(Nothing, DataElements.Element480)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AK101 As String Implements AK1.AK101, Transactions.Transaction999.Transaction999.Segments.AK1.AK101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element479).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element479
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element479).Value = value
                End If
            End Set
        End Property

        Friend Property AK102 As Decimal? Implements AK1.AK102, Transactions.Transaction999.Transaction999.Segments.AK1.AK102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element28).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element28
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element28).Value = value
                End If
            End Set
        End Property

        Friend Property AK103 As String Implements AK1.AK103, Transactions.Transaction999.Transaction999.Segments.AK1.AK103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element480).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element480
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element480).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AK1
            Dim rval As New AK1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AK101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AK102 = source.ToDecimalValue(1, 0)
                End If
                If source.Elements.Count > 2 Then
                    .AK103 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Function Group Response Header</summary>
    '''<remarks>To start acknowledgment of a functional group</remarks>
    Public Interface AK1
        Inherits ISegment

        '''<summary>Functional Identifier Code</summary>
        '''<remarks></remarks>
        Property AK101 As String

        '''<summary>Group Control Number</summary>
        '''<remarks></remarks>
        Property AK102 As Decimal?

        '''<summary>Version / Release / Industry Identifier Code</summary>
        '''<remarks></remarks>
        Property AK103 As String

    End Interface
End NameSpace