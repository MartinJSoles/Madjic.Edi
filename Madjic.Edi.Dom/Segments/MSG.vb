Namespace Segments
    '''<summary>Message Text</summary>
    '''<remarks>To provide a free-form format that allows the transmission of text information</remarks>
    Partial Friend Class MSG_Obj
        Inherits Segment
        Implements MSG,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.MSG,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.MSG,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(3, {2}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("MSG")
            Elements.AddRange({CType(Nothing, DataElements.Element933),
                                      CType(Nothing, DataElements.Element934),
                                      CType(Nothing, DataElements.Element1470)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property MSG01 As String Implements MSG.MSG01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.MSG.MSG01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.MSG.MSG01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.MSG.MSG01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.MSG.MSG01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.MSG.MSG01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.MSG.MSG01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element933).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element933
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element933).Value = value
                End If
            End Set
        End Property

        Friend Property MSG02 As String Implements MSG.MSG02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element934).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element934
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element934).Value = value
                End If
            End Set
        End Property

        Friend Property MSG03 As Decimal? Implements MSG.MSG03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1470
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As MSG
            Dim rval As New MSG_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .MSG01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .MSG02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .MSG03 = source.ToDecimalValue(2, 0)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Message Text</summary>
    '''<remarks>To provide a free-form format that allows the transmission of text information</remarks>
    Public Interface MSG
        Inherits ISegment

        '''<summary>Free-form Message Text</summary>
        '''<remarks></remarks>
        Property MSG01 As String

        '''<summary>Printer Carriage Control Code</summary>
        '''<remarks>MSG02 is not related to the specific characteristics of a printer, but identifies top of page, advance a line, etc.</remarks>
        Property MSG02 As String

        '''<summary>Number</summary>
        '''<remarks>MSG03 is the number of lines to advance before printing.</remarks>
        Property MSG03 As Decimal?

    End Interface
End NameSpace