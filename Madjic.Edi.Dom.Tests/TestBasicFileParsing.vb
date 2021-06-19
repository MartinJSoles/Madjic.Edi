Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class TestBasicFileParsing

    <TestMethod()> Async Function CanOpenTestFile() As Task
        Dim Doc As Madjic.Edi.Dom.Document

        Using stream As New IO.FileStream(".\samples\test271.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Madjic.Edi.Dom.Document.FromStreamAsync(stream)
        End Using

        Assert.IsNotNull(Doc)

    End Function

    <TestMethod> Async Function DoesTestFileRoundTrip() As Task
        Dim Source As String
        Dim Output As String
        Dim Doc As Document

        Using stream As New IO.FileStream(".\samples\test271.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Source = ReadStreamToString(stream)
        End Using

        Using stream As New IO.FileStream(".\samples\test271.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Doc = Await Document.FromStreamAsync(stream)
        End Using

        Using stream As New IO.MemoryStream()
            Dim writer As New IO.StreamWriter(stream, New Text.UTF8Encoding(False, True))
            Await Doc.ToStreamAsync(writer, False)

            stream.Seek(0, IO.SeekOrigin.Begin)
            Output = ReadStreamToString(stream)
        End Using

        'Ensure strings are equal
        Assert.AreEqual(Source, Output, False)
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


