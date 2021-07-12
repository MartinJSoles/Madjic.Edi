# Madjic.Edi
Strongly typed ANSI X12 5010 version HIPAA objects for parsing and generating healthcare related documents.

This project used the official ANSI X12 databases to generate the original source code. I'm opening this project up for others to use and modify as they see fit.

When reading, you would use the static methods on the `Madjic.Edi.Dom.Document` class to get started. The stream passed in will be parsed into the EDI structures of Envelopes,
Functional Groups, and Transaction Sets.

### Examples of reading an EDI document from a given file path

#### Visual Basic.NET Example
    Imports Madjic.Edi.Dom
    
    Async Function ReadImplementation271(ByVal path As String) As Task(Of Document)
        Dim Doc As Document

        Using stream As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using
    
       'Examine the first transaction set
        Dim RawTS = Doc.Envelopes(0).FunctionalGroups(0).Transactions(0)
    
        'Treat the generic transaction set as the v5010 Implementation Guide for a Benefit Eligibility Response Transaction
        Dim Imp = TryCast(RawTS, Transactions.Transaction271.Transaction271_B1.TransactionSet)
    
        Return Doc
    End Function

#### C# Example
    using Madjic.Edi.Dom;
    
    public async Task<Document> ReadImplementation271(string path)
    {
      Document doc;
    
      using stream = new IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
      {
        doc = await Document.FromStreamAsync(stream);
      }
      
      // Examine the first transaction set
      var RawTS = Doc.Envelopes[0].FunctionalGroups[0].Transactions[0];
    
      // Treat the generic transaction set as the v5010 Implementation Guide for a Benefit Eligibility Response Transaction
      var Imp = RawTS as Transactions.Transaction271.Transaction271_B1.TransactionSet;
     
      return (doc);
    }

When creating, you would use the static methods on the desired transaction sets in the `Madjic.Edi.Dom.Factory.*` namespaces. You will notice that these methods all return
objects that implement the specific interface.

### Example of creating a file

#### Visual Basic.NET Example
    Async Function CreateFile(ByVal path As String) As Task
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

        Using stream As New IO.FileStream(path, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.None)
            Await Doc.ToStreamAsync(stream)
            End Using
        End Using
    End Function

#### C# Example (TODO)
    async Task CreateFile(string path)
    {
    }

Internally, there are single classes used for all implementations of each segment. For example, there is an internal class named `REF_Obj`. This class implements a large number
of interfaces, one for each distinct use. The same is true for transaction sets and individual loops (in the 837 professional there are a number of 2310 loops, they are all backed
by a single class definition).

## Known Issues
1. There is no code in place to properly handle the repeating elements (such as the EB03 element).
2. Creating transaction sets is affected by the lack of I.G. work that should happen (there should be an extra initialization step that happens to set the specialized loop and segment containers).

## History

#### V1.0.6
* This release includes a test case for writing a file from scratch.
* A bug has been fixed for adding segments that can repeat as well as child loops that can repeat

#### V1.0.4, V1.0.5
* This release includes the generated XML Documentation file for all supported platforms.
* Removed debugging statements (the file readers were dumping incoming characters to the debugger output when looking for the envelope information).

#### V1.0.3
* This release supports interpreting the parsed transaction sets as their appropriate Implementation Guides.
* Rudimentary validation is performed at the functional group level. If a transaction set does not agree
with the group code in the GS segment, it will be ignored.
* This version does not currently enforce segment and loop level validation.
* Tests have been put in place to verify the transactions can be read and interpreted correctly.

#### V1.0.1, V1.0.2
Do not use. These versions do not perform correctly.

