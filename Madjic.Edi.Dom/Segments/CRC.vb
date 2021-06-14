Namespace Segments
    '''<summary>Conditions Indicator</summary>
    '''<remarks>To supply information on conditions</remarks>
    Partial Friend Class CRC_Obj
        Inherits Segment
        Implements CRC,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("CRC")
            Elements.AddRange({CType(Nothing, DataElements.Element1136),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1321),
                                      CType(Nothing, DataElements.Element1321),
                                      CType(Nothing, DataElements.Element1321),
                                      CType(Nothing, DataElements.Element1321),
                                      CType(Nothing, DataElements.Element1321)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CRC01 As String Implements CRC.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1.CRC01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2.CRC01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC.CRC01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1136).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1136
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1136).Value = value
                End If
            End Set
        End Property

        Friend Property CRC02 As String Implements CRC.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1.CRC02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2.CRC02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC.CRC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1073
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CRC03 As String Implements CRC.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_2.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_1.CRC03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2.CRC03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC.CRC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1321).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1321
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1321).Value = value
                End If
            End Set
        End Property

        Friend Property CRC04 As String Implements CRC.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3.CRC04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC_2.CRC04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC.CRC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1321).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1321
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1321).Value = value
                End If
            End Set
        End Property

        Friend Property CRC05 As String Implements CRC.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_3.CRC05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CRC.CRC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1321).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1321
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1321).Value = value
                End If
            End Set
        End Property

        Friend Property CRC06 As String Implements CRC.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1321).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1321
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1321).Value = value
                End If
            End Set
        End Property

        Friend Property CRC07 As String Implements CRC.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_1.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_2.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_3.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_4.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_5.CRC07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CRC_6.CRC07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC.CRC07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CRC_1.CRC07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CRC.CRC07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1321).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1321
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1321).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CRC
            Dim rval As New CRC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CRC01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CRC02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CRC03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CRC04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CRC05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CRC06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CRC07 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Conditions Indicator</summary>
    '''<remarks>To supply information on conditions</remarks>
    Public Interface CRC
        Inherits ISegment

        '''<summary>Code Category</summary>
        '''<remarks>CRC01 qualifies CRC03 through CRC07.</remarks>
        Property CRC01 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CRC02 is a Certification Condition Code applies indicator. A "Y" value indicates the condition codes in CRC03 through CRC07 apply; an "N" value indicates the condition codes in CRC03 through CRC07 do not apply.</remarks>
        Property CRC02 As String

        '''<summary>Condition Indicator</summary>
        '''<remarks></remarks>
        Property CRC03 As String

        '''<summary>Condition Indicator</summary>
        '''<remarks></remarks>
        Property CRC04 As String

        '''<summary>Condition Indicator</summary>
        '''<remarks></remarks>
        Property CRC05 As String

        '''<summary>Condition Indicator</summary>
        '''<remarks></remarks>
        Property CRC06 As String

        '''<summary>Condition Indicator</summary>
        '''<remarks></remarks>
        Property CRC07 As String

    End Interface
End NameSpace