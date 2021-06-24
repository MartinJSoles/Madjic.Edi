Namespace Segments
    ''' <summary>
    ''' Interchange Delivery Notice Segment
    ''' </summary>
    ''' <remarks>To provide a notice from the receiving service request handler to the sending service request handler that an interchange was delivered or not delivered to the interchange receiver's mailbox, or some other ancillary service was performed, and that the interchange receiver retrieved, refused, or purged the interchange; TA3 is exchanged only between service request handlers; use of the TA3 segment is optional</remarks>
    Public Interface TA3
        ''' <summary>
        ''' Service Request Handler ID Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_01 As String

        ''' <summary>
        ''' Service Request Handler ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_02 As String

        ''' <summary>
        ''' Error Reason Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_03 As String

        ''' <summary>
        ''' Reported Start Segment ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_04 As String

        ''' <summary>
        ''' Reported Control Number
        ''' </summary>
        ''' <returns></returns>
        Property TA3_05 As String

        ''' <summary>
        ''' Reported Date
        ''' </summary>
        ''' <returns></returns>
        Property TA3_06 As String

        ''' <summary>
        ''' Reported Time
        ''' </summary>
        ''' <returns></returns>
        Property TA3_07 As String

        ''' <summary>
        ''' Reported Interchange Sender ID Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_08 As String

        ''' <summary>
        ''' Reported Sender ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_09 As String

        ''' <summary>
        ''' Reported Interchange Receiver ID Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_10 As String

        ''' <summary>
        ''' Reported Receiver ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_11 As String

        ''' <summary>
        ''' Interchange Action Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_12 As String

        ''' <summary>
        ''' Interchange Action Date
        ''' </summary>
        ''' <returns></returns>
        Property TA3_13 As Date?

        ''' <summary>
        ''' Interchange Action Time
        ''' </summary>
        ''' <returns></returns>
        Property TA3_14 As TimeSpan?

        ''' <summary>
        ''' Interchange Action Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_15 As String

        ''' <summary>
        ''' Interchange Action Date
        ''' </summary>
        ''' <returns></returns>
        Property TA3_16 As Date?

        ''' <summary>
        ''' Interchange Action Time
        ''' </summary>
        ''' <returns></returns>
        Property TA3_17 As TimeSpan?

        ''' <summary>
        ''' First Reference ID Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_18 As String

        ''' <summary>
        ''' First Reference ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_19 As String

        ''' <summary>
        ''' Second Reference ID Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_20 As String

        ''' <summary>
        ''' Second Reference ID
        ''' </summary>
        ''' <returns></returns>
        Property TA3_21 As String

        ''' <summary>
        ''' Reference Code Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_22 As String

        ''' <summary>
        ''' Reference Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_23 As String

        ''' <summary>
        ''' Reference Code Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_24 As String

        ''' <summary>
        ''' Reference Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_25 As String

        ''' <summary>
        ''' Reference Code Qualifier
        ''' </summary>
        ''' <returns></returns>
        Property TA3_26 As String

        ''' <summary>
        ''' Reference Code
        ''' </summary>
        ''' <returns></returns>
        Property TA3_27 As String

    End Interface

    Partial Friend Class TA3_Obj
        Inherits Segment
        Implements TA3

        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}),
        New SyntaxRulePaired({22, 23}),
        New SyntaxRulePaired({24, 25}),
        New SyntaxRulePaired({26, 27})}

        Friend Sub New()
            MyBase.New("TA3")

            Elements.AddRange({CType(Nothing, DataElements.I38),
                          CType(Nothing, DataElements.I39),
                          CType(Nothing, DataElements.I43),
                          CType(Nothing, DataElements.I44),
                          CType(Nothing, DataElements.I45),
                          CType(Nothing, DataElements.I46),
                          CType(Nothing, DataElements.I47),
                          CType(Nothing, DataElements.I48),
                          CType(Nothing, DataElements.I49),
                          CType(Nothing, DataElements.I50),
                          CType(Nothing, DataElements.I51),
                          CType(Nothing, DataElements.I40),
                          CType(Nothing, DataElements.I41),
                          CType(Nothing, DataElements.I42),
                          CType(Nothing, DataElements.I40),
                          CType(Nothing, DataElements.I41),
                          CType(Nothing, DataElements.I42),
                          CType(Nothing, DataElements.I52),
                          CType(Nothing, DataElements.I53),
                          CType(Nothing, DataElements.I54),
                          CType(Nothing, DataElements.I55),
                          CType(Nothing, DataElements.I56),
                          CType(Nothing, DataElements.I57),
                          CType(Nothing, DataElements.I56),
                          CType(Nothing, DataElements.I57),
                          CType(Nothing, DataElements.I56),
                          CType(Nothing, DataElements.I57)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TA3_Obj
            Dim rval As New TA3_Obj

            With rval
                .TA3_01 = source.ToStringValue(0)
                .TA3_02 = source.ToStringValue(1)
                .TA3_03 = source.ToStringValue(2)
                .TA3_04 = source.ToStringValue(3)
                .TA3_05 = source.ToStringValue(4)
                .TA3_06 = source.ToStringValue(5)
                .TA3_07 = source.ToStringValue(6)
                .TA3_08 = source.ToStringValue(7)
                .TA3_09 = source.ToStringValue(8)
                .TA3_10 = source.ToStringValue(9)
                .TA3_11 = source.ToStringValue(10)
                .TA3_12 = source.ToStringValue(11)
                .TA3_13 = source.ToDateValue(12)
                .TA3_14 = source.ToTimeSpanValue(13)

                If source.Elements.Count > 14 Then
                    .TA3_15 = source.ToStringValue(14)
                End If

                If source.Elements.Count > 15 Then
                    .TA3_16 = source.ToDateValue(15)
                End If

                If source.Elements.Count > 16 Then
                    .TA3_17 = source.ToTimeSpanValue(16)
                End If

                If source.Elements.Count > 17 Then
                    .TA3_18 = source.ToStringValue(17)
                End If

                If source.Elements.Count > 18 Then
                    .TA3_19 = source.ToStringValue(18)
                End If

                If source.Elements.Count > 19 Then
                    .TA3_20 = source.ToStringValue(19)
                End If

                If source.Elements.Count > 20 Then
                    .TA3_21 = source.ToStringValue(20)
                End If

                If source.Elements.Count > 21 Then
                    .TA3_22 = source.ToStringValue(21)
                End If

                If source.Elements.Count > 22 Then
                    .TA3_23 = source.ToStringValue(22)
                End If

                If source.Elements.Count > 23 Then
                    .TA3_24 = source.ToStringValue(23)
                End If

                If source.Elements.Count > 24 Then
                    .TA3_25 = source.ToStringValue(24)
                End If

                If source.Elements.Count > 25 Then
                    .TA3_26 = source.ToStringValue(25)
                End If

                If source.Elements.Count > 26 Then
                    .TA3_27 = source.ToStringValue(26)
                End If
            End With

            Return rval
        End Function
        Public Property TA3_01 As String Implements TA3.TA3_01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.I38).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.I38
                ElseIf value Is Nothing Then
                    Elements(1) = Nothing
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.I38).Value = value
                End If
            End Set
        End Property

        Public Property TA3_02 As String Implements TA3.TA3_02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.I39).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) IsNot Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.I39
                ElseIf value Is Nothing Then
                    Elements(1) = Nothing
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.I39).Value = value
                End If
            End Set
        End Property

        Public Property TA3_03 As String Implements TA3.TA3_03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.I43).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.I43
                ElseIf value Is Nothing Then
                    Elements(2) = Nothing
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.I43).Value = value
                End If
            End Set
        End Property

        Public Property TA3_04 As String Implements TA3.TA3_04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.I44).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.I44
                ElseIf value Is Nothing Then
                    Elements(3) = Nothing
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.I44).Value = value
                End If
            End Set
        End Property

        Public Property TA3_05 As String Implements TA3.TA3_05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.I45).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.I45
                ElseIf value Is Nothing Then
                    Elements(4) = Nothing
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.I45).Value = value
                End If
            End Set
        End Property

        Public Property TA3_06 As String Implements TA3.TA3_06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.I46).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.I46
                ElseIf value Is Nothing Then
                    Elements(5) = Nothing
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.I46).Value = value
                End If
            End Set
        End Property

        Public Property TA3_07 As String Implements TA3.TA3_07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.I47).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.I47
                ElseIf value Is Nothing Then
                    Elements(6) = Nothing
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.I47).Value = value
                End If
            End Set
        End Property

        Public Property TA3_08 As String Implements TA3.TA3_08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.I48).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.I48
                ElseIf value Is Nothing Then
                    Elements(7) = Nothing
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.I48).Value = value
                End If
            End Set
        End Property

        Public Property TA3_09 As String Implements TA3.TA3_09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.I49).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.I49
                ElseIf value Is Nothing Then
                    Elements(8) = Nothing
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.I49).Value = value
                End If
            End Set
        End Property

        Public Property TA3_10 As String Implements TA3.TA3_10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.I50).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.I50
                ElseIf value Is Nothing Then
                    Elements(9) = Nothing
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.I50).Value = value
                End If
            End Set
        End Property

        Public Property TA3_11 As String Implements TA3.TA3_11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.I51).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.I51
                ElseIf value Is Nothing Then
                    Elements(10) = Nothing
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.I51).Value = value
                End If
            End Set
        End Property

        Public Property TA3_12 As String Implements TA3.TA3_12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.I40).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.I40
                ElseIf value Is Nothing Then
                    Elements(11) = Nothing
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.I40).Value = value
                End If
            End Set
        End Property

        Public Property TA3_13 As Date? Implements TA3.TA3_13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.I41).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.I41
                ElseIf value Is Nothing Then
                    Elements(12) = Nothing
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.I41).Value = value
                End If
            End Set
        End Property

        Public Property TA3_14 As TimeSpan? Implements TA3.TA3_14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.I42).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.I42
                ElseIf value Is Nothing Then
                    Elements(13) = Nothing
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.I42).Value = value
                End If
            End Set
        End Property

        Public Property TA3_15 As String Implements TA3.TA3_15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.I40).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.I40
                ElseIf value Is Nothing Then
                    Elements(14) = Nothing
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.I40).Value = value
                End If
            End Set
        End Property

        Public Property TA3_16 As Date? Implements TA3.TA3_16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.I41).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.I41
                ElseIf value Is Nothing Then
                    Elements(15) = Nothing
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.I41).Value = value
                End If
            End Set
        End Property

        Public Property TA3_17 As TimeSpan? Implements TA3.TA3_17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.I42).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.I42
                ElseIf value Is Nothing Then
                    Elements(16) = Nothing
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.I42).Value = value
                End If
            End Set
        End Property

        Public Property TA3_18 As String Implements TA3.TA3_18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.I52).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.I52
                ElseIf value Is Nothing Then
                    Elements(17) = Nothing
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.I52).Value = value
                End If
            End Set
        End Property

        Public Property TA3_19 As String Implements TA3.TA3_19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.I53).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.I53
                ElseIf value Is Nothing Then
                    Elements(18) = Nothing
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.I53).Value = value
                End If
            End Set
        End Property

        Public Property TA3_20 As String Implements TA3.TA3_20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.I54).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.I54
                ElseIf value Is Nothing Then
                    Elements(19) = Nothing
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.I54).Value = value
                End If
            End Set
        End Property

        Public Property TA3_21 As String Implements TA3.TA3_21
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.I55).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.I55
                ElseIf value Is Nothing Then
                    Elements(20) = Nothing
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.I55).Value = value
                End If
            End Set
        End Property

        Public Property TA3_22 As String Implements TA3.TA3_22
            Get
                Return If(Elements(21) IsNot Nothing, CType(Elements(21), DataElements.I56).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(21) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(21) = New DataElements.I56
                ElseIf value Is Nothing Then
                    Elements(21) = Nothing
                End If

                If Elements(21) IsNot Nothing Then
                    CType(Elements(21), DataElements.I56).Value = value
                End If
            End Set
        End Property

        Public Property TA3_23 As String Implements TA3.TA3_23
            Get
                Return If(Elements(22) IsNot Nothing, CType(Elements(22), DataElements.I57).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(22) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(22) = New DataElements.I57
                ElseIf value Is Nothing Then
                    Elements(22) = Nothing
                End If

                If Elements(22) IsNot Nothing Then
                    CType(Elements(22), DataElements.I57).Value = value
                End If
            End Set
        End Property

        Public Property TA3_24 As String Implements TA3.TA3_24
            Get
                Return If(Elements(23) IsNot Nothing, CType(Elements(23), DataElements.I56).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(23) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(23) = New DataElements.I56
                ElseIf value Is Nothing Then
                    Elements(23) = Nothing
                End If

                If Elements(23) IsNot Nothing Then
                    CType(Elements(23), DataElements.I56).Value = value
                End If
            End Set
        End Property

        Public Property TA3_25 As String Implements TA3.TA3_25
            Get
                Return If(Elements(24) IsNot Nothing, CType(Elements(24), DataElements.I57).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(24) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(24) = New DataElements.I57
                ElseIf value Is Nothing Then
                    Elements(24) = Nothing
                End If

                If Elements(24) IsNot Nothing Then
                    CType(Elements(24), DataElements.I57).Value = value
                End If
            End Set
        End Property

        Public Property TA3_26 As String Implements TA3.TA3_26
            Get
                Return If(Elements(25) IsNot Nothing, CType(Elements(25), DataElements.I56).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(25) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(25) = New DataElements.I56
                ElseIf value Is Nothing Then
                    Elements(25) = Nothing
                End If

                If Elements(25) IsNot Nothing Then
                    CType(Elements(25), DataElements.I56).Value = value
                End If
            End Set
        End Property

        Public Property TA3_27 As String Implements TA3.TA3_27
            Get
                Return If(Elements(26) IsNot Nothing, CType(Elements(26), DataElements.I57).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(26) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(26) = New DataElements.I57
                ElseIf value Is Nothing Then
                    Elements(26) = Nothing
                End If

                If Elements(26) IsNot Nothing Then
                    CType(Elements(26), DataElements.I57).Value = value
                End If
            End Set
        End Property
    End Class

End Namespace
