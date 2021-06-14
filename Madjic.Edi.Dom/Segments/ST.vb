Namespace Segments
    '''<summary>Transaction Set Header</summary>
    '''<remarks>To indicate the start of a transaction set and to assign a control number</remarks>
    Partial Friend Class ST_Obj
        Inherits Segment
        Implements ST,
                   Transactions.Transaction270.Transaction270_B1.Segments.ST,
                   Transactions.Transaction271.Transaction271_B1.Segments.ST,
                   Transactions.Transaction277.Transaction277_A1.Segments.ST,
                   Transactions.Transaction278.Transaction278_A1.Segments.ST,
                   Transactions.Transaction278.Transaction278_A3.Segments.ST,
                   Transactions.Transaction820.Transaction820_A1.Segments.ST,
                   Transactions.Transaction834.Transaction834_A1.Segments.ST,
                   Transactions.Transaction835.Transaction835_W1.Segments.ST,
                   Transactions.Transaction837.Transaction837_Q1.Segments.ST,
                   Transactions.Transaction837.Transaction837_Q2.Segments.ST,
                   Transactions.Transaction837.Transaction837_Q3.Segments.ST,
                   Transactions.Transaction999.Transaction999.Segments.ST
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("ST")
            Elements.AddRange({CType(Nothing, DataElements.Element143),
                                      CType(Nothing, DataElements.Element329),
                                      CType(Nothing, DataElements.Element1705)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ST01 As String Implements ST.ST01, Transactions.Transaction270.Transaction270_B1.Segments.ST.ST01, Transactions.Transaction271.Transaction271_B1.Segments.ST.ST01, Transactions.Transaction277.Transaction277_A1.Segments.ST.ST01, Transactions.Transaction278.Transaction278_A1.Segments.ST.ST01, Transactions.Transaction278.Transaction278_A3.Segments.ST.ST01, Transactions.Transaction820.Transaction820_A1.Segments.ST.ST01, Transactions.Transaction834.Transaction834_A1.Segments.ST.ST01, Transactions.Transaction835.Transaction835_W1.Segments.ST.ST01, Transactions.Transaction837.Transaction837_Q1.Segments.ST.ST01, Transactions.Transaction837.Transaction837_Q2.Segments.ST.ST01, Transactions.Transaction837.Transaction837_Q3.Segments.ST.ST01, Transactions.Transaction999.Transaction999.Segments.ST.ST01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element143).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element143
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element143).Value = value
                End If
            End Set
        End Property

        Friend Property ST02 As String Implements ST.ST02, Transactions.Transaction270.Transaction270_B1.Segments.ST.ST02, Transactions.Transaction271.Transaction271_B1.Segments.ST.ST02, Transactions.Transaction277.Transaction277_A1.Segments.ST.ST02, Transactions.Transaction278.Transaction278_A1.Segments.ST.ST02, Transactions.Transaction278.Transaction278_A3.Segments.ST.ST02, Transactions.Transaction820.Transaction820_A1.Segments.ST.ST02, Transactions.Transaction834.Transaction834_A1.Segments.ST.ST02, Transactions.Transaction835.Transaction835_W1.Segments.ST.ST02, Transactions.Transaction837.Transaction837_Q1.Segments.ST.ST02, Transactions.Transaction837.Transaction837_Q2.Segments.ST.ST02, Transactions.Transaction837.Transaction837_Q3.Segments.ST.ST02, Transactions.Transaction999.Transaction999.Segments.ST.ST02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element329).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element329
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element329).Value = value
                End If
            End Set
        End Property

        Friend Property ST03 As String Implements ST.ST03, Transactions.Transaction270.Transaction270_B1.Segments.ST.ST03, Transactions.Transaction271.Transaction271_B1.Segments.ST.ST03, Transactions.Transaction277.Transaction277_A1.Segments.ST.ST03, Transactions.Transaction278.Transaction278_A1.Segments.ST.ST03, Transactions.Transaction278.Transaction278_A3.Segments.ST.ST03, Transactions.Transaction820.Transaction820_A1.Segments.ST.ST03, Transactions.Transaction834.Transaction834_A1.Segments.ST.ST03, Transactions.Transaction837.Transaction837_Q1.Segments.ST.ST03, Transactions.Transaction837.Transaction837_Q2.Segments.ST.ST03, Transactions.Transaction837.Transaction837_Q3.Segments.ST.ST03, Transactions.Transaction999.Transaction999.Segments.ST.ST03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1705).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1705
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1705).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ST
            Dim rval As New ST_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ST01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ST02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ST03 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Set Header</summary>
    '''<remarks>To indicate the start of a transaction set and to assign a control number</remarks>
    Public Interface ST
        Inherits ISegment

        '''<summary>Transaction Set Identifier Code</summary>
        '''<remarks>The transaction set identifier (ST01) is used by the translation routines of the interchange partners to select the appropriate transaction set definition (e.g., 810 selects the Invoice Transaction Set).</remarks>
        Property ST01 As String

        '''<summary>Transaction Set Control Number</summary>
        '''<remarks></remarks>
        Property ST02 As String

        '''<summary>Implementation Convention Reference</summary>
        '''<remarks>The implementation convention reference (ST03) is used by the translation routines of the interchange partners to select the appropriate implementation convention to match the transaction set definition. When used, this implementation convention reference takes precedence over the implementation reference specified in the GS08.</remarks>
        Property ST03 As String

    End Interface
End NameSpace