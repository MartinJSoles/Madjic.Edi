Public Class Document
    Implements IValidate

    Private ReadOnly mEnvelopes As New List(Of Envelope)
    Private mEnumerableOnly As Boolean

    ''' <summary>
    ''' Gets a list of <see cref="Envelope">Envelope</see> objects contained within this document.
    ''' </summary>
    Public ReadOnly Property Envelopes As IEnumerable(Of Envelope)
        Get
            If Not mEnumerableOnly Then
                Return mEnvelopes
            Else
                Throw New NotImplementedException("Forward Only Enumeration has not been implemented with the Async/Await pattern yet.")
            End If
        End Get
    End Property

    Public Sub AddEnvelope(item As Envelope)
        If Not mEnumerableOnly Then
            mEnvelopes.Add(item)
        Else
            Throw New NotSupportedException("You cannot add an envelope object when the document was created with useForwardOnlyEnumeration set to true.")
        End If
    End Sub

    ''' <summary>
    ''' Reads a stream and returns a <see cref="Document">Document</see> object.
    ''' </summary>
    ''' <param name="stream">An abstract stream to read the contents of the EDI file.</param>
    ''' <returns>A <see cref="Document">Document</see> object populated from the EDI file.</returns>
    Public Shared Async Function FromStreamAsync(stream As IO.Stream) As Task(Of Document)
        Dim rvalue As New Document() With {.mEnumerableOnly = False}

        Dim Rdr As New EdiReader.EdiFileReader()

        Rdr.Open(stream)

        Dim E As EdiReader.EdiEnvelopeReader

        Do
            E = Await Rdr.ReadEnvelopeAsync().ConfigureAwait(False)

            If E IsNot Nothing Then
                Await ReadEnvelopeAsync(rvalue, E).ConfigureAwait(False)
            End If

        Loop Until Rdr.IsAtEndOfFile OrElse E Is Nothing

        Rdr.Close()

        Return rvalue
    End Function

    ''' <summary>
    ''' Reads a stream and returns a <see cref="Document">Document</see> object.
    ''' </summary>
    ''' <param name="stream">An abstract stream to read the contents of the EDI file.</param>
    ''' <param name="useForwardOnlyEnumeration">If true, the <see cref="Envelopes">envelopes</see>, 
    ''' <see cref="Envelope.FunctionalGroups">functional groups</see>, and
    ''' <see cref="FunctionalGroup.Transactions">transactions</see>
    ''' properties will only read forward when using the For...Next, or foreach, methods. Note: the <paramref name="stream">stream</paramref> object must remain in scope and not disposed until the file has been completely processed.</param>
    ''' <returns>A <see cref="Document">Document</see> object populated from the EDI file.</returns>
    ''' <remarks>Setting <paramref name="useForwardOnlyEnumeration">useForwardOnlyEnumeration</paramref> to true will force the document
    ''' and child enumerations to not track the child objects. This enables the document to use a smaller memory footprint as it
    ''' iterates through the EDI file. Note that the underlying stream must remain open until the document has been fully processed.</remarks>
    Public Shared Function FromStream(stream As IO.Stream, useForwardOnlyEnumeration As Boolean) As Task(Of Document)
        If useForwardOnlyEnumeration Then
            Throw New NotImplementedException("Forward Only Enumeration has not been implemented with the Async/Await pattern yet.")
        End If

        Return FromStreamAsync(stream)
    End Function

