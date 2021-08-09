Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Health Care Code Information</summary>
    '''<remarks>To send health care codes and their associated dates, amounts and quantities</remarks>
    Partial Friend Class C022_Obj
        Inherits CompositeElement
        Implements C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06.C022,
                   Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07.
            C022, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06.C022,
                   Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07.
            C022, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.
            C022, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10.C022,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11.
            C022, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_12.
            C022, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.HI_1_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_12.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.HI_4_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_12.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.HI_6_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_12.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_12.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_01.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_02.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_03.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_04.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_05.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_06.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_07.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_08.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_09.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_10.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_11.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_12.
            C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_01.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_02.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_03.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_04.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_05.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_06.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_07.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_08.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_09.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_10.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_11.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
            HI_10_12.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_01.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_02.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_03.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_04.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_05.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_06.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_07.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_08.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_09.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_10.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_11.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
            HI_11_12.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_01.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_02.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_03.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_04.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_05.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_06.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_07.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_08.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_09.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_10.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_11.C022,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
            HI_12_12.C022

        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                          New SyntaxRuleExclusion({8, 9}),
                                                          New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1270),
                                         CType(Nothing, Element1271),
                                         CType(Nothing, Element1250),
                                         CType(Nothing, Element1251),
                                         CType(Nothing, Element782),
                                         CType(Nothing, Element380),
                                         CType(Nothing, Element799),
                                         CType(Nothing, Element1271),
                                         CType(Nothing, Element1073)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C022_01 As String _
            Implements C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11 _
                .C022.C022_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12 _
                .C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.
                HI_1_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.
                HI_1_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.
                C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.
                HI_1_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.
                HI_4_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.
                HI_6_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_12.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_01.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_02.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_03.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_04.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_05.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_06.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_07.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_08.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_09.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_10.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_11.C022.C022_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_12.C022.C022_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1270
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property C022_02 As String _
            Implements C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11 _
                .C022.C022_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12 _
                .C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.
                HI_1_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.
                HI_1_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.
                HI_2_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.
                C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.
                HI_1_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.
                HI_2_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.
                HI_4_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.
                HI_6_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.
                HI_11_12.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_01.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_02.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_03.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_04.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_05.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_06.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_07.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_08.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_09.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_10.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_11.C022.C022_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.
                HI_12_12.C022.C022_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1271
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property C022_03 As String _
            Implements C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_03,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.
                HI_6_01.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_01.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_02.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_03.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_04.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_05.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_06.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_07.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_08.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_09.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_10.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_11.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_12.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_01.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_02.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_03.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_04.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_05.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_06.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_07.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_08.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_09.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_10.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_11.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_12.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_01.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_02.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_03.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_04.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_05.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_06.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_07.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_08.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_09.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_10.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_11.C022.C022_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_12.C022.C022_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1250
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property C022_04 As String _
            Implements C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11 _
                .C022.C022_04,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12 _
                .C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.
                HI_6_01.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_01.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_02.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_03.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_04.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_05.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_06.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_07.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_08.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_09.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_10.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_11.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.
                HI_7_12.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_01.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_02.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_03.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_04.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_05.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_06.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_07.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_08.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_09.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_10.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_11.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.
                HI_8_12.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_01.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_02.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_03.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_04.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_05.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_06.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_07.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_08.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_09.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_10.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_11.C022.C022_04,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.
                HI_9_12.C022.C022_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1251
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property C022_05 As Decimal? _
            Implements C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_01.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_02.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_03.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_04.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_05.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_06.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_07.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_08.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_09.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_10.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_11.C022.C022_05,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.
                HI_10_12.C022.C022_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element782
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element782).Value = value
                End If
            End Set
        End Property

        Friend Property C022_06 As Decimal? Implements C022.C022_06
            Get
                Return If(SubElements(5) IsNot Nothing, CType(SubElements(5), Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(5) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(5) = New Element380
                End If

                If SubElements(5) IsNot Nothing Then
                    CType(SubElements(5), Element380).Value = value
                End If
            End Set
        End Property

        Friend Property C022_07 As String Implements C022.C022_07
            Get
                Return If(SubElements(6) IsNot Nothing, CType(SubElements(6), Element799).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(6) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(6) = New Element799
                End If

                If SubElements(6) IsNot Nothing Then
                    CType(SubElements(6), Element799).Value = value
                End If
            End Set
        End Property

        Friend Property C022_08 As String Implements C022.C022_08
            Get
                Return If(SubElements(7) IsNot Nothing, CType(SubElements(7), Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(7) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(7) = New Element1271
                End If

                If SubElements(7) IsNot Nothing Then
                    CType(SubElements(7), Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property C022_09 As String _
            Implements C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.
                C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_01.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_02.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_03.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_04.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_05.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_06.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_07.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_08.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_09.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_10.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_11.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.
                HI_3_12.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_01.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_02.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_03.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_04.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_05.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_06.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_07.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_08.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_09.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_10.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_11.C022.C022_09,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.
                HI_5_12.C022.C022_09
            Get
                Return If(SubElements(8) IsNot Nothing, CType(SubElements(8), Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(8) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(8) = New Element1073
                End If

                If SubElements(8) IsNot Nothing Then
                    CType(SubElements(8), Element1073).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C022_01 = values(0)
            End If
            If values.Length > 1 Then
                C022_02 = values(1)
            End If
            If values.Length > 2 Then
                C022_03 = values(2)
            End If
            If values.Length > 3 Then
                C022_04 = values(3)
            End If
            If values.Length > 4 Then
                C022_05 = values(4).ToFloat
            End If
            If values.Length > 5 Then
                C022_06 = values(5).ToFloat
            End If
            If values.Length > 6 Then
                C022_07 = values(6)
            End If
            If values.Length > 7 Then
                C022_08 = values(7)
            End If
            If values.Length > 8 Then
                C022_09 = values(8)
            End If
        End Sub
        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C022_Obj
            Dim rval As New C022_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Health Care Code Information</summary>
    '''<remarks>To send health care codes and their associated dates, amounts and quantities</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C022
        '''<summary>Code List Qualifier Code</summary>
        '''<remarks> 
        '''<para>Code identifying a specific industry code list</para>
        '''</remarks>
        Property C022_01 As String

        '''<summary>Industry Code</summary>
        '''<remarks> 
        '''<para>Code indicating a code from a specific industry code list</para>
        '''</remarks>
        Property C022_02 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks> 
        '''<para>Code indicating the date format, time format, or date and time format</para>
        '''</remarks>
        Property C022_03 As String

        '''<summary>Date Time Period</summary>
        '''<remarks> 
        '''<para>Expression of a date, a time, or range of dates, times or dates and times</para>
        '''</remarks>
        Property C022_04 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks> 
        '''<para>Monetary amount</para>
        '''</remarks>
        Property C022_05 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks> 
        '''<para>Numeric value of quantity</para>
        '''</remarks>
        Property C022_06 As Decimal?

        '''<summary>Version Identifier</summary>
        '''<remarks> 
        '''<para>Revision level of a particular format, program, technique or algorithm</para>
        '''</remarks>
        Property C022_07 As String

        '''<summary>Industry Code</summary>
        '''<remarks> 
        '''<para>Code indicating a code from a specific industry code list</para>
        '''</remarks>
        Property C022_08 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks> 
        '''<para>Code indicating a Yes or No condition or response</para>
        '''</remarks>
        Property C022_09 As String
    End Interface
End Namespace