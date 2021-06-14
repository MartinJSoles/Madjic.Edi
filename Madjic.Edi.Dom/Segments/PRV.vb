Namespace Segments
    '''<summary>Provider Information</summary>
    '''<remarks>To specify the identifying characteristics of a provider</remarks>
    Partial Friend Class PRV_Obj
        Inherits Segment
        Implements PRV,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.PRV,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.PRV,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PRV,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.PRV,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PRV,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.PRV,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310A.PRV
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PRV")
            Elements.AddRange({CType(Nothing, DataElements.Element1221),
                                      CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Composite.C035_Obj),
                                      CType(Nothing, DataElements.Element1223)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PRV01 As String Implements PRV.PRV01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV.PRV01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV.PRV01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV.PRV01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.PRV.PRV01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.PRV.PRV01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PRV.PRV01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.PRV.PRV01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PRV.PRV01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV.PRV01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV.PRV01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV.PRV01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV.PRV01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV.PRV01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV.PRV01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV.PRV01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV.PRV01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.PRV.PRV01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310A.PRV.PRV01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1221).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1221
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1221).Value = value
                End If
            End Set
        End Property

        Friend Property PRV02 As String Implements PRV.PRV02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV.PRV02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV.PRV02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV.PRV02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.PRV.PRV02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.PRV.PRV02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PRV.PRV02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.PRV.PRV02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PRV.PRV02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV.PRV02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV.PRV02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV.PRV02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV.PRV02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV.PRV02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV.PRV02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV.PRV02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV.PRV02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.PRV.PRV02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310A.PRV.PRV02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element128
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property PRV03 As String Implements PRV.PRV03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV.PRV03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV.PRV03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV.PRV03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.PRV.PRV03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.PRV.PRV03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PRV.PRV03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.PRV.PRV03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PRV.PRV03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PRV.PRV03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PRV.PRV03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PRV.PRV03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.PRV.PRV03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PRV.PRV03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PRV.PRV03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310B.PRV.PRV03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310B.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310D.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420B.PRV.PRV03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000A.PRV.PRV03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310A.PRV.PRV03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property PRV04 As String Implements PRV.PRV04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element156
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property PRV05 As DataElements.Composite.C035 Implements PRV.PRV05
            Get
                Return CType(Elements(4), DataElements.Composite.C035_Obj)
            End Get
            Set(value As DataElements.Composite.C035)
                Elements(4) = value
            End Set
        End Property

        Friend Property PRV06 As String Implements PRV.PRV06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1223).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1223
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1223).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PRV
            Dim rval As New PRV_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PRV01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PRV02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PRV03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PRV04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C035_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .PRV06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Provider Information</summary>
    '''<remarks>To specify the identifying characteristics of a provider</remarks>
    Public Interface PRV
        Inherits ISegment

        '''<summary>Provider Code</summary>
        '''<remarks></remarks>
        Property PRV01 As String

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property PRV02 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property PRV03 As String

        '''<summary>State or Province Code</summary>
        '''<remarks></remarks>
        Property PRV04 As String

        '''<summary>Provider Specialty Information</summary>
        '''<remarks></remarks>
        Property PRV05 As DataElements.Composite.C035

        '''<summary>Provider Organization Code</summary>
        '''<remarks></remarks>
        Property PRV06 As String

    End Interface
End NameSpace