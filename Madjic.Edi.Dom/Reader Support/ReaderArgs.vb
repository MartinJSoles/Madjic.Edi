''' <summary>
''' A class that assists with the ReaderStateMachine.
''' </summary>
Friend Class ReaderArgs

    ''' <summary>
    ''' Creates a new instance of the ReaderArgs class.
    ''' </summary>
    ''' <param name="reader">An EdiTransactionSetReader that is responsible for actually reading the segments from the source stream.</param>
    Friend Sub New(reader As EdiReader.EdiTransactionSetReader)
        Me.Reader = reader
        mSegment = reader.DataSegment
    End Sub

    Private mSegment As GenericSegment

    ''' <summary>
    ''' Gets the EdiTransactionSetReader object currently being used to read the segments from the source stream.
    ''' </summary>
    Friend ReadOnly Property Reader As EdiReader.EdiTransactionSetReader

    ''' <summary>
    ''' Gets the current data segment that was read from the source stream.
    ''' </summary>
    Friend ReadOnly Property DataSegment As GenericSegment
        Get
            Return mSegment
        End Get
    End Property

    ''' <summary>
    ''' Reads the next segment from the source stream.
    ''' </summary>
    ''' <returns>True, if a segment was read. False is returned if we are at the end of the transaction set.</returns>
    Friend Async Function ReadSegmentAsync() As Task(Of Boolean)
        mSegment = Await Reader.ReadSegmentAsync().ConfigureAwait(False)

        Return mSegment IsNot Nothing
    End Function

    ''' <summary>
    ''' Gets/sets the specific implementation that this reader is working for (should be the name as defined by the database (such as 837-Q1)
    ''' </summary>
    ''' <remarks>The populate methods need to know this information so that they can assign the correct area and sequence values to make the SubsetCollections work correctly.</remarks>
    Friend Property Implementation As String

    ''' <summary>
    ''' Gets/sets the parent loop ID for this reader (null indicates the root transaction set).
    ''' </summary>
    ''' <remarks>This will aid in assigning the correct area/sequence for child segments.</remarks>
    Friend Property ParentLoopID As String
End Class
