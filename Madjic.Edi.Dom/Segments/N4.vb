Namespace Segments
    '''<summary>Geographic Location</summary>
    '''<remarks>To specify the geographic place of the named party</remarks>
    Partial Friend Class N4_Obj
        Inherits Segment
        Implements N4,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleExclusion({2, 7}),
                                                 New SyntaxRuleConditional(6, {5}),
                                                 New SyntaxRuleConditional(7, {4})}

        Public Sub New()
            MyBase.New("N4")
            Elements.AddRange({CType(Nothing, DataElements.Element19),
                                      CType(Nothing, DataElements.Element156),
                                      CType(Nothing, DataElements.Element116),
                                      CType(Nothing, DataElements.Element26),
                                      CType(Nothing, DataElements.Element309),
                                      CType(Nothing, DataElements.Element310),
                                      CType(Nothing, DataElements.Element1715)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property N401 As String Implements N4.N401, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4.N401, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4.N401, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4.N401, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4.N401, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4.N401, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N401, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4.N401, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4.N401, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4.N401, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4.N401, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4.N401, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4.N401, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4.N401, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4.N401, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4.N401, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4.N401, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4.N401, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4.N401, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4.N401
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element19).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element19
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element19).Value = value
                End If
            End Set
        End Property

        Friend Property N402 As String Implements N4.N402, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4.N402, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4.N402, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4.N402, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4.N402, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4.N402, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N402, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4.N402, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4.N402, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4.N402, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4.N402, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4.N402, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4.N402, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4.N402, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4.N402, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4.N402, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4.N402, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4.N402, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4.N402, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4.N402
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element156
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Property N403 As String Implements N4.N403, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4.N403, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4.N403, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4.N403, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4.N403, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4.N403, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N403, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4.N403, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N4.N403, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4.N403, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4.N403, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4.N403, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4.N403, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4.N403, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4.N403, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4.N403, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4.N403, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4.N403, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4.N403, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4.N403
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element116).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element116
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element116).Value = value
                End If
            End Set
        End Property

        Friend Property N404 As String Implements N4.N404, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4.N404, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4.N404, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4.N404, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4.N404, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4.N404, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N404, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4.N404, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N404, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4.N404, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4.N404, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4.N404, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4.N404, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4.N404, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4.N404, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4.N404, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4.N404, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4.N404, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4.N404, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4.N404, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4.N404, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4.N404, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4.N404, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4.N404
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element26).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element26
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element26).Value = value
                End If
            End Set
        End Property

        Friend Property N405 As String Implements N4.N405, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N405, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N405, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N405
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element309).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element309
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element309).Value = value
                End If
            End Set
        End Property

        Friend Property N406 As String Implements N4.N406, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N406, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N406, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N406
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element310).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element310
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element310).Value = value
                End If
            End Set
        End Property

        Friend Property N407 As String Implements N4.N407, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4.N407, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4.N407, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4.N407, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N4.N407, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N4.N407, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N4.N407, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N4.N407, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N4.N407, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N4.N407, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N4.N407, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N4.N407, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N4.N407, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N4.N407, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N4.N407, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N4.N407, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N4.N407, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N4.N407, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N4.N407, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N4.N407, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N4.N407, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N4.N407, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N4.N407, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N4.N407
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1715).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1715
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1715).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As N4
            Dim rval As New N4_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .N401 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .N402 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .N403 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .N404 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .N405 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .N406 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .N407 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Geographic Location</summary>
    '''<remarks>To specify the geographic place of the named party</remarks>
    Public Interface N4
        Inherits ISegment

        '''<summary>City Name</summary>
        '''<remarks>A combination of either N401 through N404, or N405 and N406 may be adequate to specify a location.</remarks>
        Property N401 As String

        '''<summary>State or Province Code</summary>
        '''<remarks>N402 is required only if city name (N401) is in the U.S. or Canada.</remarks>
        Property N402 As String

        '''<summary>Postal Code</summary>
        '''<remarks></remarks>
        Property N403 As String

        '''<summary>Country Code</summary>
        '''<remarks></remarks>
        Property N404 As String

        '''<summary>Location Qualifier</summary>
        '''<remarks></remarks>
        Property N405 As String

        '''<summary>Location Identifier</summary>
        '''<remarks></remarks>
        Property N406 As String

        '''<summary>Country Subdivision Code</summary>
        '''<remarks></remarks>
        Property N407 As String

    End Interface
End NameSpace