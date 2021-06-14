Namespace EdiReader

    ''' <summary>
    ''' Wraps a segment reader with logic to enclose all segments within an ISA-IEA segment pair.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Class EdiEnvelopeReader
        Private ReadOnly seg As GenericSegment
        Private atEOF As Boolean

        Friend Sub New(ByVal parent As EdiFileReader, ByVal elements() As String, ByVal reader As SegmentReader)
            Me.Parent = parent
            Me.Reader = reader
            seg = New GenericSegment(elements(0))

            For index = 1 To elements.Length - 1
                seg.Elements.Add(New StringElement(0, 4096))

                CType(seg.Elements(index - 1), StringElement).Value = elements(index)
            Next
        End Sub

        Public ReadOnly Property RepeatingElementSeparator As Char
            Get
                Return Reader.RepeatingElementSeparator
            End Get
        End Property

        Public ReadOnly Property SegmentTerminator() As Char
            Get
                Return Reader.SegmentTerminator
            End Get
        End Property

        Public ReadOnly Property ElementSeparator() As Char
            Get
                Return Reader.ElementSeparator
            End Get
        End Property

        Public ReadOnly Property CompositeSeparator() As Char
            Get
                Return Reader.CompositeSeparator
            End Get
        End Property

        Friend ReadOnly Property Reader() As SegmentReader

        Friend ReadOnly Property Parent() As EdiFileReader

        ''' <summary>
        ''' Gets the value of the specified element in the envelope header (ISA) segment.
        ''' </summary>
        ''' <param name="index">The index of the element to get the value for.</param>
        ''' <value>The value of the specified element.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property Element(ByVal index As Integer) As String
            Get
                Return CType(seg.Elements(index), StringElement).Value
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating if the end of the envelope has been reached.
        ''' </summary>
        ''' <value>true if the end of the envelope has been reached, false otherwise.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property IsAtEndOfEnvelope() As Boolean
            Get
                Return Parent.IsAtEndOfFile OrElse atEOF
            End Get
        End Property

        Friend Sub Invalidate()
            atEOF = True
        End Sub

        Private mISB As Segments.ISB
        Private mISE As Segments.ISE

        Public ReadOnly Property EnvelopeIsbSegment As Segments.ISB
            Get
                Return mISB
            End Get
        End Property

        Public ReadOnly Property EnvelopeIseSegment As Segments.ISE
            Get
                Return mISE
            End Get
        End Property

        Public ReadOnly Property EnvelopTA1Segments As New List(Of Segments.TA1)

        Private mState As Integer '0=new (look for ISB, ISE, TA1, GS), 1=read ISB (look for ISE, TA1, GS), 2=read ISE (look for TA1, GS), 3=read TA1, (look for GS)

        ''' <summary>
        ''' Reads the next functional group in the envelope.
        ''' </summary>
        ''' <returns>A new EdiGroupReader for the next functional group.</returns>
        ''' <remarks>This method will skip over any envelope based segments that may exist before the first GS segment.</remarks>
        Public Async Function ReadGroup() As Task(Of EdiGroupReader)
            'Try to realign the reader to a GS or IEA segment
            Do Until atEOF
                If Reader.CurrentSegment IsNot Nothing Then
                    If mState = 0 Then 'At start, look for ISB, ISE, TA1, GS, or IEA
                        If String.Compare(Reader.CurrentSegment.SegmentID, "ISB", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mISB = Segments.ISB_Obj.FromGenericSegment(Reader.CurrentSegment, Reader)
                            mState = 1
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "ISE", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mISE = Segments.ISE_Obj.FromGenericSegment(Reader.CurrentSegment, Reader)
                            mState = 2
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "TA1", StringComparison.OrdinalIgnoreCase) = 0 Then
                            EnvelopTA1Segments.Add(Segments.TA1_Obj.FromGenericSegment(Reader.CurrentSegment, Reader))
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "GS", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mState = 3

                            Reader.ResetCountGroup()
                            Return New EdiGroupReader(Me, Reader)
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "IEA", StringComparison.OrdinalIgnoreCase) = 0 Then
                            atEOF = True
                        Else
                            atEOF = (Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing)
                        End If
                    ElseIf mState = 1 Then 'Found an ISB segment, look for ISE, TA1, GS, or IEA
                        If String.Compare(Reader.CurrentSegment.SegmentID, "ISE", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mISE = Segments.ISE_Obj.FromGenericSegment(Reader.CurrentSegment, Reader)
                            mState = 2
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "TA1", StringComparison.OrdinalIgnoreCase) = 0 Then
                            EnvelopTA1Segments.Add(Segments.TA1_Obj.FromGenericSegment(Reader.CurrentSegment, Reader))
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "GS", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mState = 3

                            Reader.ResetCountGroup()
                            Return New EdiGroupReader(Me, Reader)
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "IEA", StringComparison.OrdinalIgnoreCase) = 0 Then
                            atEOF = True
                        Else
                            atEOF = (Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing)
                        End If
                    ElseIf mState = 2 Then 'Found ISE, look for TA1, GS, or IEA
                        If String.Compare(Reader.CurrentSegment.SegmentID, "TA1", StringComparison.OrdinalIgnoreCase) = 0 Then
                            EnvelopTA1Segments.Add(Segments.TA1_Obj.FromGenericSegment(Reader.CurrentSegment, Reader))
                            atEOF = Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "GS", StringComparison.OrdinalIgnoreCase) = 0 Then
                            mState = 3

                            Reader.ResetCountGroup()
                            Return New EdiGroupReader(Me, Reader)
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "IEA", StringComparison.OrdinalIgnoreCase) = 0 Then
                            atEOF = True
                        Else
                            atEOF = (Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing)
                        End If
                    Else 'Look for GS or IEA
                        If String.Compare(Reader.CurrentSegment.SegmentID, "GS", StringComparison.OrdinalIgnoreCase) = 0 Then
                            Reader.ResetCountGroup()
                            Return New EdiGroupReader(Me, Reader)
                        ElseIf String.Compare(Reader.CurrentSegment.SegmentID, "IEA", StringComparison.OrdinalIgnoreCase) = 0 Then
                            atEOF = True
                        Else
                            atEOF = (Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing)
                        End If
                    End If
                Else
                    atEOF = (Await Reader.ReadAsync().ConfigureAwait(False) Is Nothing)
                End If
            Loop

            Return Nothing
        End Function
    End Class

End Namespace