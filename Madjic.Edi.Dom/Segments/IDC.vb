Namespace Segments
    '''<summary>Identification Card</summary>
    '''<remarks>To provide notification to produce replacement identification card(s)</remarks>
    Partial Friend Class IDC_Obj
        Inherits Segment
        Implements IDC,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("IDC")
            Elements.AddRange({CType(Nothing, DataElements.Element1204),
                                      CType(Nothing, DataElements.Element1215),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element306)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property IDC01 As String Implements IDC.IDC01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC.IDC01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1204).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1204
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1204).Value = value
                End If
            End Set
        End Property

        Friend Property IDC02 As String Implements IDC.IDC02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC.IDC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1215).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1215
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1215).Value = value
                End If
            End Set
        End Property

        Friend Property IDC03 As Decimal? Implements IDC.IDC03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC.IDC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property IDC04 As String Implements IDC.IDC04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2300.IDC.IDC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element306
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IDC
            Dim rval As New IDC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .IDC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .IDC02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .IDC03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IDC04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Identification Card</summary>
    '''<remarks>To provide notification to produce replacement identification card(s)</remarks>
    Public Interface IDC
        Inherits ISegment

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property IDC01 As String

        '''<summary>Identification Card Type Code</summary>
        '''<remarks></remarks>
        Property IDC02 As String

        '''<summary>Quantity</summary>
        '''<remarks>IDC03 is the number of cards being requested.</remarks>
        Property IDC03 As Decimal?

        '''<summary>Action Code</summary>
        '''<remarks>IDC04 is the reason for the card being requested, i.e., add or a change.</remarks>
        Property IDC04 As String

    End Interface
End NameSpace