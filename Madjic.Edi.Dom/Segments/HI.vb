Namespace Segments
    '''<summary>Health Care Information Codes</summary>
    '''<remarks>To supply information related to the delivery of health care</remarks>
    Partial Friend Class HI_Obj
        Inherits Segment
        Implements HI,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_2,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_4,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_6,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("HI")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj),
                                      CType(Nothing, DataElements.Composite.C022_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HI01 As DataElements.Composite.C022 Implements HI.HI01
            Get
                Return CType(Elements(0), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(0) = value
            End Set
        End Property

        Private Property HI01_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_01.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_1.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_9 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_01.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_10 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI.HI_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.HI_1_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_1.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.HI_1_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_1.HI_1_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_2.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.HI_4_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_4.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.HI_4_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_4.HI_4_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_17 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.HI_6_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_6.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.HI_6_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_6.HI_6_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_18 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_19 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_20 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_21 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_22 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_01.C022)
                HI01 = value
            End Set
        End Property

        Private Property HI01_IFace_23 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_01.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI01
            Get
                Return CType(HI01, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_01.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_01.C022)
                HI01 = value
            End Set
        End Property

        Friend Property HI02 As DataElements.Composite.C022 Implements HI.HI02
            Get
                Return CType(Elements(1), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(1) = value
            End Set
        End Property

        Private Property HI02_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_02.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_1.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_1.HI_1_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_9 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_02.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_10 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_2.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_17 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_18 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_02.C022)
                HI02 = value
            End Set
        End Property

        Private Property HI02_IFace_19 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_02.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI02
            Get
                Return CType(HI02, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_02.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_02.C022)
                HI02 = value
            End Set
        End Property

        Friend Property HI03 As DataElements.Composite.C022 Implements HI.HI03
            Get
                Return CType(Elements(2), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(2) = value
            End Set
        End Property

        Private Property HI03_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_03.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_9 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_2.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_2.HI_2_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_17 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_03.C022)
                HI03 = value
            End Set
        End Property

        Private Property HI03_IFace_18 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_03.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI03
            Get
                Return CType(HI03, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_03.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_03.C022)
                HI03 = value
            End Set
        End Property

        Friend Property HI04 As DataElements.Composite.C022 Implements HI.HI04
            Get
                Return CType(Elements(3), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(3) = value
            End Set
        End Property

        Private Property HI04_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_04.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_9 As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.HI.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.HI.HI_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_04.C022)
                HI04 = value
            End Set
        End Property

        Private Property HI04_IFace_17 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_04.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI04
            Get
                Return CType(HI04, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_04.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_04.C022)
                HI04 = value
            End Set
        End Property

        Friend Property HI05 As DataElements.Composite.C022 Implements HI.HI05
            Get
                Return CType(Elements(4), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(4) = value
            End Set
        End Property

        Private Property HI05_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_05.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_05.C022)
                HI05 = value
            End Set
        End Property

        Private Property HI05_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_05.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI05
            Get
                Return CType(HI05, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_05.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_05.C022)
                HI05 = value
            End Set
        End Property

        Friend Property HI06 As DataElements.Composite.C022 Implements HI.HI06
            Get
                Return CType(Elements(5), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(5) = value
            End Set
        End Property

        Private Property HI06_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_06.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_06.C022)
                HI06 = value
            End Set
        End Property

        Private Property HI06_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_06.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI06
            Get
                Return CType(HI06, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_06.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_06.C022)
                HI06 = value
            End Set
        End Property

        Friend Property HI07 As DataElements.Composite.C022 Implements HI.HI07
            Get
                Return CType(Elements(6), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(6) = value
            End Set
        End Property

        Private Property HI07_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_07.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_07.C022)
                HI07 = value
            End Set
        End Property

        Private Property HI07_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_07.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI07
            Get
                Return CType(HI07, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_07.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_07.C022)
                HI07 = value
            End Set
        End Property

        Friend Property HI08 As DataElements.Composite.C022 Implements HI.HI08
            Get
                Return CType(Elements(7), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(7) = value
            End Set
        End Property

        Private Property HI08_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100C.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08.C022 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2100D.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_2 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100C.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_3 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08.C022 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2100D.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_4 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_5 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_6 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_7 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_8 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_08.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_13 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_14 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_15 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_08.C022)
                HI08 = value
            End Set
        End Property

        Private Property HI08_IFace_16 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_08.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI08
            Get
                Return CType(HI08, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_08.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_08.C022)
                HI08 = value
            End Set
        End Property

        Friend Property HI09 As DataElements.Composite.C022 Implements HI.HI09
            Get
                Return CType(Elements(8), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(8) = value
            End Set
        End Property

        Private Property HI09_IFace As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI09
            Get
                Return CType(HI09, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_1 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI09
            Get
                Return CType(HI09, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_2 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI09
            Get
                Return CType(HI09, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_3 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_4 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_09.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_5 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_6 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_7 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_8 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_09.C022)
                HI09 = value
            End Set
        End Property

        Private Property HI09_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_09.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI09
            Get
                Return CType(HI09, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_09.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_09.C022)
                HI09 = value
            End Set
        End Property

        Friend Property HI10 As DataElements.Composite.C022 Implements HI.HI10
            Get
                Return CType(Elements(9), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(9) = value
            End Set
        End Property

        Private Property HI10_IFace As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI10
            Get
                Return CType(HI10, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_1 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI10
            Get
                Return CType(HI10, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_2 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI10
            Get
                Return CType(HI10, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_3 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_4 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_10.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_5 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_6 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_7 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_8 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_10.C022)
                HI10 = value
            End Set
        End Property

        Private Property HI10_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_10.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI10
            Get
                Return CType(HI10, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_10.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_10.C022)
                HI10 = value
            End Set
        End Property

        Friend Property HI11 As DataElements.Composite.C022 Implements HI.HI11
            Get
                Return CType(Elements(10), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(10) = value
            End Set
        End Property

        Private Property HI11_IFace As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI11
            Get
                Return CType(HI11, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_1 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI11
            Get
                Return CType(HI11, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_2 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI11
            Get
                Return CType(HI11, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_3 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_4 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_11.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_5 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_6 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_7 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_8 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_11.C022)
                HI11 = value
            End Set
        End Property

        Private Property HI11_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_11.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI11
            Get
                Return CType(HI11, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_11.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_11.C022)
                HI11 = value
            End Set
        End Property

        Friend Property HI12 As DataElements.Composite.C022 Implements HI.HI12
            Get
                Return CType(Elements(11), DataElements.Composite.C022_Obj)
            End Get
            Set(value As DataElements.Composite.C022)
                Elements(11) = value
            End Set
        End Property

        Private Property HI12_IFace As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.HI.HI12
            Get
                Return CType(HI12, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.HI.HI_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_1 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HI.HI12
            Get
                Return CType(HI12, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.HI.HI_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_2 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12.C022 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HI.HI12
            Get
                Return CType(HI12, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12.C022)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.HI.HI_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_3 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI.HI_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_4 As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_12.C022 Implements Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.HI_2.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.HI_2.HI_2_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_5 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_3.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_3.HI_3_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_6 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_5.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_5.HI_5_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_7 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_7.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_7.HI_7_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_8 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_8.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_8.HI_8_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_9 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_9.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_9.HI_9_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_10 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_10.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_10.HI_10_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_11 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_11.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_11.HI_11_12.C022)
                HI12 = value
            End Set
        End Property

        Private Property HI12_IFace_12 As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_12.C022 Implements Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.HI_12.HI12
            Get
                Return CType(HI12, Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_12.C022)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.HI_12.HI_12_12.C022)
                HI12 = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HI
            Dim rval As New HI_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .Elements(1) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(1), reader)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(2), reader)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .Elements(5) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(5), reader)
                End If
                If source.Elements.Count > 6 Then
                    .Elements(6) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(6), reader)
                End If
                If source.Elements.Count > 7 Then
                    .Elements(7) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(7), reader)
                End If
                If source.Elements.Count > 8 Then
                    .Elements(8) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(8), reader)
                End If
                If source.Elements.Count > 9 Then
                    .Elements(9) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(9), reader)
                End If
                If source.Elements.Count > 10 Then
                    .Elements(10) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(10), reader)
                End If
                If source.Elements.Count > 11 Then
                    .Elements(11) = DataElements.Composite.C022_Obj.FromReader(source.ToStringValue(11), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Care Information Codes</summary>
    '''<remarks>To supply information related to the delivery of health care</remarks>
    Public Interface HI
        Inherits ISegment

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI01 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI02 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI03 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI04 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI05 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI06 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI07 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI08 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI09 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI10 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI11 As DataElements.Composite.C022

        '''<summary>Health Care Code Information</summary>
        '''<remarks></remarks>
        Property HI12 As DataElements.Composite.C022

    End Interface
End NameSpace