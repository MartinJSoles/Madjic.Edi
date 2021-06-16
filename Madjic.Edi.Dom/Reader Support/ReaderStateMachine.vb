Friend Class ReaderStateMachine
    Inherits List(Of ReaderState)

    Friend Sub New(states As IEnumerable(Of ReaderState))
        MyBase.New()

        If states IsNot Nothing Then
            AddRange(states)
        End If
    End Sub

    Public Async Function RunAsync(ByVal segmentHandler As ProcessSegmentRoutine, ByVal loopHandler As ProcessLoopRoutine, ByVal initialState As Integer, ByVal args As ReaderArgs) As Task(Of Integer)
        Dim segment As String
        Dim CurrState As ReaderState
        Dim CurrentState As Integer = initialState

        If args.DataSegment Is Nothing Then
            Await args.ReadSegmentAsync().ConfigureAwait(False)
        End If

        segment = args.DataSegment.SegmentID

        Do
            CurrState = GetCurrentStateEntry(CurrentState, segment)

            If CurrState IsNot Nothing Then
                Select Case CurrState.Action
                    Case ReadAction.PopulateLoop
                        Await loopHandler.Invoke(args)

                        segment = args.DataSegment.SegmentID
                    Case ReadAction.PopulateSegment
                        segmentHandler.Invoke(args)

                        'Any time we read a segment, we will need to advance past it.
                        If Await args.ReadSegmentAsync().ConfigureAwait(False) Then
                            segment = args.DataSegment.SegmentID
                        Else
                            Return -2 'unexpected end of transaction
                        End If
                    Case ReadAction.PopulateSegmentAndLoop
                        segmentHandler.Invoke(args)
                        Dim ExitBoundedLoop As Boolean
                    
                        If Await args.ReadSegmentAsync().ConfigureAwait(False) Then

                        Do
                            Await loopHandler.Invoke(args).ConfigureAwait(False)
                            segment = args.DataSegment.SegmentID
                            ExitBoundedLoop = segment Is Nothing OrElse String.Compare(segment, "LE", StringComparison.OrdinalIgnoreCase) = 0
                        Loop Until ExitBoundedLoop
                        Else
                            Return -2
                        End If
                End Select

                CurrentState = CurrState.NextState
            Else
                Return -1 'unexpected segment
            End If
        Loop Until initialState < 0 OrElse CurrState Is Nothing OrElse CurrState.IsFinal

        Return initialState
    End Function

    Private Function GetCurrentStateEntry(currentState As Integer, segment As String) As ReaderState
        Dim ReturnValue = (From c In Me Where c.State = currentState AndAlso String.Compare(c.Segment, segment, StringComparison.OrdinalIgnoreCase) = 0).FirstOrDefault()

        Return ReturnValue
    End Function
End Class
