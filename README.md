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

### TODO: Examples of creating a file (when passing tests are created)

#### Visual Basic.NET Example
    Async Function CreateFile(ByVal path As String) As Task
    End Function

#### C# Example
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

#### V1.0.4
* This release includes the generated XML Documentation file for all supported platforms.
* Removed debugging statements (the file readers were dumping incoming characters to the debugger output when looking for the envelope information).

#### V1.0.3
* This release supports interpreting the parsed transaction sets as their appropriate Implementation Guides.
* Rudimentary validation is performed at the functional group level. If a transaction set does not agree
with the group code in the GS segment, it will be ignored.
* This version does not currently enforce segment and loop level validation.
* Tests have been put in place to verify the transactions can be read and interpreted correctly.

#### V1.01, V1.02
Do not use. These versions do not perform correctly.

