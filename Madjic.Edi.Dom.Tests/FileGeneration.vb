Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class FileGeneration

    'Builds an 837 professional from the Implementation Guide examples
    <TestMethod()> Async Function Create837ProFile() As Task
        Dim Doc = BuildDocument(True, "00", "", ":"c, "*"c, "^"c, "~"c, 1, #12/31/2020 12:50:00 AM#, "ZZ", "123456789", "ZZ", "12345678", False, "00", "", 222222222, "SUBMITTERID", "CMS", #3/8/2019 7:34:00#)
        Dim Ts = Factory.Transaction837_Q1.TransactionSetFactory.CreateTransaction837_Q1("1234")

        Doc.Envelopes(0).FunctionalGroups(0).AddTransactionSet(Ts)

        Ts.BHT = Factory.Transaction837_Q1.TransactionSetFactory.CreateBHT()

        With Ts.BHT
            .BHT01 = "0019"
            .BHT02 = "00"
            .BHT03 = "244579"
            .BHT04 = #10/15/2006#
            .BHT05 = New TimeSpan(10, 23, 0)
            .BHT06 = "CH"
        End With

        Ts.Loop1000A = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop1000A()
        Ts.Loop1000A.NM1 = Factory.Transaction837_Q1.Loop1000AFactory.CreateNM1()
        Ts.Loop1000A.PER.Add(Factory.Transaction837_Q1.Loop1000AFactory.CreatePER())

        Ts.Loop1000B = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop1000B()
        Ts.Loop1000B.NM1 = Factory.Transaction837_Q1.Loop1000BFactory.CreateNM1()

        With Ts.Loop1000A
            With .NM1
                .NM101 = "41"
                .NM102 = "2"
                .NM103 = "PREMIER BILLING SERVICE"
                .NM108 = "46"
                .NM109 = "TGJ23"
            End With

            With .PER(0)
                .PER01 = "IC"
                .PER02 = "JERRY"
                .PER03 = "TE"
                .PER04 = "3055552222"
                .PER05 = "EX"
                .PER06 = "231"
            End With

        End With

        With Ts.Loop1000B.NM1
            .NM101 = "40"
            .NM102 = "2"
            .NM103 = "KEY INSURANCE COMPANY"
            .NM108 = "46"
            .NM109 = "66783JJT"
        End With


        Ts.Loop2000A.Add(Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2000A())
        Ts.Loop2000A(0).HL = Factory.Transaction837_Q1.Loop2000AFactory.CreateHL()
        Ts.Loop2000A(0).PRV = Factory.Transaction837_Q1.Loop2000AFactory.CreatePRV()

        Ts.Loop2000A(0).Loop2010AA = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2010AA()
        Ts.Loop2000A(0).Loop2010AA.NM1 = Factory.Transaction837_Q1.Loop2010AAFactory.CreateNM1()
        Ts.Loop2000A(0).Loop2010AA.N3 = Factory.Transaction837_Q1.Loop2010AAFactory.CreateN3()
        Ts.Loop2000A(0).Loop2010AA.N4 = Factory.Transaction837_Q1.Loop2010AAFactory.CreateN4()
        Ts.Loop2000A(0).Loop2010AA.REF = Factory.Transaction837_Q1.Loop2010AAFactory.CreateREF()

        Ts.Loop2000A(0).Loop2010AB = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2010AB()
        Ts.Loop2000A(0).Loop2010AB.NM1 = Factory.Transaction837_Q1.Loop2010ABFactory.CreateNM1()
        Ts.Loop2000A(0).Loop2010AB.N3 = Factory.Transaction837_Q1.Loop2010ABFactory.CreateN3()
        Ts.Loop2000A(0).Loop2010AB.N4 = Factory.Transaction837_Q1.Loop2010ABFactory.CreateN4()

        Ts.Loop2000B.Add(Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2000B())
        Ts.Loop2000B(0).HL = Factory.Transaction837_Q1.Loop2000BFactory.CreateHL()
        Ts.Loop2000B(0).SBR = Factory.Transaction837_Q1.Loop2000BFactory.CreateSBR()

        Ts.Loop2000B(0).Loop2010BA = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2010BA()
        Ts.Loop2000B(0).Loop2010BA.NM1 = Factory.Transaction837_Q1.Loop2010BAFactory.CreateNM1()
        Ts.Loop2000B(0).Loop2010BA.DMG = Factory.Transaction837_Q1.Loop2010BAFactory.CreateDMG()

        Ts.Loop2000B(0).Loop2010BB = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2010BB()
        Ts.Loop2000B(0).Loop2010BB.NM1 = Factory.Transaction837_Q1.Loop2010BBFactory.CreateNM1()
        Ts.Loop2000B(0).Loop2010BB.REF_1.Add(Factory.Transaction837_Q1.Loop2010BBFactory.CreateREF_1())

        Ts.Loop2000C.Add(Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2000C())
        Ts.Loop2000C(0).HL = Factory.Transaction837_Q1.Loop2000CFactory.CreateHL()
        Ts.Loop2000C(0).PAT = Factory.Transaction837_Q1.Loop2000CFactory.CreatePAT()

        Ts.Loop2000C(0).Loop2010CA = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2010CA()
        Ts.Loop2000C(0).Loop2010CA.NM1 = Factory.Transaction837_Q1.Loop2010CAFactory.CreateNM1()
        Ts.Loop2000C(0).Loop2010CA.N3 = Factory.Transaction837_Q1.Loop2010CAFactory.CreateN3()
        Ts.Loop2000C(0).Loop2010CA.N4 = Factory.Transaction837_Q1.Loop2010CAFactory.CreateN4()
        Ts.Loop2000C(0).Loop2010CA.DMG = Factory.Transaction837_Q1.Loop2010CAFactory.CreateDMG

        With Ts.Loop2000A(0)
            With .HL
                .HL01 = "1"
                .HL03 = "20"
                .HL04 = "1"
            End With

            With .PRV
                .PRV01 = "BI"
                .PRV02 = "PXC"
                .PRV03 = "203BF0100Y"
            End With

            With .Loop2010AA
                With .NM1
                    .NM101 = "85"
                    .NM102 = "2"
                    .NM103 = "BEN KILDARE SERVICE"
                    .NM108 = "XX"
                    .NM109 = "9876543210"
                End With

                .N3.N301 = "231 SEAWAY ST"

                With .N4
                    .N401 = "MIAMI"
                    .N402 = "FL"
                    .N403 = "33111"
                End With

                With .REF
                    .REF01 = "EI"
                    .REF02 = "587654321"
                End With
            End With

            With .Loop2010AB
                With .NM1
                    .NM101 = "87"
                    .NM102 = "2"
                End With

                .N3.N301 = "2345 OCEAN BLVD"

                With .N4
                    .N401 = "MIAMI"
                    .N402 = "FL"
                    .N403 = "33111"
                End With
            End With
        End With

        With Ts.Loop2000B(0)
            With .HL
                .HL01 = "2"
                .HL02 = "1"
                .HL03 = "22"
                .HL04 = "1"
            End With

            With .SBR
                .SBR01 = "P"
                .SBR03 = "2222-SJ"
                .SBR09 = "CI"
            End With

            With .Loop2010BA
                With .NM1
                    .NM101 = "IL"
                    .NM102 = "1"
                    .NM103 = "SMITH"
                    .NM104 = "JANE"
                    .NM108 = "MI"
                    .NM109 = "JS00111223333"
                End With

                With .DMG
                    .DMG01 = "D8"
                    .DMG02 = "19430501"
                    .DMG03 = "F"
                End With
            End With

            With .Loop2010BB
                With .NM1
                    .NM101 = "PR"
                    .NM102 = "2"
                    .NM103 = "KEY INSURANCE COMPANY"
                    .NM108 = "PI"
                    .NM109 = "999996666"
                End With

                With .REF_1(0)
                    .REF01 = "G2"
                    .REF02 = "KA6663"
                End With
            End With
        End With

        With Ts.Loop2000C(0)
            With .HL
                .HL01 = "3"
                .HL02 = "2"
                .HL03 = "23"
                .HL04 = "0"
            End With

            .PAT.PAT01 = "19"

            With .Loop2010CA
                With .NM1
                    .NM101 = "QC"
                    .NM102 = "1"
                    .NM103 = "SMITH"
                    .NM104 = "TED"
                End With

                .N3.N301 = "236 N MAIN ST"

                With .N4
                    .N401 = "MIAMI"
                    .N402 = "FL"
                    .N403 = "33413"
                End With

                With .DMG
                    .DMG01 = "D8"
                    .DMG02 = "19730501"
                    .DMG03 = "M"
                End With
            End With

            .Loop2300.Add(Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2300())

            With .Loop2300(0)
                .CLM = Factory.Transaction837_Q1.Loop2300Factory.CreateCLM()
                .REF_10 = Factory.Transaction837_Q1.Loop2300Factory.CreateREF_10()
                .HI = Factory.Transaction837_Q1.Loop2300Factory.CreateHI()

                With .CLM
                    .CLM01 = "26463774"
                    .CLM02 = "100"
                    .CLM05 = Factory.Transaction837_Q1.Loop2300Factory.CreateCLM05()

                    With .CLM05
                        .C023_01 = "11"
                        .C023_02 = "B"
                        .C023_03 = "1"
                    End With

                    .CLM06 = "Y"
                    .CLM07 = "A"
                    .CLM08 = "Y"
                    .CLM09 = "I"
                End With

                With .REF_10
                    .REF01 = "D9"
                    .REF02 = "17312345600006351"
                End With

                With .HI
                    .HI01 = Factory.Transaction837_Q1.Loop2300Factory.CreateHI01()
                    .HI02 = Factory.Transaction837_Q1.Loop2300Factory.CreateHI02()

                    With .HI01
                        .C022_01 = "BK"
                        .C022_02 = "0340"
                    End With

                    With .HI02
                        .C022_01 = "BF"
                        .C022_02 = "V7389"
                    End With
                End With

                .Loop2400.Add(Build837_Loop2400("1", "99213", 40, "UN", "1", 1, "20061003"))
                .Loop2400.Add(Build837_Loop2400("2", "87070", 15, "UN", "1", 1, "20061003"))
                .Loop2400.Add(Build837_Loop2400("3", "99214", 35, "UN", "1", 2, "20061010"))
                .Loop2400.Add(Build837_Loop2400("4", "86663", 10, "UN", "1", 2, "20061010"))
            End With
        End With

        Dim GeneratedDocument = Await WriteGeneratedDocument(Doc)

        Debug.WriteLine(GeneratedDocument)

        'Compare this to what we are expecting
        Assert.AreEqual(Of String)("ISA*00*          *00*          *ZZ*12345678       *ZZ*123456789      *201231*0050*^*00501*000000001*1*P*:~GS*HC*SUBMITTERID*CMS*20190308*0734*222222222*X* ~ST*837*1234*005010X222A1~BHT*0019*00*244579*20061015*102300*CH~NM1*41*2*PREMIER BILLING SERVICE*****46*TGJ23~PER*IC*JERRY*TE*3055552222*EX*231~NM1*40*2*KEY INSURANCE COMPANY*****46*66783JJT~HL*1**20*1~PRV*BI*PXC*203BF0100Y~NM1*85*2*BEN KILDARE SERVICE*****XX*9876543210~N3*231 SEAWAY ST~N4*MIAMI*FL*33111~REF*EI*587654321~NM1*87*2~N3*2345 OCEAN BLVD~N4*MIAMI*FL*33111~HL*2*1*22*1~SBR*P**2222-SJ******CI~NM1*IL*1*SMITH*JANE****MI*JS00111223333~DMG*D8*19430501*F~NM1*PR*2*KEY INSURANCE COMPANY*****PI*999996666~REF*G2*KA6663~HL*3*2*23*0~PAT*19~NM1*QC*1*SMITH*TED~N3*236 N MAIN ST~N4*MIAMI*FL*33413~DMG*D8*19730501*M~CLM*26463774*100***11:B:1*Y*A*Y*I~REF*D9*17312345600006351~HI*BK:0340*BF:V7389~LX*1~SV1*HC:99213*40*UN****1~DTP*472*D8*20061003~LX*2~SV1*HC:87070*15*UN****1~DTP*472*D8*20061003~LX*3~SV1*HC:99214*35*UN****2~DTP*472*D8*20061010~LX*4~SV1*HC:86663*10*UN****2~DTP*472*D8*20061010~SE*42*1234~GE*1*222222222~IEA*1*000000001~", GeneratedDocument)
    End Function

    Private Function Build837_Loop2400(lx01 As String, sv101_02 As String, sv102 As Decimal, sv103 As String, sv104 As String, sv107_01 As Decimal, dtp03 As String) As Transactions.Transaction837.Transaction837_Q1.Loops.Loop2400
        Dim rval = Factory.Transaction837_Q1.TransactionSetFactory.CreateLoop2400

        With rval
            .LX = Factory.Transaction837_Q1.Loop2400Factory.CreateLX()
            .SV1 = Factory.Transaction837_Q1.Loop2400Factory.CreateSV1()
            .SV1.SV101 = Factory.Transaction837_Q1.Loop2400Factory.CreateSV101
            .SV1.SV107 = Factory.Transaction837_Q1.Loop2400Factory.CreateSV107
            .DTP = Factory.Transaction837_Q1.Loop2400Factory.CreateDTP

            .LX.LX01 = lx01
            .SV1.SV101.C003_01 = "HC"
            .SV1.SV101.C003_02 = sv101_02
            .SV1.SV102 = sv102
            .SV1.SV103 = sv103
            .SV1.SV107.C004_01 = sv107_01
            .DTP.DTP01 = "472"
            .DTP.DTP02 = "D8"
            .DTP.DTP03 = dtp03
        End With

        Return rval
    End Function

    <TestMethod()> Async Function Create270File() As Task
        Dim Doc = BuildDocument(True, "00", "", ":"c, "*"c, "^"c, "~"c, 1, #12/31/2020 12:50:00 AM#, "ZZ", "123456789", "ZZ", "12345678", False, "00", "", 222222222, "SUBMITTERID", "CMS", #3/8/2019 7:34:00#)
        Dim Ts = Factory.Transaction270_B1.TransactionSetFactory.CreateTransaction270_B1("1234")

        Doc.Envelopes(0).FunctionalGroups(0).AddTransactionSet(Ts)

        Ts.BHT = Factory.Transaction270_B1.TransactionSetFactory.CreateBHT
        Ts.Loop2000A.Add(Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2000A)

        With Ts.BHT
            .BHT01 = "0022"
            .BHT02 = "13"
            .BHT03 = "10001234"
            .BHT04 = #5/1/2006#
            .BHT05 = New TimeSpan(13, 19, 0)
        End With

        With Ts.Loop2000A(0)
            .HL = Factory.Transaction270_B1.Loop2000AFactory.CreateHL
            .HL.HL01 = "1"
            .HL.HL03 = "20"
            .HL.HL04 = "1"

            .Loop2100A = Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2100A()

            .Loop2100A.NM1 = Factory.Transaction270_B1.Loop2100AFactory.CreateNM1

            With .Loop2100A.NM1
                .NM101 = "PR"
                .NM102 = "2"
                .NM103 = "ABC COMPANY"
                .NM108 = "PI"
                .NM109 = "842610001"
            End With
        End With

        Ts.Loop2000B.Add(Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2000B)

        With Ts.Loop2000B(0)
            .HL = Factory.Transaction270_B1.Loop2000BFactory.CreateHL

            With .HL
                .HL01 = "2"
                .HL02 = "1"
                .HL03 = "21"
                .HL04 = "1"
            End With

            .Loop2100B = Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2100B()

            .Loop2100B.NM1 = Factory.Transaction270_B1.Loop2100BFactory.CreateNM1()

            With .Loop2100B.NM1
                .NM101 = "1P"
                .NM102 = "2"
                .NM103 = "BONE AND JOINT CLINIC"
                .NM108 = "SV"
                .NM109 = "2000035"
            End With
        End With

        Ts.Loop2000C.Add(Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2000C())

        With Ts.Loop2000C(0)
            .HL = Factory.Transaction270_B1.Loop2000CFactory.CreateHL()

            With .HL
                .HL01 = "3"
                .HL02 = "2"
                .HL03 = "22"
                .HL04 = "0"
            End With

            .TRN.Add(Factory.Transaction270_B1.Loop2000CFactory.CreateTRN())

            With .TRN(0)
                .TRN01 = "1"
                .TRN02 = "93175-012547"
                .TRN03 = "9877281234"
            End With

            .Loop2100C = Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2100C()

            With .Loop2100C
                .NM1 = Factory.Transaction270_B1.Loop2100CFactory.CreateNM1()
                .DMG = Factory.Transaction270_B1.Loop2100CFactory.CreateDMG()
                .DTP.Add(Factory.Transaction270_B1.Loop2100CFactory.CreateDTP())

                With .NM1
                    .NM101 = "IL"
                    .NM102 = "1"
                    .NM103 = "SMITH"
                    .NM104 = "ROBERT"
                    .NM108 = "MI"
                    .NM109 = "11122333301"
                End With

                With .DMG
                    .DMG01 = "D8"
                    .DMG02 = "19430519"
                End With

                With .DTP(0)
                    .DTP01 = "291"
                    .DTP02 = "D8"
                    .DTP03 = "20060501"
                End With

                .Loop2110C.Add(Factory.Transaction270_B1.TransactionSetFactory.CreateLoop2110C())

                With .Loop2110C(0)
                    .EQ = Factory.Transaction270_B1.Loop2110CFactory.CreateEQ()
                    .EQ.EQ01.Add("30")
                    .EQ.EQ01.Add("31")
                End With
            End With
        End With

        Dim GeneratedDocument = Await WriteGeneratedDocument(Doc)

        'Compare this to what we are expecting
        Assert.AreEqual(Of String)("ISA*00*          *00*          *ZZ*12345678       *ZZ*123456789      *201231*0050*^*00501*000000001*1*P*:~GS*HS*SUBMITTERID*CMS*20190308*0734*222222222*X* ~ST*270*1234*005010X279A1~BHT*0022*13*10001234*20060501*131900~HL*1**20*1~NM1*PR*2*ABC COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*0~TRN*1*93175-012547*9877281234~NM1*IL*1*SMITH*ROBERT****MI*11122333301~DMG*D8*19430519~DTP*291*D8*20060501~EQ*30^31~SE*13*1234~GE*1*222222222~IEA*1*000000001~", GeneratedDocument)

    End Function

    Private Async Function WriteGeneratedDocument(doc As Document) As Task(Of String)
        Dim GeneratedDocument As String

        Using stream As New IO.MemoryStream()

            Await doc.ToStreamAsync(stream)

            stream.Seek(0, IO.SeekOrigin.Begin)

            Using reader As New IO.StreamReader(stream)

                GeneratedDocument = reader.ReadToEnd()
            End Using
        End Using

        Return GeneratedDocument
    End Function
    Private Function BuildDocument(ackRequested As Boolean,
                                   authInfoQualifier As String,
                                   authInfo As String,
                                   componentSeparator As Char,
                                   elementSeparator As Char,
                                   repeatSeparator As Char,
                                   segmentTerminator As Char,
                                   interchangeControlNumber As Integer,
                                   interchangeDateTime As Date,
                                   interchangeReceiverQualifier As String,
                                   interchangeReceiverID As String,
                                   interchangeSenderQualifier As String,
                                   interchangeSenderID As String,
                                   isTestDocument As Boolean,
                                   securityInfoQualifier As String,
                                   securityInfo As String,
                                   groupControlNumber As Integer,
                                   applicationSenderCode As String,
                                   applicationReceiverCode As String,
                                   groupDateTime As Date) As Document

        Dim Doc As New Document
        Dim Isa As New Envelope
        Dim Fg As New FunctionalGroup

        Doc.AddEnvelope(Isa)
        Isa.AddFunctionalGroup(Fg)

        With Isa
            .AcknowledgementRequested = ackRequested
            .AuthorizationInformationQualifier = authInfoQualifier
            .AuthorizationInfo = authInfo
            .ComponentElementSeparator = componentSeparator
            .ElementSeparator = elementSeparator
            .RepetitionSeparator = repeatSeparator
            .SegmentTerminator = segmentTerminator
            .InterchangeControlNumber = interchangeControlNumber
            .InterchangeDateTime = interchangeDateTime
            .InterchangeReceiverIdQualifier = interchangeReceiverQualifier
            .InterchangeReceiverID = interchangeReceiverID
            .InterchangeSenderIdQualifier = interchangeSenderQualifier
            .InterchangeSenderID = interchangeSenderID
            .IsTest = isTestDocument
            .SecurityInformationQualifier = securityInfoQualifier
            .SecurityInfo = securityInfo
        End With

        With Fg
            .ControlNumber = groupControlNumber
            .ApplicationSenderCode = applicationSenderCode
            .ApplicationReceiverCode = applicationReceiverCode
            .DateTime = groupDateTime
        End With

        Return Doc
    End Function
End Class
