Namespace Segments
    '''<summary>Date/Time Reference</summary>
    '''<remarks>To specify pertinent dates and times</remarks>
    Partial Friend Class DTM_Obj
        Inherits Segment
        Implements DTM,
                   Transactions.Transaction820.Transaction820_A1.Segments.DTM,
                   Transactions.Transaction820.Transaction820_A1.Segments.DTM_1,
                   Transactions.Transaction820.Transaction820_A1.Segments.DTM_2,
                   Transactions.Transaction820.Transaction820_A1.Segments.DTM_3,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM,
                   Transactions.Transaction835.Transaction835_W1.Segments.DTM,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({2, 3, 5}),
                                                 New SyntaxRuleConditional(4, {3}),
                                                 New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("DTM")
            Elements.AddRange({CType(Nothing, DataElements.Element374),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element623),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property DTM01 As String Implements DTM.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.DTM.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.DTM_1.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.DTM_2.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.DTM_3.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM.DTM01, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM.DTM01, Transactions.Transaction835.Transaction835_W1.Segments.DTM.DTM01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM.DTM01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1.DTM01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2.DTM01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM.DTM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element374).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element374
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element374).Value = value
                End If
            End Set
        End Property

        Friend Property DTM02 As Date? Implements DTM.DTM02, Transactions.Transaction820.Transaction820_A1.Segments.DTM.DTM02, Transactions.Transaction820.Transaction820_A1.Segments.DTM_1.DTM02, Transactions.Transaction820.Transaction820_A1.Segments.DTM_3.DTM02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM.DTM02, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM.DTM02, Transactions.Transaction835.Transaction835_W1.Segments.DTM.DTM02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM.DTM02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_1.DTM02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.DTM_2.DTM02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.DTM.DTM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element373
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property DTM03 As TimeSpan? Implements DTM.DTM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element337
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property DTM04 As String Implements DTM.DTM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element623).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element623
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element623).Value = value
                End If
            End Set
        End Property

        Friend Property DTM05 As String Implements DTM.DTM05, Transactions.Transaction820.Transaction820_A1.Segments.DTM_2.DTM05, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM.DTM05, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM.DTM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1250
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property DTM06 As String Implements DTM.DTM06, Transactions.Transaction820.Transaction820_A1.Segments.DTM_2.DTM06, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300A.DTM.DTM06, Transactions.Transaction820.Transaction820_A1.Segments.Loop2300B.DTM.DTM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1251
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As DTM
            Dim rval As New DTM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .DTM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .DTM02 = source.ToDateValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .DTM03 = source.ToTimeSpanValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .DTM04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .DTM05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .DTM06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Date/Time Reference</summary>
    '''<remarks>To specify pertinent dates and times</remarks>
    Public Interface DTM
        Inherits ISegment

        '''<summary>Date/Time Qualifier</summary>
        '''<remarks></remarks>
        Property DTM01 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property DTM02 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property DTM03 As Timespan?

        '''<summary>Time Code</summary>
        '''<remarks></remarks>
        Property DTM04 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property DTM05 As String

        '''<summary>Date Time Period</summary>
        '''<remarks></remarks>
        Property DTM06 As String

    End Interface
End NameSpace