Namespace EdiReader

    ''' <summary>
    ''' Parses a physical file into envelopes, functional groups, transaction sets, and segments.
    ''' </summary>
    ''' <remarks>This is the top-level reader used for file processing.</remarks>
    Friend Class EdiFileReader
        Private mStream As FileReader
        Private mSegRdr As SegmentReader

        ''' <summary>
        ''' Opens a physical file for reading EDI data.
        ''' </summary>
        ''' <param name="stream">The base file stream to open.</param>
        ''' <remarks></remarks>
        Public Sub Open(ByVal stream As IO.Stream)
            If mStream IsNot Nothing Then
                mStream.Close()
            End If
            mStream = New FileReader(stream)
        End Sub

        ''' <summary>
        ''' Gets the number of bytes read in the physical file.
        ''' </summary>
        ''' <value>The number of bytes read in the physical file.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property FileBytesRead() As Long
            Get
                If mStream IsNot Nothing Then
                    Return mStream.FileBytesRead
                Else
                    Return 0
                End If
            End Get
        End Property

        ''' <summary>
        ''' Reads the next envelope segment from the file.
        ''' </summary>
        ''' <returns>A new EdiEnvelopeReader containing the next envelope.</returns>
        ''' <remarks></remarks>
        Public Async Function ReadEnvelopeAsync() As Task(Of EdiEnvelopeReader)
            If Not (mStream Is Nothing OrElse mStream.EOF) Then
                'Look for the ISA sequence
                Dim st As Integer = 0
                Dim chI As Integer = Await mStream.ReadAsync().ConfigureAwait(False)
                Dim ch As Char

                Do While chI > -1
                    ch = Char.ToUpper(ChrW(chI))

                    Select Case st
                        Case 0
                            If ch = "I"c Then
                                st = 1
                            End If
                        Case 1
                            If ch = "S"c Then
                                st = 2
                            ElseIf ch <> "I"c Then
                                st = 0
                            End If
                        Case 2
                            If ch = "A"c Then
                                'We have our ISA character sequence
                                Dim hdr(102) As Char
                                Dim net As Integer

                                net = Await mStream.ReadAsync(hdr, 0, 103).ConfigureAwait(False)
                                If net < 103 Then
                                    'Error, ran past EOF
                                    Return Nothing
                                End If

                                mStream.LineTerminator = hdr(102)
                                Dim elmSep As Char = hdr(0)
                                Dim val() As String
                                Dim line As String = "ISA" & New String(hdr)
                                val = line.Split(elmSep)
                                mSegRdr = New SegmentReader(mStream, elmSep, val(val.Length - 1).Chars(0), val(11).Chars(0))

                                Return New EdiEnvelopeReader(Me, val, mSegRdr)
                            ElseIf ch = "I"c Then
                                st = 1
                            Else
                                st = 0
                            End If
                    End Select
                    chI = Await mStream.ReadAsync().ConfigureAwait(False)
                Loop
            End If

            Return Nothing
        End Function

        ''' <summary>
        ''' Gets a value indicating if the end of the file has been reached.
        ''' </summary>
        ''' <value>true if the end of the file has been reached, false otherwise.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property IsAtEndOfFile() As Boolean
            Get
                If mStream IsNot Nothing Then
                    Return mStream.EOF
                Else
                    Return True
                End If
            End Get
        End Property

        ''' <summary>
        ''' Closes the current file, and invalidates any associated readers.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Close()
            If mStream IsNot Nothing Then
                mStream.Close()
                mStream = Nothing
            End If
        End Sub
    End Class

End Namespace