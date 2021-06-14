Namespace Segments
    '''<summary>Remittance Advice Accounts Receivable Open Item Reference</summary>
    '''<remarks>To specify the accounts receivable open item(s) to be included in the cash application and to convey the appropriate detail</remarks>
    Partial Friend Class RMR_Obj
        Inherits Segment
        Implements RMR,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRulePaired({7, 8})}

        Public Sub New()
            MyBase.New("RMR")
            Elements.AddRange({CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element482),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element426),
                                      CType(Nothing, DataElements.Element782)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property RMR01 As String Implements RMR.RMR01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR.RMR01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR.RMR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element128
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property RMR02 As String Implements RMR.RMR02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR.RMR02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR.RMR02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element127
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property RMR03 As String Implements RMR.RMR03, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR.RMR03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element482).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element482
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element482).Value = value
                End If
            End Set
        End Property

        Friend Property RMR04 As Decimal? Implements RMR.RMR04, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR.RMR04, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR.RMR04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element782
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property RMR05 As Decimal? Implements RMR.RMR05, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.RMR.RMR05, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.RMR.RMR05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element782
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property RMR06 As Decimal? Implements RMR.RMR06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element782
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property RMR07 As String Implements RMR.RMR07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element426).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element426
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element426).Value = value
                End If
            End Set
        End Property

        Friend Property RMR08 As Decimal? Implements RMR.RMR08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element782
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As RMR
            Dim rval As New RMR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .RMR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .RMR02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .RMR03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .RMR04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .RMR05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .RMR06 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .RMR07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .RMR08 = source.ToFloatValue(7)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Remittance Advice Accounts Receivable Open Item Reference</summary>
    '''<remarks>To specify the accounts receivable open item(s) to be included in the cash application and to convey the appropriate detail</remarks>
    Public Interface RMR
        Inherits ISegment

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks>Parties using this segment should agree on the content of RMR01 and RMR02 prior to initiating communication.</remarks>
        Property RMR01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property RMR02 As String

        '''<summary>Payment Action Code</summary>
        '''<remarks>If RMR03 is present, it specifies how the cash is to be applied.</remarks>
        Property RMR03 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>RMR04 is the amount paid.</remarks>
        Property RMR04 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>RMR05 is the amount of invoice (including charges, less allowance) before terms discount (if discount is applicable) or debit amount or credit amount of referenced items.</remarks>
        Property RMR05 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>RMR06 is the amount of discount taken.</remarks>
        Property RMR06 As Decimal?

        '''<summary>Adjustment Reason Code</summary>
        '''<remarks></remarks>
        Property RMR07 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>RMR08, if present, represents an interest penalty payment, amount late interest paid, or amount anticipation.</remarks>
        Property RMR08 As Decimal?

    End Interface
End NameSpace