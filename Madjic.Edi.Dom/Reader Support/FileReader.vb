Namespace EdiReader

    Friend Class FileReader

        Private ReadOnly mStream As IO.Stream
        Private ReadOnly mStreamReader As IO.StreamReader
        Private mTerm As Char
        Private ReadOnly mOrg As FileReader

        Private ReadOnly mChars(1023) As Char
        Private mcIndex As Integer 'where in the chars buffer are we
        Private mcReadSize As Integer 'how many valid chars are in the buffer

        Private atEOF As Boolean

        'Private ReadOnly mByteCount As Long
        Private mByteRead As Long

        'Public ReadOnly Property FileByteSize() As Long
        '    Get
        '        If mOrg IsNot Nothing Then
        '            Return mOrg.FileByteSize
        '        Else
        '            Return mByteCount
        '        End If
        '    End Get
        'End Property

        Public ReadOnly Property FileBytesRead() As Long
            Get
                If mOrg IsNot Nothing Then
                    Return mOrg.FileBytesRead
                Else
                    Return mByteRead
                End If
            End Get
        End Property

        Friend ReadOnly Property EOF() As Boolean
            Get
                Return atEOF
            End Get
        End Property

        Public Sub Close()
            If mStreamReader IsNot Nothing Then
                mStreamReader.Close()
            End If

            If mStream IsNot Nothing Then
                mStream.Close()
            End If
        End Sub

        Public Property LineTerminator() As Char
            Get
                Return mTerm
            End Get
            Set(ByVal value As Char)
                mTerm = value
            End Set
        End Property

        Public Sub New(ByVal stream As IO.Stream)

            mByteRead = 0
            mStream = stream
            mStreamReader = New IO.StreamReader(stream, Text.Encoding.UTF8, True)
            mTerm = ChrW(13) 'carriage return
            mOrg = Nothing
        End Sub

        'Read a "line" of text, throwing away the line terminator
        Public Function ReadLineAsync() As Task(Of String)
            Return ReadLineInternalAsync(mTerm)
        End Function

        'Read at most count characters into a buffer
        Public Function ReadAsync(ByVal buffer() As Char, ByVal index As Integer, ByVal count As Integer) As Task(Of Integer)
            Return ReadInternalAsync(mTerm, buffer, index, count)
        End Function

        Public Async Function ReadAsync() As Task(Of Integer)
            Dim ch(0) As Char
            Dim len As Integer

            len = Await ReadInternalAsync(mTerm, ch, 0, 1).ConfigureAwait(False)

            If len = 1 Then
                Return AscW(ch(0))
            Else
                Return -1
            End If
        End Function

        Private Async Function ReadInternalAsync(ByVal term As Char, ByVal buffer() As Char, ByVal index As Integer, ByVal count As Integer) As Task(Of Integer)
            If mOrg Is Nothing Then
                If atEOF Then
                    'Don't even bother trying to read anything.
                    Return 0
                End If

                Dim readCount As Integer

                Do Until count < 1 OrElse atEOF
                    If Not Await AdvanceIndexAsync().ConfigureAwait(False) Then
                        buffer(index) = mChars(mcIndex)
                        index += 1
                        count -= 1
                        readCount += 1
                        mByteRead += 1
                    End If
                Loop

                Return readCount
            Else
                Return Await mOrg.ReadInternalAsync(term, buffer, index, count)
            End If
        End Function

        Private Async Function ReadLineInternalAsync(ByVal term As Char) As Task(Of String)
            If mOrg Is Nothing Then
                If atEOF Then
                    'Don't even bother trying to read anything.
                    Return Nothing
                End If

                Dim sb As New Text.StringBuilder
                Dim EOL As Boolean

                Do Until EOL Or atEOF
                    If Not Await AdvanceIndexAsync().ConfigureAwait(False) Then
                        If mTerm <> mChars(mcIndex) Then
                            sb.Append(mChars(mcIndex))
                        Else
                            Return sb.ToString
                        End If
                    End If
                Loop
                Return sb.ToString
            Else
                Return Await mOrg.ReadLineInternalAsync(term).ConfigureAwait(False)
            End If
        End Function

        Private Async Function AdvanceIndexAsync() As Task(Of Boolean)
            If atEOF Then
                Return True
            End If

            Do
                mcIndex += 1
                If mcIndex < mcReadSize Then
                    If Not IsControl(mChars(mcIndex)) Then
                        Return False
                    End If
                Else
                    'Need to refill the buffer
                    'this will only be called on a root reader
                    mcReadSize = Await mStreamReader.ReadAsync(mChars, 0, 1024).ConfigureAwait(False)
                    mcIndex = -1

                    atEOF = (mcReadSize = 0)

                    'check to make sure the EOF hasn't been reached
                    If atEOF Then
                        Return True
                    End If
                End If
            Loop
        End Function

        Private Shared Function IsControl(ByVal chr As Char) As Boolean
            Return AscW(chr) < 32
        End Function
    End Class

End Namespace
