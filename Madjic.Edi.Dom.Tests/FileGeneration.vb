Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class FileGeneration

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
                    .EQ.EQ01 = "30"
                End With
            End With
        End With

        Dim GeneratedDocument As String

        Using stream As New IO.MemoryStream()

            Await Doc.ToStreamAsync(stream)

            stream.Seek(0, IO.SeekOrigin.Begin)

            Using reader As New IO.StreamReader(stream)

                GeneratedDocument = reader.ReadToEnd()
            End Using
        End Using

        'Compare this to what we are expecting
        Assert.AreEqual(Of String)("ISA*00*          *00*          *ZZ*12345678       *ZZ*123456789      *201231*0050*^*00501*000000001*1*P*:~GS*HS*SUBMITTERID*CMS*20190308*0734*222222222*X* ~ST*270*1234*005010X279A1~BHT*0022*13*10001234*20060501*131900~HL*1**20*1~NM1*PR*2*ABC COMPANY*****PI*842610001~HL*2*1*21*1~NM1*1P*2*BONE AND JOINT CLINIC*****SV*2000035~HL*3*2*22*0~TRN*1*93175-012547*9877281234~NM1*IL*1*SMITH*ROBERT****MI*11122333301~DMG*D8*19430519~DTP*291*D8*20060501~EQ*30~SE*13*1234~GE*1*222222222~IEA*1*000000001~", GeneratedDocument)

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
