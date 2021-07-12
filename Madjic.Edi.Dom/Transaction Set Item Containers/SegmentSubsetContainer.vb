Public Class SegmentSubsetContainer(Of T As ISegment, K As ISegment)
    Implements ITransactionSetItem, IValidate, IParanted, IList(Of T)

    Public Overrides Function ToString() As String
        Return String.Format("SegmentSubsetContainer, T: {0}, K: {1}, Count: {2}, Area: {3}, Sequence: {4}, Repeat: {5}, Parent: {6}", GetType(T).ToString, GetType(K).ToString, mList.Count, Area, Sequence, mRepeat, mList.ToString)
    End Function

    Private ReadOnly mList As SegmentContainer(Of K)
    Private ReadOnly mRepeat As Integer

    ''' <summary>
    ''' Identifies the area for the implementation as an integer.
    ''' </summary>
    ''' <remarks>This is defined in the implementation guides as a single character. Letters A-Z are translated to 10 - 35.</remarks>
    Public ReadOnly Property Area As String

    ''' <summary>
    ''' Identifies the sequence in the area for the implementation.
    ''' </summary>
    Public ReadOnly Property Sequence As String

    ''' <summary>
    ''' Creates a new instance of the <see cref="SegmentSubsetContainer(Of T, K)">SegmentSubsetContainer</see> class.
    ''' </summary>
    ''' <param name="baseCollection">The segment collection as defined by the standard.</param>
    ''' <param name="area">The area for the implementation.</param>
    ''' <param name="sequence">The segment sequence in the implementation area.</param>
    ''' <remarks>These collections can only be instantiated by the current assembly.</remarks>
    Friend Sub New(baseCollection As SegmentContainer(Of K), repeat As Integer, area As String, sequence As String)
        mList = baseCollection
        Me.Area = area
        Me.Sequence = sequence
        mRepeat = repeat
    End Sub

    Private Property Parent As IParanted Implements IParanted.Parent

    Private ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Nothing
        End Get
    End Property

    Friend Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        Return Task.CompletedTask
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer = 0
        If Children IsNot Nothing Then
            For Each node In Children
                If TypeOf node Is Segment Then
                    rval += 1
                Else
                    rval += node.WriteCount
                End If
            Next
        End If

        Return rval
    End Function

    Friend Sub Validate(results As ValidationResults) Implements IValidate.Validate

    End Sub

    Private Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren

    End Sub

    ''' <summary>
    ''' Adds a new segment to the end of the collection.
    ''' </summary>
    ''' <param name="item">The segment to add to the collection.</param>
    Public Sub Add(item As T) Implements ICollection(Of T).Add
        If mRepeat > 1 AndAlso Count >= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        Dim s As ISegment = TryCast(item, Segment)

        If s IsNot Nothing AndAlso TypeOf item Is K Then
            s.SetArea = Area
            s.SetSequence = Sequence

            mList.Add(CType(s, K))
        End If
    End Sub

    ''' <summary>
    ''' Adds multiple segment instances to the end of the collection.
    ''' </summary>
    Public Sub AddRange(items As IEnumerable(Of T))
        For Each node In items
            Add(node)
        Next
    End Sub

    ''' <summary>
    ''' Removes all segments for this area and sequence from the collection.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Clear() Implements ICollection(Of T).Clear
        Dim s As ISegment

        For index = mList.Count - 1 To 0 Step -1
            s = TryCast(mList(index), ISegment)

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                mList.RemoveAt(index)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Determines if the given segment is contained in this collection.
    ''' </summary>
    ''' <returns>True, if the segment is contained. Flase, otherwise.</returns>
    Public Function Contains(item As T) As Boolean Implements ICollection(Of T).Contains
        Dim s = TryCast(item, ISegment)

        If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea IsNot Nothing AndAlso s.SetSequence IsNot Nothing AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
            Return mList.Contains(CType(s, K))
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Copies all items in this collection to the given array, starting at the given index.
    ''' </summary>
    ''' <param name="array">The array to copy the collection items to.</param>
    ''' <param name="arrayIndex">The starting index to copy items into the array.</param>
    Public Sub CopyTo(array() As T, arrayIndex As Integer) Implements ICollection(Of T).CopyTo
        Dim index As Integer = arrayIndex
        Dim s As ISegment

        For Each node In mList
            s = TryCast(node, ISegment)

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea IsNot Nothing AndAlso s.SetSequence IsNot Nothing AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
                array(index) = s
                index += 1
            End If

        Next
    End Sub

    ''' <summary>
    ''' Gets the number of items contained in this collection.
    ''' </summary>
    Public ReadOnly Property Count As Integer Implements ICollection(Of T).Count
        Get
            Dim index As Integer
            Dim s As Segment

            For Each node In mList
                s = TryCast(node, Segment)

                If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                    index += 1
                End If
            Next

            Return index
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of T).IsReadOnly
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Removes the given segment from the collection.
    ''' </summary>
    Public Function Remove(item As T) As Boolean Implements ICollection(Of T).Remove
        Dim s = TryCast(item, ISegment)

        If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
            Return mList.Remove(s)
        Else
            Return False
        End If
    End Function

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return New SubsetEnumerator(Me)
    End Function

    ''' <summary>
    ''' Gets the index at which the given item is stored in the collection.
    ''' </summary>
    Public Function IndexOf(item As T) As Integer Implements IList(Of T).IndexOf
        Dim index As Integer
        Dim s As Segment

        For Each node In mList
            If node.Equals(item) Then
                Return index
            End If

            s = TryCast(node, Segment)

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea IsNot Nothing AndAlso s.SetSequence IsNot Nothing AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
                index += 1
            End If
        Next

        Return -1
    End Function

    ''' <summary>
    ''' Inserts the given item so that it will be at the indicated index in the collection.
    ''' </summary>
    Public Sub Insert(index As Integer, item As T) Implements IList(Of T).Insert
        Dim idx As Integer
        Dim Curt As Integer

        Dim s As ISegment
        Dim t = TryCast(item, ISegment)

        If mRepeat > 1 AndAlso Count <= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        If t IsNot Nothing AndAlso TypeOf t Is K Then
            t.SetArea = Area
            t.SetSequence = Sequence

            For Each node In mList
                s = TryCast(node, Segment)

                If s IsNot Nothing AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                    If index <= idx Then
                        mList.Insert(Curt, t)
                        Exit Sub
                    End If

                    idx += 1
                End If

                Curt += 1
            Next

            mList.Add(t)
        End If
    End Sub

    ''' <summary>
    ''' Gets/sets the item at the given index.
    ''' </summary>
    Default Public Property Item(index As Integer) As T Implements IList(Of T).Item
        Get
            Dim idx As Integer
            Dim s As ISegment

            For Each node In mList
                s = TryCast(node, Segment)

                If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                    If idx = index Then
                        s = CType(node, ISegment)
                        Return CType(s, T)
                    End If
                    idx += 1
                End If
            Next

            Throw New IndexOutOfRangeException
        End Get
        Set(value As T)
            Dim idx As Integer
            Dim curt As Integer

            Dim s As ISegment
            Dim t = TryCast(value, ISegment)

            If t IsNot Nothing AndAlso TypeOf t Is K Then
                For Each node In mList
                    s = TryCast(node, ISegment)

                    If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                        If idx = index Then
                            If t IsNot Nothing Then
                                t.SetArea = Area
                                t.SetSequence = Sequence
                            End If

                            mList(curt) = t
                            Exit Property
                        End If

                        idx += 1
                    End If

                    curt += 1
                Next
            End If

            Throw New IndexOutOfRangeException
        End Set
    End Property

    ''' <summary>
    ''' Removes the item at the given index in the collection.
    ''' </summary>
    Public Sub RemoveAt(index As Integer) Implements IList(Of T).RemoveAt
        Dim idx As Integer
        Dim curt As Integer
        Dim s As ISegment

        For Each node In mList
            s = TryCast(node, ISegment)

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso String.Compare(s.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                If idx = index Then
                    mList.RemoveAt(curt)
                    Exit Sub
                End If

                idx += 1
            End If

            curt += 1
        Next

        Throw New IndexOutOfRangeException
    End Sub

    Private Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

    Private Class SubsetEnumerator
        Implements IEnumerator(Of T)

        Private mParent As SegmentSubsetContainer(Of T, K)
        Public Sub New(parent As SegmentSubsetContainer(Of T, K))
            mParent = parent
        End Sub

        Private mIndex As Integer = -1

        Public ReadOnly Property Current As T Implements IEnumerator(Of T).Current
            Get
                If mIndex < -1 Then
                    Throw New NotSupportedException
                Else
                    Dim s As ISegment = TryCast(mParent.mList(mIndex), ISegment)
                    Return CType(s, T)
                End If
            End Get
        End Property

        Private ReadOnly Property Current1 As Object Implements IEnumerator.Current
            Get
                Return Current
            End Get
        End Property

        Private Function GetSegment(index) As ISegment
            Dim s As ISegment

            s = TryCast(mParent.mList(index), ISegment)
            Return s
        End Function
        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Dim s As ISegment

            Do
                mIndex += 1

                If mIndex < mParent.mList.Count Then
                    s = GetSegment(mIndex)

                    If s IsNot Nothing AndAlso TypeOf s Is K Then
                        If String.Compare(s.SetArea, mParent.Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(s.SetSequence, mParent.Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                            Return True
                        End If
                    End If
                Else
                    Exit Do
                End If
            Loop

            Return False
        End Function

        Public Sub Reset() Implements IEnumerator.Reset
            mIndex = -1
        End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    mParent = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Class
