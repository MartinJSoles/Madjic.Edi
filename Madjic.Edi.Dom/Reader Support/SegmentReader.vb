Namespace EdiReader

    'SegmentReader is used to buffer reading a segment at a time from the underlying FileReader.
    Friend Class SegmentReader
        Private ReadOnly mStream As FileReader
        Private mLastSeg As GenericSegment
        Private mSeg As GenericSegment
        Private mCountISA As Integer
        Private mCountGS As Integer
        Private mCountST As Integer

        Public ReadOnly Property CountEnvelope As Integer
            Get
                Return mCountISA
            End Get
        End Property

        Public ReadOnly Property CountGroup As Integer
            Get
                Return mCountGS
            End Get
        End Property

        Public ReadOnly Property CountTransaction As Integer
            Get
                Return mCountST
            End Get
        End Property

        Public Sub ResetCountEnvelope()
            mCountISA = 0
            mCountGS = 0
            mCountST = 0
        End Sub

        Public Sub ResetCountGroup()
            mCountGS = 0
            mCountST = 0
        End Sub

        Public Sub ResetCountTransaction()
            mCountST = 0
        End Sub

        Friend Sub New(ByVal reader As FileReader, ByVal elementSeparator As Char, ByVal compositeSeparator As Char, repeatingElementSeparator As Char)
            mStream = reader
            Me.ElementSeparator = elementSeparator
            Me.CompositeSeparator = compositeSeparator
            Me.RepeatingElementSeparator = repeatingElementSeparator
        End Sub

        Public ReadOnly Property RepeatingElementSeparator As Char

        Public ReadOnly Property ElementSeparator() As Char

        Public ReadOnly Property CompositeSeparator() As Char

        Public ReadOnly Property SegmentTerminator() As Char
            Get
                Return mStream.LineTerminator
            End Get
        End Property

        Public ReadOnly Property CurrentSegment() As GenericSegment
            Get
                Return mSeg
            End Get
        End Property

        Public ReadOnly Property PreviousSegment() As GenericSegment
            Get
                Return mLastSeg
            End Get
        End Property

        Public Async Function ReadAsync() As Task(Of GenericSegment)
            Dim line As String = Await mStream.ReadLineAsync().ConfigureAwait(False)
            Dim v() As String

            If line IsNot Nothing Then
                mLastSeg = mSeg
                v = line.Split(ElementSeparator)
                mSeg = New GenericSegment(v(0))

                For index = 1 To v.Length - 1
                    mSeg.Elements.Add(New StringElement(0, 4096))
                    CType(mSeg.Elements(index - 1), StringElement).Value = v(index)
                Next

                mCountISA += 1
                mCountGS += 1
                mCountST += 1
            ElseIf mSeg IsNot Nothing Then
                mLastSeg = mSeg
                mSeg = Nothing
            End If

            Return mSeg
        End Function
    End Class

End Namespace