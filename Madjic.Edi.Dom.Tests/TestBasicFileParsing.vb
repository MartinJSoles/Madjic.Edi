Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class TestBasicFileParsing

    Private Shared ReadOnly AllFiles() As String = {
        ".\samples\TestMultipleFunctionalGroups.txt",
        ".\samples\TestMultipleEnvelopes.txt",
        ".\samples\Test270.txt",
        ".\samples\Test271.txt",
        ".\samples\Test277.txt",
        ".\samples\Test278.txt",
        ".\samples\Test820.txt",
        ".\samples\Test834.txt",
        ".\samples\Test835.txt",
        ".\samples\Test837P.txt",
        ".\samples\Test999.txt"}

    <TestMethod()> Async Function TestBadTransactionSet() As Task
        Dim Doc As Document

        Using stream As New IO.FileStream(".\Samples\Test271.BadTS.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Assert.AreEqual(1, Doc.Envelopes.Count)
        Assert.AreEqual(1, Doc.Envelopes(0).FunctionalGroups.Count)
        Assert.AreEqual(3, Doc.Envelopes(0).FunctionalGroups(0).Transactions.Count)

        For Each ts In Doc.Envelopes(0).FunctionalGroups(0).Transactions
            Assert.IsInstanceOfType(ts, GetType(Transactions.Transaction271.Transaction271_B1.TransactionSet))
        Next

        Dim ShouldBeBad() = {True, False, False}

        For i = 0 To 2
            Dim ts = Doc.Envelopes(0).FunctionalGroups(0).Transactions(i)

            Assert.AreEqual(ShouldBeBad(i), ts.HasReaderErrors, $"Transaction set #{i + 1}.")
        Next
    End Function

    <TestMethod()> Async Function TestAllFileImplementations() As Task
        Dim Doc As Document
        Dim ExpectedTypes() As Type = {
            GetType(Transactions.Transaction270.Transaction270_B1.TransactionSet),
            GetType(Transactions.Transaction271.Transaction271_B1.TransactionSet),
            GetType(Transactions.Transaction277.Transaction277_A1.TransactionSet),
            GetType(Transactions.Transaction278.Transaction278_A3.TransactionSet),
            GetType(Transactions.Transaction820.Transaction820_A1.TransactionSet),
            GetType(Transactions.Transaction834.Transaction834_A1.TransactionSet),
            GetType(Transactions.Transaction835.Transaction835_W1.TransactionSet),
            GetType(Transactions.Transaction837.Transaction837_Q1.TransactionSet),
            GetType(Transactions.Transaction999.Transaction999.TransactionSet)}

        For FileId = 2 To 10
            Debug.Write("<-- File --> ")
            Debug.WriteLine(AllFiles(FileId))

            Using stream As New IO.FileStream(AllFiles(FileId), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                Doc = Await Document.FromStreamAsync(stream)
            End Using

            Assert.IsTrue(Doc.Envelopes.Count > 0, $"Parsing file ""{AllFiles(FileId)}"" did not produce any envelope.")
            Assert.IsTrue(Doc.Envelopes(0).FunctionalGroups.Count > 0, $"Parsing file ""{AllFiles(FileId)}"" did not produce any functional group.")
            Assert.IsTrue(Doc.Envelopes(0).FunctionalGroups(0).Transactions.Count > 0, $"Parsing file ""{AllFiles(FileId)}"" did not produce any transaction set.")
            Assert.IsInstanceOfType(Doc.Envelopes(0).FunctionalGroups(0).Transactions(0), ExpectedTypes(FileId - 2), $"Parsing file ""{AllFiles(FileId)}"" did not produce correct transaction type.")
        Next
    End Function
    <TestMethod()> Async Function CanOpenTestFile() As Task
        Dim Doc As Madjic.Edi.Dom.Document

        Using stream As New IO.FileStream(AllFiles(3), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Madjic.Edi.Dom.Document.FromStreamAsync(stream)
        End Using

        Assert.IsNotNull(Doc)

    End Function

    <TestMethod()> Async Function TestMultipleFunctionalGroups() As Task
        Dim Doc As Document

        Using stream As New IO.FileStream(AllFiles(0), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Assert.AreEqual(2, Doc.Envelopes.First.FunctionalGroups.Count)
    End Function

    <TestMethod()> Async Function TestMultipleEnvelopes() As Task
        Dim Doc As Document

        Using stream As New IO.FileStream(AllFiles(1), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Assert.AreEqual(2, Doc.Envelopes.Count)
        Assert.AreEqual(1, Doc.Envelopes(1).FunctionalGroups.Count)
        Assert.AreEqual(2, Doc.Envelopes(1).FunctionalGroups(0).Transactions.Count)
    End Function

    <TestMethod> Async Function DoTestFilesRoundTrip() As Task
        Dim Source As String
        Dim Output As String
        Dim Doc As Document

        For FileID = 2 To 10
            Source = Nothing
            Doc = Nothing
            Output = Nothing

            Using stream As New IO.FileStream(AllFiles(FileID), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                Source = ReadStreamToString(stream)
            End Using

            Try
                Using stream As New IO.FileStream(AllFiles(FileID), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                    Doc = Await Document.FromStreamAsync(stream)
                End Using
            Catch ex As Exception
                Assert.Fail($"Reading File Path: ""{AllFiles(FileID)}""
{ex.ToString}")
            End Try

            Try
                Using stream As New IO.MemoryStream()
                    Dim writer As New IO.StreamWriter(stream, New Text.UTF8Encoding(False, True))
                    Await Doc.ToStreamAsync(writer, False)
                    Await writer.FlushAsync()
                    stream.Seek(0, IO.SeekOrigin.Begin)
                    Output = ReadStreamToString(stream)
                End Using
            Catch ex As Exception
                Assert.Fail($"Writing File Path: ""{AllFiles(FileID)}""
{ex.ToString}")
            End Try

            'Ensure strings are equal
            Assert.AreEqual(Source, Output, $"File Path: ""{AllFiles(FileID)}""")
        Next
    End Function

    <TestMethod> Async Function ReadImplementation271() As Task
        Dim Doc As Document

        Using stream As New IO.FileStream(AllFiles(3), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Dim RawTS = Doc.Envelopes(0).FunctionalGroups(0).Transactions(0)
        Dim Imp = TryCast(RawTS, Transactions.Transaction271.Transaction271_B1.TransactionSet)

        Assert.IsNotNull(Imp)

        Assert.IsNotNull(Imp.Loop2000A)
        Assert.IsTrue(Imp.Loop2000A.Count > 0)

        Assert.IsNotNull(Imp.Loop2000B)
        Assert.IsTrue(Imp.Loop2000B.Count > 0)
    End Function

    <TestMethod> Async Function TestBoundedLoops() As Task
        Dim Doc As Document

        Using stream As New IO.FileStream(AllFiles(3), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Dim RawTS = Doc.Envelopes(0).FunctionalGroups(0).Transactions(0)
        Dim Imp = TryCast(RawTS, Transactions.Transaction271.Transaction271_B1.TransactionSet)

        Debug.WriteLine("")

        Dim Count2120 As Integer
        'Ensure that multiple 2120 loops are showing up
        For Each lp In Imp.Loop2000C
            For Each lp2 In lp.Loop2100C.Loop2110C
                For Each lp3 In lp2.Loop2120C
                    Debug.WriteLine("LOOP 2120C FOUND")

                    If lp3.NM1 IsNot Nothing Then
                        Debug.WriteLine("NM103 = " & lp3.NM1.NM103)
                    Else
                        Debug.WriteLine("(no NM1)")
                    End If

                    If lp3.PER IsNot Nothing AndAlso lp3.PER.Count > 0 Then
                        Debug.WriteLine("PER03 = " * lp3.PER.First().PER03)
                    Else
                        Debug.WriteLine("(no PER)")
                    End If

                    Count2120 += 1
                Next
            Next
        Next

        For Each lp In Imp.Loop2000D
            For Each lp2 In lp.Loop2100D.Loop2110D
                For Each lp3 In lp2.Loop2120D
                    Debug.WriteLine("LOOP 2120D FOUND")

                    If lp3.NM1 IsNot Nothing Then
                        Debug.WriteLine("NM103 = " & lp3.NM1.NM103)
                    Else
                        Debug.WriteLine("(no NM1)")
                    End If

                    If lp3.PER IsNot Nothing AndAlso lp3.PER.Count > 0 Then
                        Debug.WriteLine("PER03 = " * lp3.PER.First().PER03)
                    Else
                        Debug.WriteLine("(no PER)")
                    End If

                    Count2120 += 1
                Next
            Next
        Next

        Assert.AreEqual(3, Count2120)
    End Function

    ''' <summary>
    ''' Strips non essential characters from a stream and returns the results as a simple string.
    ''' </summary>
    ''' <param name="stream">The stream to read characters from.</param>
    ''' <returns>A string where all control characters have been removed from the underlying stream.</returns>
    Private Function ReadStreamToString(stream As IO.Stream) As String
        Using reader As New IO.StreamReader(stream)
            Dim builder As New Text.StringBuilder()
            Dim ch As Integer
            Dim letter As Char

            Do
                ch = reader.Read()

                If ch >= 0 Then
                    letter = ChrW(ch)
                    If Not Char.IsControl(letter) Then
                        builder.Append(letter)
                    End If
                End If
            Loop Until ch < 0

            Return builder.ToString
        End Using
    End Function
End Class


