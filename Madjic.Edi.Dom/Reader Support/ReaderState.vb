Friend Class ReaderState

    ''' <summary>
    ''' Creates a state machine state instance
    ''' </summary>
    ''' <param name="state">The incoming state</param>
    ''' <param name="segment">The name of the segment</param>
    ''' <param name="action">The action to perform</param>
    Friend Sub New(ByVal state As Integer, ByVal segment As String, ByVal action As ReadAction, ByVal nextState As Integer, ByVal isFinal As Boolean)
        Me.State = state
        Me.Segment = segment
        Me.Action = action
        Me.NextState = nextState
        Me.IsFinal = isFinal
    End Sub

    ''' <summary>
    ''' The state to match up when running the state machine
    ''' </summary>
    Friend Property State() As Integer

    ''' <summary>
    ''' The name of the segment to match up when running the state machine
    ''' </summary>
    Friend Property Segment() As String

    ''' <summary>
    ''' The action to take when a matching entry is found while running the state machine
    ''' </summary>
    Friend Property Action() As ReadAction

    ''' <summary>
    ''' The state the machine should be in after the action is performed
    ''' </summary>
    Friend Property NextState() As Integer

    ''' <summary>
    ''' Indicates that this state is final
    ''' </summary>
    Friend Property IsFinal() As Boolean

End Class

''' <summary>
''' A method that is responsible for adding a segment to the current object.
''' </summary>
''' <param name="args">A support object that maintains the arguments for the read operation.</param>
''' <remarks>If the segment cannot be read by the current object, an exception should be thrown. The information should've been filtered before reaching this method.</remarks>
Friend Delegate Sub ProcessSegmentRoutine(ByVal args As ReaderArgs)

''' <summary>
''' A method that is responsible for adding a child loop to the current object.
''' </summary>
''' <param name="args">A support object that maintains the arguments for the read operation.</param>
''' <remarks>If the segment cannot be read by the current object, an exception should be thrown. The information should've been filtered before reaching this method.</remarks>
Friend Delegate Function ProcessLoopRoutine(ByVal args As ReaderArgs) As Task

''' <summary>
''' Identifies the action to take in this state.
''' </summary>
Friend Enum ReadAction
    ''' <summary>
    ''' The segment should be populated.
    ''' </summary>
    PopulateSegment

    ''' <summary>
    ''' The child loop should be populated.
    ''' </summary>
    PopulateLoop

    ''' <summary>
    ''' Skips the current segment and reads the next one from the source stream.
    ''' </summary>
    Advance

    ''' <summary>
    ''' Just change the reader state without any other action.
    ''' </summary>
    DoNothing

    ''' <summary>
    ''' The segment should be populated and then a loop populated from the next segment.
    ''' </summary>
    PopulateSegmentAndStartBoundedLoop
End Enum
