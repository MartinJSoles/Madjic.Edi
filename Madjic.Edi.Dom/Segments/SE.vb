Namespace Segments
    '''<summary>Transaction Set Trailer</summary>
    '''<remarks>To indicate the end of the transaction set and provide the count of the transmitted segments (including the beginning (ST) and ending (SE) segments)</remarks>
    Partial Friend Class SE_Obj
        Inherits Segment
        Implements SE,
                   Transactions.Transaction270.Transaction270_B1.Segments.SE,
                   Transactions.Transaction271.Transaction271_B1.Segments.SE,
                   Transactions.Transaction277.Transaction277_A1.Segments.SE,
                   Transactions.Transaction278.Transaction278_A1.Segments.SE,
                   Transactions.Transaction278.Transaction278_A3.Segments.SE,
                   Transactions.Transaction820.Transaction820_A1.Segments.SE,
                   Transactions.Transaction834.Transaction834_A1.Segments.SE,
                   Transactions.Transaction835.Transaction835_W1.Segments.SE,
                   Transactions.Transaction837.Transaction837_Q1.Segments.SE,
                   Transactions.Transaction837.Transaction837_Q2.Segments.SE,
                   Transactions.Transaction837.Transaction837_Q3.Segments.SE,
                   Transactions.Transaction999.Transaction999.Segments.SE
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("SE")
            Elements.AddRange({CType(Nothing, DataElements.Element96),
                                      CType(Nothing, DataElements.Element329)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SE01 As Decimal? Implements SE.SE01, Transactions.Transaction270.Transaction270_B1.Segments.SE.SE01, Transactions.Transaction271.Transaction271_B1.Segments.SE.SE01, Transactions.Transaction277.Transaction277_A1.Segments.SE.SE01, Transactions.Transaction278.Transaction278_A1.Segments.SE.SE01, Transactions.Transaction278.Transaction278_A3.Segments.SE.SE01, Transactions.Transaction820.Transaction820_A1.Segments.SE.SE01, Transactions.Transaction834.Transaction834_A1.Segments.SE.SE01, Transactions.Transaction835.Transaction835_W1.Segments.SE.SE01, Transactions.Transaction837.Transaction837_Q1.Segments.SE.SE01, Transactions.Transaction837.Transaction837_Q2.Segments.SE.SE01, Transactions.Transaction837.Transaction837_Q3.Segments.SE.SE01, Transactions.Transaction999.Transaction999.Segments.SE.SE01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element96).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element96
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element96).Value = value
                End If
            End Set
        End Property

        Friend Property SE02 As String Implements SE.SE02, Transactions.Transaction270.Transaction270_B1.Segments.SE.SE02, Transactions.Transaction271.Transaction271_B1.Segments.SE.SE02, Transactions.Transaction277.Transaction277_A1.Segments.SE.SE02, Transactions.Transaction278.Transaction278_A1.Segments.SE.SE02, Transactions.Transaction278.Transaction278_A3.Segments.SE.SE02, Transactions.Transaction820.Transaction820_A1.Segments.SE.SE02, Transactions.Transaction834.Transaction834_A1.Segments.SE.SE02, Transactions.Transaction835.Transaction835_W1.Segments.SE.SE02, Transactions.Transaction837.Transaction837_Q1.Segments.SE.SE02, Transactions.Transaction837.Transaction837_Q2.Segments.SE.SE02, Transactions.Transaction837.Transaction837_Q3.Segments.SE.SE02, Transactions.Transaction999.Transaction999.Segments.SE.SE02
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SE
            Dim rval As New SE_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SE01 = source.ToDecimalValue(0, 0)
                End If
                If source.Elements.Count > 1 Then
                    .SE02 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Transaction Set Trailer</summary>
    '''<remarks>To indicate the end of the transaction set and provide the count of the transmitted segments (including the beginning (ST) and ending (SE) segments)</remarks>
    Public Interface SE
        Inherits ISegment

        '''<summary>Number of Included Segments</summary>
        '''<remarks></remarks>
        Property SE01 As Decimal?

        '''<summary>Transaction Set Control Number</summary>
        '''<remarks></remarks>
        Property SE02 As String

    End Interface
End NameSpace