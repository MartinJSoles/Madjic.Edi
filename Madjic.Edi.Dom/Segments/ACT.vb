Namespace Segments
    '''<summary>Account Identification</summary>
    '''<remarks>To specify account information</remarks>
    Partial Friend Class ACT_Obj
        Inherits Segment
        Implements ACT,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRuleConditional(5, {6}),
                                                 New SyntaxRuleConditional(7, {5}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("ACT")
            Elements.AddRange({CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element66),
                                      CType(Nothing, DataElements.Element67),
                                      CType(Nothing, DataElements.Element569),
                                      CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element107),
                                      CType(Nothing, DataElements.Element1216)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ACT01 As String Implements ACT.ACT01, Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT.ACT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element508
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property ACT02 As String Implements ACT.ACT02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element93
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property ACT03 As String Implements ACT.ACT03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element66).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element66
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element66).Value = value
                End If
            End Set
        End Property

        Friend Property ACT04 As String Implements ACT.ACT04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element67).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element67
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element67).Value = value
                End If
            End Set
        End Property

        Friend Property ACT05 As String Implements ACT.ACT05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element569).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element569
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element569).Value = value
                End If
            End Set
        End Property

        Friend Property ACT06 As String Implements ACT.ACT06, Transactions.Transaction834.Transaction834_A1.Segments.Loop1100C.ACT.ACT06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element508
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property ACT07 As String Implements ACT.ACT07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element352
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property ACT08 As String Implements ACT.ACT08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element107).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element107
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element107).Value = value
                End If
            End Set
        End Property

        Friend Property ACT09 As String Implements ACT.ACT09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1216).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1216
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1216).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ACT
            Dim rval As New ACT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ACT01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ACT02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ACT03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .ACT04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .ACT05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .ACT06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .ACT07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .ACT08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .ACT09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Account Identification</summary>
    '''<remarks>To specify account information</remarks>
    Public Interface ACT
        Inherits ISegment

        '''<summary>Account Number</summary>
        '''<remarks></remarks>
        Property ACT01 As String

        '''<summary>Name</summary>
        '''<remarks>ACT02 is the name of the account in ACT01.</remarks>
        Property ACT02 As String

        '''<summary>Identification Code Qualifier</summary>
        '''<remarks></remarks>
        Property ACT03 As String

        '''<summary>Identification Code</summary>
        '''<remarks></remarks>
        Property ACT04 As String

        '''<summary>Account Number Qualifier</summary>
        '''<remarks></remarks>
        Property ACT05 As String

        '''<summary>Account Number</summary>
        '''<remarks>ACT06 is an account associated with the account in ACT01.</remarks>
        Property ACT06 As String

        '''<summary>Description</summary>
        '''<remarks>ACT07 is the name associated with the account identified in ACT06.</remarks>
        Property ACT07 As String

        '''<summary>Payment Method Type Code</summary>
        '''<remarks>ACT08 indicates if the data for the account in ACT01 is used for billing or information purposes.</remarks>
        Property ACT08 As String

        '''<summary>Benefit Status Code</summary>
        '''<remarks></remarks>
        Property ACT09 As String

    End Interface
End NameSpace