#Region " Support routines for FromStream method. "

    ''' <summary>
    ''' Reads an envelope and adds it to the given <see cref="Document">Document</see>.
    ''' </summary>
    ''' <param name="doc">The <see cref="Document">Document</see> to add the envelope to.</param>
    ''' <param name="rdr">An <see cref="EdiReader.EdiEnvelopeReader">EdiEnvelopeReader</see> to read from.</param>
    Private Shared Async Function ReadEnvelopeAsync(doc As Document, rdr As EdiReader.EdiEnvelopeReader) As Task
        Dim Env As New Envelope()

        With Env
            'Fill the envelope from the reader.
            .AuthorizationInformationQualifier = rdr.Element(0)
            .AuthorizationInfo = rdr.Element(1)
            .SecurityInformationQualifier = rdr.Element(2)
            .SecurityInfo = rdr.Element(3)
            .InterchangeSenderIdQualifier = rdr.Element(4)
            .InterchangeSenderID = rdr.Element(5)
            .InterchangeReceiverIdQualifier = rdr.Element(6)
            .InterchangeReceiverID = rdr.Element(7)
            .InterchangeDateTime = GetDateTime(rdr.Element(8), rdr.Element(9))
            .RepetitionSeparator = If(rdr.Element(9).Length > 0, rdr.Element(9).Chars(0), "^"c)
            .InterchangeControlNumber = rdr.Element(12)
            .AcknowledgementRequested = GetBoolean(rdr.Element(13), "1"c)
            .IsTest = GetBoolean(rdr.Element(14), "T"c)

            .ElementSeparator = rdr.ElementSeparator
            .RepetitionSeparator = rdr.RepeatingElementSeparator
            .ComponentElementSeparator = rdr.CompositeSeparator
            .SegmentTerminator = rdr.SegmentTerminator

            .ISB = rdr.EnvelopeIsbSegment
            .ISE = rdr.EnvelopeIseSegment

            If rdr.EnvelopTA1Segments.Count > 0 Then
                .TA1.AddRange(rdr.EnvelopTA1Segments)
            End If
        End With

        doc.mEnvelopes.Add(Env)

        Dim G As EdiReader.EdiGroupReader

        Do
            G = Await rdr.ReadGroup()

            If G IsNot Nothing Then
                Await ReadGroupAsync(Env, G).ConfigureAwait(False)
            End If

        Loop Until rdr.IsAtEndOfEnvelope OrElse G Is Nothing
    End Function

    ''' <summary>
    ''' Reads a functional group and adds it to the given <see cref="Envelope">Envelope</see>.
    ''' </summary>
    ''' <param name="env">The <see cref="Envelope">Envelope</see> to add the functional group to.</param>
    ''' <param name="rdr">An <see cref="EdiReader.EdiGroupReader">EdiGroupReader</see> to read from.</param>
    ''' <remarks>This method will also add any child transaction sets.</remarks>
    Private Shared Async Function ReadGroupAsync(env As Envelope, rdr As EdiReader.EdiGroupReader) As Task
        Dim Grp As New FunctionalGroup()

        If String.Compare(rdr.Element(6), "X", StringComparison.OrdinalIgnoreCase) <> 0 Then
            Do Until rdr.IsAtEndOfGroup
                Await rdr.ReadTransactionSetAsync().ConfigureAwait(False)
            Loop

            Exit Function
        End If

        'Fill the group from the reader.
        With Grp
            .FunctionalIdCode = rdr.Element(0)
            .ApplicationSenderCode = rdr.Element(1)
            .ApplicationReceiverCode = rdr.Element(2)
            .DateTime = GetDateTime(rdr.Element(3), rdr.Element(4))
            .ControlNumber = GetInteger(rdr.Element(5))
            .VersionCode = rdr.Element(7)
        End With

        env.AddFunctionalGroup(Grp)

        Dim T As EdiReader.EdiTransactionSetReader

        Do
            T = Await rdr.ReadTransactionSetAsync().ConfigureAwait(False)

            If T IsNot Nothing Then
                Dim tran = Await ReadTransaction(Grp, T).ConfigureAwait(False)

                If tran IsNot Nothing Then
                    Grp.AddTransactionSet(tran)
                End If
            End If

        Loop Until rdr.IsAtEndOfGroup OrElse T Is Nothing
    End Function

    ''' <summary>
    ''' Reads a transaction set and adds it to the given functional group.
    ''' </summary>
    ''' <param name="grp">The <see cref="FunctionalGroup">FunctionalGroup</see> to add the transaction set to.</param>
    ''' <param name="rdr">An <see cref="EdiReader.EdiTransactionSetReader">EdiTransactionSetReader</see> to read from.</param>
    ''' <returns>A <see cref="TransactionSet">TransactionSet</see> object.</returns>
    ''' <remarks>This method examines the values in the functional group and ST segment to determine which actual transaction set to read.</remarks>
    Private Shared Async Function ReadTransaction(grp As FunctionalGroup, rdr As EdiReader.EdiTransactionSetReader) As Task(Of TransactionSet)
        Dim rval = ReaderFactory.CreateTransaction(grp, rdr)

        If rval IsNot Nothing Then
            Dim args As New ReaderArgs(rdr) With {
                .Implementation = ReaderFactory.GetImplementationKey(rval.VersionCode, rval.TransactionSetIdCode)
            }
            Await rval.ReadAsync(args).ConfigureAwait(False)
        End If

        Return rval
    End Function

    Friend Shared Function GetBoolean(ediChar As String, trueChar As Char)
        Return (ediChar IsNot Nothing AndAlso ediChar.Chars(0) = trueChar)
    End Function

    Friend Shared Function GetInteger(ediNumber As String) As Integer
        Dim i As Integer

        If ediNumber IsNot Nothing AndAlso Integer.TryParse(ediNumber, i) Then
            Return i
        Else
            Return 0
        End If
    End Function

    Friend Shared Function GetDateTime(ediDate As String, ediTime As String) As DateTime
        Dim dt As Integer
        Dim tm As Integer
        Dim yr As Integer
        Dim mo As Integer
        Dim da As Integer
        Dim hr As Integer
        Dim mi As Integer
        Dim se As Integer

        Dim rval As DateTime = Date.Now

        If ediDate IsNot Nothing Then
            If Integer.TryParse(ediDate, dt) Then

                If ediTime IsNot Nothing Then
                    If Integer.TryParse(ediTime, tm) Then
                        Select Case ediTime.Length
                            Case 4
                                hr = tm \ 100
                                mi = tm Mod 100
                            Case 6
                                hr = tm \ 10000
                                mi = (tm \ 100) Mod 100
                                se = tm Mod 100
                            Case 7
                                hr = tm \ 100000
                                mi = (tm \ 1000) Mod 100
                                se = (tm \ 10) Mod 100
                            Case 8
                                hr = tm \ 1000000
                                mi = (tm \ 10000) Mod 100
                                se = (tm \ 100) Mod 100
                        End Select

                        If hr > 23 OrElse mi > 59 OrElse se > 59 Then
                            'Invalid time
                            hr = 0
                            mi = 0
                            se = 0
                        End If
                    End If
                End If

                da = dt Mod 100
                mo = (dt \ 100) Mod 100
                yr = dt \ 10000

                If ediDate.Length = 6 Then
                    'Get the correct century
                    yr = Globalization.CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(yr)
                End If

                If mo > 0 AndAlso mo < 13 AndAlso Date.DaysInMonth(yr, mo) >= da AndAlso da > 0 Then
                    rval = New Date(yr, mo, da, hr, mi, se)
                End If

            End If
        End If

        Return rval
    End Function

