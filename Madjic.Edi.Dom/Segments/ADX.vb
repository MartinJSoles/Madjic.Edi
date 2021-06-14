Namespace Segments
    '''<summary>Adjustment</summary>
    '''<remarks>To convey accounts-payable adjustment information for the purpose of cash application, including payer-generated debit/credit memos</remarks>
    Partial Friend Class ADX_Obj
        Inherits Segment
        Implements ADX,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("ADX")
            Elements.AddRange({CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element426),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ADX01 As Decimal? Implements ADX.ADX01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX.ADX01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX.ADX01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX.ADX01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX.ADX01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element782
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property ADX02 As String Implements ADX.ADX02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2200A.ADX.ADX02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2320A.ADX.ADX02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2200B.ADX.ADX02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2320B.ADX.ADX02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element426).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element426
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element426).Value = value
                End If
            End Set
        End Property

        Friend Property ADX03 As String Implements ADX.ADX03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element128
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property ADX04 As String Implements ADX.ADX04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element127
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ADX
            Dim rval As New ADX_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ADX01 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ADX02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ADX03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .ADX04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Adjustment</summary>
    '''<remarks>To convey accounts-payable adjustment information for the purpose of cash application, including payer-generated debit/credit memos</remarks>
    Public Interface ADX
        Inherits ISegment

        '''<summary>Monetary Amount</summary>
        '''<remarks>ADX01 specifies the amount of the adjustment and must be signed if negative. If negative, it reduces the payment amount; if positive, it increases the payment amount.</remarks>
        Property ADX01 As Decimal?

        '''<summary>Adjustment Reason Code</summary>
        '''<remarks>ADX02 specifies the reason for claiming the adjustment.</remarks>
        Property ADX02 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks>ADX03 and ADX04 specify the identification of the adjustment.</remarks>
        Property ADX03 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property ADX04 As String

    End Interface
End NameSpace