Namespace EdiReader

    ''' <summary>
    ''' Wraps a segment reader with logic to determine the end of the functional group.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Class EdiGroupReader
        Private ReadOnly seg As GenericSegment
        Private atEOF As Boolean

        Friend Sub New(ByVal parent As EdiEnvelopeReader, ByVal reader As SegmentReader)
            Me.Parent = parent
            Me.Reader = reader
            seg = Me.Reader.CurrentSegment
        End Sub

        Friend ReadOnly Property Parent() As EdiEnvelopeReader

        Friend ReadOnly Property Reader() As SegmentReader

        ''' <summary>
        ''' Gets a value indicating if the end of the functional group has been reached.
        ''' </summary>
        ''' <value>true if the end of the functional group has been reached, false otherwise.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property IsAtEndOfGroup() As Boolean
            Get
                Return Parent.IsAtEndOfEnvelope OrElse atEOF
            End Get
        End Property

        ''' <summary>
        ''' Gets the value of the specified element in the functional group header (GS) segment.
        ''' </summary>
        ''' <param name="index">The index of the element to get.</param>
        ''' <value>The value of the specified element.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property Element(ByVal index As Integer) As String
            Get
                Return CType(seg.Elements(index), StringElement).Value
            End Get
        End Property

        Friend Sub Invalidate()
            atEOF = True
        End Sub

        ''' <summary>
        ''' Reads the next transaction set in the functional group.
        ''' </summary>
        ''' <returns>The next EdiTransactionSetReader in the functional group.</returns>
        ''' <remarks>If the next segment read isn't a transaction set header (ST) segment,
        ''' the reader is invalidated.</remarks>
        Public Async Function ReadTransactionSetAsync() As Task(Of EdiTransactionSetReader)
            If Not atEOF Then
                If Reader.CurrentSegment IsNot Nothing Then
                    Select Case Reader.CurrentSegment.SegmentID.ToUpper
                        Case "GE"
                            atEOF = True
                        Case "IEA"
                            atEOF = True
                    End Select
                End If

                If Not atEOF Then
                    Await Reader.ReadAsync().ConfigureAwait(False)

                    If Reader.CurrentSegment IsNot Nothing Then
                        If String.Compare(Reader.CurrentSegment.SegmentID, "ST", StringComparison.OrdinalIgnoreCase) = 0 Then
                            Reader.ResetCountTransaction()
                            Return New EdiTransactionSetReader(Me, Reader.CurrentSegment, Reader)
                        End If
                    End If
                End If
            End If

            atEOF = True
            Return Nothing
        End Function
    End Class

End Namespace
