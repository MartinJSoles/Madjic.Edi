Namespace Segments
    '''<summary>Beginning Segment</summary>
    '''<remarks>To indicate the beginning of a transaction set</remarks>
    Partial Friend Class BGN_Obj
        Inherits Segment
        Implements BGN,
                   Transactions.Transaction834.Transaction834_A1.Segments.BGN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(5, {4}),
                                                 New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("BGN")
            Elements.AddRange({CType(Nothing, DataElements.Element353),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element623),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element640),
                                      CType(Nothing, DataElements.Element306),
                                      CType(Nothing, DataElements.Element786)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property BGN01 As String Implements BGN.BGN01, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element353).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element353
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element353).Value = value
                End If
            End Set
        End Property

        Friend Property BGN02 As String Implements BGN.BGN02, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN02
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

        Friend Property BGN03 As Date? Implements BGN.BGN03, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element373
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property BGN04 As TimeSpan? Implements BGN.BGN04, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element337
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property BGN05 As String Implements BGN.BGN05, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element623).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element623
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element623).Value = value
                End If
            End Set
        End Property

        Friend Property BGN06 As String Implements BGN.BGN06, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element127
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property BGN07 As String Implements BGN.BGN07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element640).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element640
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element640).Value = value
                End If
            End Set
        End Property

        Friend Property BGN08 As String Implements BGN.BGN08, Transactions.Transaction834.Transaction834_A1.Segments.BGN.BGN08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element306
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Property BGN09 As String Implements BGN.BGN09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element786).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element786
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element786).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As BGN
            Dim rval As New BGN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .BGN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .BGN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .BGN03 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .BGN04 = source.ToTimeSpanValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .BGN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .BGN06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .BGN07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .BGN08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .BGN09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Beginning Segment</summary>
    '''<remarks>To indicate the beginning of a transaction set</remarks>
    Public Interface BGN
        Inherits ISegment

        '''<summary>Transaction Set Purpose Code</summary>
        '''<remarks></remarks>
        Property BGN01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>BGN02 is the transaction set reference number.</remarks>
        Property BGN02 As String

        '''<summary>Date</summary>
        '''<remarks>BGN03 is the transaction set date.</remarks>
        Property BGN03 As Date?

        '''<summary>Time</summary>
        '''<remarks>BGN04 is the transaction set time.</remarks>
        Property BGN04 As Timespan?

        '''<summary>Time Code</summary>
        '''<remarks>BGN05 is the transaction set time qualifier.</remarks>
        Property BGN05 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>BGN06 is the transaction set reference number of a previously sent transaction affected by the current transaction.</remarks>
        Property BGN06 As String

        '''<summary>Transaction Type Code</summary>
        '''<remarks></remarks>
        Property BGN07 As String

        '''<summary>Action Code</summary>
        '''<remarks></remarks>
        Property BGN08 As String

        '''<summary>Security Level Code</summary>
        '''<remarks></remarks>
        Property BGN09 As String

    End Interface
End NameSpace