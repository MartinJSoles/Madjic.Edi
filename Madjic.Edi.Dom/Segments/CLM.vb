Namespace Segments
    '''<summary>Health Claim</summary>
    '''<remarks>To specify basic data about the claim</remarks>
    Partial Friend Class CLM_Obj
        Inherits Segment
        Implements CLM,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("CLM")
            Elements.AddRange({CType(Nothing, DataElements.Element1028),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1032),
                                      CType(Nothing, DataElements.Element1343),
                                      CType(Nothing, DataElements.Composite.C023_Obj),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1359),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1363),
                                      CType(Nothing, DataElements.Element1351),
                                      CType(Nothing, DataElements.Composite.C024_Obj),
                                      CType(Nothing, DataElements.Element1366),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1338),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1360),
                                      CType(Nothing, DataElements.Element1029),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1383),
                                      CType(Nothing, DataElements.Element1514)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CLM01 As String Implements CLM.CLM01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1028).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1028
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1028).Value = value
                End If
            End Set
        End Property

        Friend Property CLM02 As Decimal? Implements CLM.CLM02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element782
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property CLM03 As String Implements CLM.CLM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1032).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1032
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1032).Value = value
                End If
            End Set
        End Property

        Friend Property CLM04 As String Implements CLM.CLM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1343).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1343
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1343).Value = value
                End If
            End Set
        End Property

        Friend Property CLM05 As DataElements.Composite.C023 Implements CLM.CLM05
            Get
                Return CType(Elements(4), DataElements.Composite.C023_Obj)
            End Get
            Set(value As DataElements.Composite.C023)
                Elements(4) = value
            End Set
        End Property

        Private Property CLM05_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_05.C023 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM05
            Get
                Return CType(CLM05, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_05.C023)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_05.C023)
                CLM05 = value
            End Set
        End Property

        Private Property CLM05_IFace_1 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.C023 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM05
            Get
                Return CType(CLM05, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.C023)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.C023)
                CLM05 = value
            End Set
        End Property

        Private Property CLM05_IFace_2 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.CLM_05.C023 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM05
            Get
                Return CType(CLM05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.CLM_05.C023)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.CLM_05.C023)
                CLM05 = value
            End Set
        End Property

        Friend Property CLM06 As String Implements CLM.CLM06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1073
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CLM07 As String Implements CLM.CLM07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1359).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1359
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1359).Value = value
                End If
            End Set
        End Property

        Friend Property CLM08 As String Implements CLM.CLM08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM08, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1073
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CLM09 As String Implements CLM.CLM09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM09, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM09, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1363).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1363
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1363).Value = value
                End If
            End Set
        End Property

        Friend Property CLM10 As String Implements CLM.CLM10, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1351).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1351
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1351).Value = value
                End If
            End Set
        End Property

        Friend Property CLM11 As DataElements.Composite.C024 Implements CLM.CLM11
            Get
                Return CType(Elements(10), DataElements.Composite.C024_Obj)
            End Get
            Set(value As DataElements.Composite.C024)
                Elements(10) = value
            End Set
        End Property

        Private Property CLM11_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_11.C024 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM11
            Get
                Return CType(CLM11, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_11.C024)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_11.C024)
                CLM11 = value
            End Set
        End Property

        Private Property CLM11_IFace_1 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.C024 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM11
            Get
                Return CType(CLM11, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.C024)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.C024)
                CLM11 = value
            End Set
        End Property

        Friend Property CLM12 As String Implements CLM.CLM12, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM12, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1366).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1366
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1366).Value = value
                End If
            End Set
        End Property

        Friend Property CLM13 As String Implements CLM.CLM13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element1073
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CLM14 As String Implements CLM.CLM14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1338).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1338
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1338).Value = value
                End If
            End Set
        End Property

        Friend Property CLM15 As String Implements CLM.CLM15
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1073
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CLM16 As String Implements CLM.CLM16
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element1360).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element1360
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element1360).Value = value
                End If
            End Set
        End Property

        Friend Property CLM17 As String Implements CLM.CLM17
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1029).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1029
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1029).Value = value
                End If
            End Set
        End Property

        Friend Property CLM18 As String Implements CLM.CLM18
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element1073
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property CLM19 As String Implements CLM.CLM19, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM19
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element1383).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element1383
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element1383).Value = value
                End If
            End Set
        End Property

        Friend Property CLM20 As String Implements CLM.CLM20, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CLM.CLM20, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.CLM.CLM20, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CLM.CLM20
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element1514).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element1514
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element1514).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CLM
            Dim rval As New CLM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CLM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CLM02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CLM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CLM04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C023_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .CLM06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CLM07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CLM08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CLM09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CLM10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .Elements(10) = DataElements.Composite.C024_Obj.FromReader(source.ToStringValue(10), reader)
                End If
                If source.Elements.Count > 11 Then
                    .CLM12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CLM13 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CLM14 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .CLM15 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .CLM16 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .CLM17 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .CLM18 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .CLM19 = source.ToStringValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .CLM20 = source.ToStringValue(19)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Health Claim</summary>
    '''<remarks>To specify basic data about the claim</remarks>
    Public Interface CLM
        Inherits ISegment

        '''<summary>Claim Submitter's Identifier</summary>
        '''<remarks></remarks>
        Property CLM01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CLM02 is the total amount of all submitted charges of service segments for this claim.</remarks>
        Property CLM02 As Decimal?

        '''<summary>Claim Filing Indicator Code</summary>
        '''<remarks></remarks>
        Property CLM03 As String

        '''<summary>Non-Institutional Claim Type Code</summary>
        '''<remarks></remarks>
        Property CLM04 As String

        '''<summary>Health Care Service Location Information</summary>
        '''<remarks></remarks>
        Property CLM05 As DataElements.Composite.C023

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLM06 is provider signature on file indicator. A "Y" value indicates the provider signature is on file; an "N" value indicates the provider signature is not on file.</remarks>
        Property CLM06 As String

        '''<summary>Provider Accept Assignment Code</summary>
        '''<remarks></remarks>
        Property CLM07 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLM08 is assignment of benefits indicator. A "Y" value indicates insured or authorized person authorizes benefits to be assigned to the provider; an "N" value indicates benefits have not been assigned to the provider.</remarks>
        Property CLM08 As String

        '''<summary>Release of Information Code</summary>
        '''<remarks></remarks>
        Property CLM09 As String

        '''<summary>Patient Signature Source Code</summary>
        '''<remarks></remarks>
        Property CLM10 As String

        '''<summary>Related Causes Information</summary>
        '''<remarks></remarks>
        Property CLM11 As DataElements.Composite.C024

        '''<summary>Special Program Code</summary>
        '''<remarks></remarks>
        Property CLM12 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLM13 is CHAMPUS nonavailability indicator. A "Y" value indicates a statement of non-availability is on file; an "N" value indicates statement of nonavailability is not on file or not necessary.</remarks>
        Property CLM13 As String

        '''<summary>Level of Service Code</summary>
        '''<remarks></remarks>
        Property CLM14 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLM15 is charges itemized by service indicator. A "Y" value indicates charges are itemized by service; an "N" value indicates charges are summarized by service.</remarks>
        Property CLM15 As String

        '''<summary>Provider Agreement Code</summary>
        '''<remarks></remarks>
        Property CLM16 As String

        '''<summary>Claim Status Code</summary>
        '''<remarks></remarks>
        Property CLM17 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLM18 is explanation of benefit (EOB) indicator. A "Y" value indicates that a paper EOB is requested; an "N" value indicates that no paper EOB is requested.</remarks>
        Property CLM18 As String

        '''<summary>Claim Submission Reason Code</summary>
        '''<remarks></remarks>
        Property CLM19 As String

        '''<summary>Delay Reason Code</summary>
        '''<remarks></remarks>
        Property CLM20 As String

    End Interface
End NameSpace