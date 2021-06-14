Namespace EdiReader

    ''' <summary>
    ''' Wraps the segment reader with logic to determine when the end of the transaction set has been reached.
    ''' </summary>
    ''' <remarks></remarks>
    Friend Class EdiTransactionSetReader
        Private ReadOnly mParent As EdiGroupReader
        Private atEOF As Boolean

        Friend Sub New(ByVal parent As EdiGroupReader, ByVal segment As GenericSegment, ByVal reader As SegmentReader)
            mParent = parent
            Me.Reader = reader
            DataSegment = segment
        End Sub

        Friend ReadOnly Property Reader() As SegmentReader

        ''' <summary>
        ''' Gets a value indicating if the reader is at the end of the transaction set.
        ''' </summary>
        ''' <value>true if the reader has encountered the end of the transaction set, false otherwise.</value>
        ''' <remarks>Note: the reader can be at the end of the transaction set if it attempts to read 
        ''' past the end of the physical file or encounters a segment that is part of the functional group (GS, GE)
        ''' or envelope (IEA).
        ''' 
        ''' The transaction set trailer segment (SE) is read before the flag is set.
        ''' </remarks>
        Public ReadOnly Property IsAtEndOfTransactionSet() As Boolean
            Get
                Return atEOF OrElse mParent.IsAtEndOfGroup
            End Get
        End Property

        ''' <summary>
        ''' Gets the element at the specified index in the transaction set header segment.
        ''' </summary>
        ''' <param name="index">The index of the element to retrieve.</param>
        ''' <value>The value of the element at the index specified.</value>
        ''' <remarks></remarks>
        Public ReadOnly Property Element(ByVal index As Integer) As String
            Get
                Return CType(DataSegment.Elements(index), StringElement).Value
            End Get
        End Property

        Friend ReadOnly Property DataSegment As GenericSegment

        ''' <summary>
        ''' Reads the next segment in the transaction set.
        ''' </summary>
        ''' <returns>An EdiSegment if the reader is not at the end of the transaction set.</returns>
        ''' <remarks></remarks>
        Friend Async Function ReadSegmentAsync() As Task(Of GenericSegment)
            If Not atEOF Then
                If Reader.CurrentSegment IsNot Nothing Then
                    'look at what was read
                    Select Case Reader.CurrentSegment.SegmentID.ToUpper
                        Case "SE"
                            atEOF = True
                        Case "GE"
                            atEOF = True
                        Case "GS"
                            atEOF = True
                            mParent.Invalidate()
                        Case "IEA"
                            atEOF = True
                            mParent.Invalidate()
                    End Select
                End If

                If Not atEOF Then
                    Return Await Reader.ReadAsync().ConfigureAwait(False)
                End If
            End If

            Return Nothing
        End Function
    End Class

End Namespace