#End Region

    ''' <summary>
    ''' Writes the contents of the document to the given stream using UTF-8 text encoding.
    ''' </summary>
    ''' <param name="stream">The stream to write the EDI document to.</param>
    ''' <remarks>This will write each <see cref="Envelope">Envelope</see> object, and its child Functional Groups and Transactions, to the given <see cref="IO.stream">IO.Stream</see>.</remarks>
    Public Function ToStreamAsync(stream As IO.Stream) As Task
        Return ToStreamAsync(stream, New Text.UTF8Encoding(False, True), False, 1024, True)
    End Function

    ''' <summary>
    ''' Writes the content of the document to the given stream using the given text encoding.
    ''' </summary>
    ''' <param name="stream">The stream to write the EDI document to.</param>
    ''' <param name="textEncoding">The encoding to use when writing the EDI document.</param>
    ''' <remarks>This will write each <see cref="Envelope">Envelope</see> object, and its child Functional Groups and Transactions, to the given <see cref="IO.stream">IO.Stream</see>.</remarks>
    Public Function ToStreamAsync(stream As IO.Stream, textEncoding As Text.Encoding) As Task
        Return ToStreamAsync(stream, textEncoding, False, 1024, True)
    End Function

    ''' <summary>
    ''' Writes the content of the document to the given stream using UTF-8 text encoding.
    ''' </summary>
    ''' <param name="stream">The stream to write the EDI document to.</param>
    ''' <param name="insertNewLines">If true, each segment will have a NewLine character sequence added to the segment terminator for each envelope. If false, the segment terminator is written as is.</param>
    ''' <remarks>This will write each <see cref="Envelope">Envelope</see> object, and its child Functional Groups and Transactions, to the given <see cref="IO.stream">IO.Stream</see>.</remarks>
    Public Function ToStreamAsync(stream As IO.Stream, insertNewLines As Boolean) As Task
        Return ToStreamAsync(stream, New Text.UTF8Encoding(False, True), insertNewLines, 1024, True)
    End Function

    ''' <summary>
    ''' Writes the content of the document to the given stream using the given text encoding.
    ''' </summary>
    ''' <param name="stream">The stream to write the EDI document to.</param>
    ''' <param name="textEncoding">The encoding to use when writing the EDI document.</param>
    ''' <param name="insertNewLines">If true, each segment will have a NewLine character sequence added to the segment terminator for each envelope. If false, the segment terminator is written as is.</param>
    ''' <param name="bufferSize">The size of the buffer to use for the stream writer, in bytes.</param>
    ''' <param name="leaveOpen">If true, the underlying stream is left open after the document has been written.</param>
    ''' <remarks>This will write each <see cref="Envelope">Envelope</see> object, and its child Functional Groups and Transactions, to the given <see cref="IO.stream">IO.Stream</see>.</remarks>
    Public Function ToStreamAsync(stream As IO.Stream, textEncoding As Text.Encoding, insertNewLines As Boolean, bufferSize As Integer, leaveOpen As Boolean) As Task
        Using writer As New IO.StreamWriter(stream, textEncoding, bufferSize, leaveOpen)
            Return ToStreamAsync(writer, insertNewLines)
        End Using
    End Function

    Public Async Function ToStreamAsync(writer As IO.TextWriter, insertNewLines As Boolean) As Task
        If Not insertNewLines Then
            For Each item In mEnvelopes
                Await item.WriteAsync(writer, False).ConfigureAwait(False)
            Next
        Else
            Dim oldSegTerm As String
            For Each item In mEnvelopes
                oldSegTerm = item.SegmentTerminator

                Dim HasCr = If(oldSegTerm.Contains(vbCr), 1, 0)
                Dim HasLf = If(oldSegTerm.Contains(vbLf), 2, 0)

                Select Case HasCr + HasLf
                    Case 0
                        item.SegmentTerminator = oldSegTerm & vbCrLf
                    Case 1
                        item.SegmentTerminator = oldSegTerm.Replace(vbCr, vbCrLf)
                    Case 2
                        item.SegmentTerminator = oldSegTerm.Replace(vbLf, vbCrLf)
                End Select

                Await item.WriteAsync(writer, False)
                item.SegmentTerminator = oldSegTerm
            Next
        End If

        Await writer.FlushAsync().ConfigureAwait(False)
    End Function

    Public Sub Validate(results As ValidationResults) Implements IValidate.Validate
        If mEnvelopes.Count = 0 Then
            Dim w As New ValidationWarning With {.Source = Me}

            w.Warnings.Add("The document currently has no envelopes.")

            results.Warnings.Add(w)
        End If
    End Sub

    Public Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each Isa In mEnvelopes
            Isa.Validate(results)
            Isa.ValidateChildren(results)
        Next
    End Sub

    ''' <summary>
    ''' Examines the current document structure and generates an Acknowledgement file.
    ''' </summary>
    ''' <returns>An acknowledgement document if any ISA segments have requested it, Nothing otherwise.</returns>
    ''' <remarks>An envelope is created for each ISA segment that requests one.</remarks>
    Public Function GenerateAcknowledgmentDocument() As Document
        Dim rvalue As New Document() With {.mEnumerableOnly = False}
        Dim Empty As Boolean = True

        For Each item In mEnvelopes
            If item.AcknowledgementRequested Then
                'Empty = False
                Throw New NotImplementedException("The method to generate an acknowledgement document has not been implemented yet.")
            End If
        Next

        If Empty Then
            rvalue = Nothing
        End If

        Return rvalue
    End Function
End Class
