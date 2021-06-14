Namespace Segments
    '''<summary>Professional Service</summary>
    '''<remarks>To specify the service line item detail for a health care professional</remarks>
    Partial Friend Class SV1_Obj
        Inherits Segment
        Implements SV1,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SV1")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1331),
                                      CType(Nothing, DataElements.Element1365),
                                      CType(Nothing, DataElements.Composite.C004_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1340),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1364),
                                      CType(Nothing, DataElements.Element1341),
                                      CType(Nothing, DataElements.Element1327),
                                      CType(Nothing, DataElements.Element1334),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element116),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1337),
                                      CType(Nothing, DataElements.Element1360)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV101 As DataElements.Composite.C003 Implements SV1.SV101, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV101, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV101
            Get
                Return CType(Elements(0), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(0) = value
            End Set
        End Property

        Private Property SV101_IFace As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.SV1_01.C003 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV101
            Get
                Return CType(SV101, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.SV1_01.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2400.SV1.SV1_01.C003)
                SV101 = value
            End Set
        End Property

        Friend Property SV102 As Decimal? Implements SV1.SV102, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV102, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV102
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

        Friend Property SV103 As String Implements SV1.SV103, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV103, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV103, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element355
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property SV104 As Decimal? Implements SV1.SV104, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV104, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV104, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element380
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SV105 As String Implements SV1.SV105, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1331).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1331
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1331).Value = value
                End If
            End Set
        End Property

        Friend Property SV106 As String Implements SV1.SV106
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1365
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1365).Value = value
                End If
            End Set
        End Property

        Friend Property SV107 As DataElements.Composite.C004 Implements SV1.SV107, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV107, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV107
            Get
                Return CType(Elements(6), DataElements.Composite.C004_Obj)
            End Get
            Set(value As DataElements.Composite.C004)
                Elements(6) = value
            End Set
        End Property

        Friend Property SV108 As Decimal? Implements SV1.SV108
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

        Friend Property SV109 As String Implements SV1.SV109, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV109
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1073
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV110 As String Implements SV1.SV110
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1340).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1340
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1340).Value = value
                End If
            End Set
        End Property

        Friend Property SV111 As String Implements SV1.SV111, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV111, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV111, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV111
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1073
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV112 As String Implements SV1.SV112, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV112
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1073
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV113 As String Implements SV1.SV113
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element1364).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element1364
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element1364).Value = value
                End If
            End Set
        End Property

        Friend Property SV114 As String Implements SV1.SV114
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1341).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1341
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1341).Value = value
                End If
            End Set
        End Property

        Friend Property SV115 As String Implements SV1.SV115, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.SV1.SV115
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1327).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1327
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1327).Value = value
                End If
            End Set
        End Property

        Friend Property SV116 As String Implements SV1.SV116
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element1334).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element1334
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element1334).Value = value
                End If
            End Set
        End Property

        Friend Property SV117 As String Implements SV1.SV117
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element127
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property SV118 As String Implements SV1.SV118
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element116).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element116
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element116).Value = value
                End If
            End Set
        End Property

        Friend Property SV119 As Decimal? Implements SV1.SV119
            Get
                Return If(Elements(18) IsNot Nothing, CType(Elements(18), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(18) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(18) = New DataElements.Element782
                End If

                If Elements(18) IsNot Nothing Then
                    CType(Elements(18), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property SV120 As String Implements SV1.SV120, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV1.SV120, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV1.SV120
            Get
                Return If(Elements(19) IsNot Nothing, CType(Elements(19), DataElements.Element1337).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(19) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(19) = New DataElements.Element1337
                End If

                If Elements(19) IsNot Nothing Then
                    CType(Elements(19), DataElements.Element1337).Value = value
                End If
            End Set
        End Property

        Friend Property SV121 As String Implements SV1.SV121
            Get
                Return If(Elements(20) IsNot Nothing, CType(Elements(20), DataElements.Element1360).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(20) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(20) = New DataElements.Element1360
                End If

                If Elements(20) IsNot Nothing Then
                    CType(Elements(20), DataElements.Element1360).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV1
            Dim rval As New SV1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .SV102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SV103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV104 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SV105 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV106 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .Elements(6) = DataElements.Composite.C004_Obj.FromReader(source.ToStringValue(6), reader)
                End If
                If source.Elements.Count > 7 Then
                    .SV108 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SV109 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SV110 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .SV111 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .SV112 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .SV113 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .SV114 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .SV115 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .SV116 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .SV117 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .SV118 = source.ToStringValue(17)
                End If
                If source.Elements.Count > 18 Then
                    .SV119 = source.ToFloatValue(18)
                End If
                If source.Elements.Count > 19 Then
                    .SV120 = source.ToStringValue(19)
                End If
                If source.Elements.Count > 20 Then
                    .SV121 = source.ToStringValue(20)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Professional Service</summary>
    '''<remarks>To specify the service line item detail for a health care professional</remarks>
    Public Interface SV1
        Inherits ISegment

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV101 As DataElements.Composite.C003

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV102 is the submitted service line item amount.</remarks>
        Property SV102 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property SV103 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property SV104 As Decimal?

        '''<summary>Facility Code Value</summary>
        '''<remarks>SV105 is the place of service.</remarks>
        Property SV105 As String

        '''<summary>Service Type Code</summary>
        '''<remarks></remarks>
        Property SV106 As String

        '''<summary>Composite Diagnosis Code Pointer</summary>
        '''<remarks></remarks>
        Property SV107 As DataElements.Composite.C004

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV108 is the independent lab charges.</remarks>
        Property SV108 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV109 is the emergency-related indicator; a "Y" value indicates service provided was emergency related; an "N" value indicates service provided was not emergency related.</remarks>
        Property SV109 As String

        '''<summary>Multiple Procedure Code</summary>
        '''<remarks></remarks>
        Property SV110 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV111 is early and periodic screen for diagnosis and treatment of children (EPSDT) involvement; a "Y" value indicates EPSDT involvement; an "N" value indicates no EPSDT involvement.</remarks>
        Property SV111 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV112 is the family planning involvement indicator. A "Y" value indicates family planning services involvement; an "N" value indicates no family planning services involvement.</remarks>
        Property SV112 As String

        '''<summary>Review Code</summary>
        '''<remarks>If SV113 is equal to "L" or "N", then SV114 is required.</remarks>
        Property SV113 As String

        '''<summary>National or Local Assigned Review Value</summary>
        '''<remarks></remarks>
        Property SV114 As String

        '''<summary>Copay Status Code</summary>
        '''<remarks></remarks>
        Property SV115 As String

        '''<summary>Health Care Professional Shortage Area Code</summary>
        '''<remarks></remarks>
        Property SV116 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>SV117 is the health care manpower shortage area (HMSA) facility identification.</remarks>
        Property SV117 As String

        '''<summary>Postal Code</summary>
        '''<remarks>SV118 is the health care manpower shortage area (HMSA) zip code.</remarks>
        Property SV118 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV119 is a non-covered service amount.</remarks>
        Property SV119 As Decimal?

        '''<summary>Level of Care Code</summary>
        '''<remarks></remarks>
        Property SV120 As String

        '''<summary>Provider Agreement Code</summary>
        '''<remarks></remarks>
        Property SV121 As String

    End Interface
End NameSpace