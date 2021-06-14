Public Interface ITransactionSetItem

    ''' <summary>
    ''' Async Write the transaction set item and any child items it may contain.
    ''' </summary>
    ''' <param name="writer">A <see cref="IO.TextWriter">TextWriter</see> object that the transaction set item and any child items it contains will write to.</param>
    ''' <param name="clearAfterWrite">True, if the child items should be deleted after writing. False, to preserve the child items.</param>
    ''' <param name="envelope">The <see cref="Envelope">Envelope</see> object to use for writing separators and terminators.</param>
    ''' <returns></returns>
    Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task

    Function WriteCount() As Integer

    ReadOnly Property Children As IList(Of ITransactionSetItem)
End Interface

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
    Public ReadOnly Property Area As Integer

    ''' <summary>
    ''' Identifies the sequence in the area for the implementation.
    ''' </summary>
    Public ReadOnly Property Sequence As Integer

    ''' <summary>
    ''' Creates a new instance of the <see cref="SegmentSubsetContainer(Of T, K)">SegmentSubsetContainer</see> class.
    ''' </summary>
    ''' <param name="baseCollection">The segment collection as defined by the standard.</param>
    ''' <param name="area">The area for the implementation.</param>
    ''' <param name="sequence">The segment sequence in the implementation area.</param>
    ''' <remarks>These collections can only be instantiated by the current assembly.</remarks>
    Friend Sub New(baseCollection As SegmentContainer(Of K), repeat As Integer, area As Integer, sequence As Integer)
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
        If mRepeat > 1 AndAlso Count <= mRepeat Then
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

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

        If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

                If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

        If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

                If s IsNot Nothing AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

                If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

                    If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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

            If s IsNot Nothing AndAlso TypeOf s Is K AndAlso s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = Area AndAlso s.SetSequence = Sequence Then
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
                        If s.SetArea.HasValue AndAlso s.SetSequence.HasValue AndAlso s.SetArea = mParent.Area AndAlso s.SetSequence = mParent.Sequence Then
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

Public Class SegmentContainer(Of T As ISegment)
    Implements ITransactionSetItem, IValidate, IParanted, IList(Of T)

    Public Overrides Function ToString() As String
        Return $"SegmentContainer, T: {GetType(T).Name}, Count: {Count}, Table: {Table}, Position: {Position}, MaximumStorage: {MaximumStorage}, Parent: {If(Parent, "(null)")}"
    End Function

    Public ReadOnly Property Table As Integer
    Public ReadOnly Property Position As Integer

    Public ReadOnly Property MaximumStorage As Integer

    Friend Sub New(table As Integer, position As Integer)
        Me.New(0, table, position)
    End Sub

    Friend Sub New(maximumStorage As Integer, table As Integer, position As Integer)
        MyBase.New()

        Me.MaximumStorage = maximumStorage
        Me.Table = table
        Me.Position = position
    End Sub

    Private ReadOnly Property _Segments As IList(Of ITransactionSetItem) = New List(Of T) Implements ITransactionSetItem.Children

    Friend Overridable Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In _Segments
            Dim ch = TryCast(node, Segment)

            If ch IsNot Nothing Then
                Await ch.WriteAsync(writer, envelope)
            End If
        Next

        If clearAfterWrite Then
            _Segments.Clear()
        End If
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each node In _Segments
            Dim ch = TryCast(node, Segment)

            If ch IsNot Nothing Then
                rval += 1
            End If
        Next

        Return rval
    End Function

    Public Overridable Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim e As New ValidationFailureResult With {.Source = Me}
        If MaximumStorage > 0 AndAlso MaximumStorage < Count Then
            e.Errors.Add("The segment container is currently holding too many segments.")
        End If

        'Look through each segment and ensure it is for the right table/position/area/sequence
        Dim s As Segment
        For Each seg In Me
            s = TryCast(seg, Segment)

            If s IsNot Nothing Then
                If s.SetTable <> Table OrElse s.SetPosition <> Position Then
                    e.Errors.Add(String.Format("This object contains an invalid segment: {0}", s.SegmentID))
                End If
            End If
        Next

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Public Overridable Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each child In _Segments
            Dim ch = TryCast(child, IValidate)

            If ch IsNot Nothing Then
                ch.Validate(results)
                ch.ValidateChildren(results)
            End If
        Next
    End Sub

    Friend Sub SetImplementationRules(rules As IEnumerable(Of SyntaxRule))
        For Each child In _Segments
            Dim ch = TryCast(child, Segment)

            If ch IsNot Nothing Then
                ch.SetImplementationRules(rules)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

    Public Sub Add(item As T) Implements ICollection(Of T).Add
        _Segments.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of T).Clear
        _Segments.Clear()
    End Sub

    Public Function Contains(item As T) As Boolean Implements ICollection(Of T).Contains
        Return _Segments.Contains(item)
    End Function

    Public Sub CopyTo(array() As T, arrayIndex As Integer) Implements ICollection(Of T).CopyTo
        _Segments.CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count As Integer Implements ICollection(Of T).Count
        Get
            Return _Segments.Count
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of T).IsReadOnly
        Get
            Return False
        End Get
    End Property

    Public Function Remove(item As T) As Boolean Implements ICollection(Of T).Remove
        Return _Segments.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return _Segments.GetEnumerator
    End Function

    Public Function IndexOf(item As T) As Integer Implements IList(Of T).IndexOf
        Return _Segments.IndexOf(item)
    End Function

    Public Sub Insert(index As Integer, item As T) Implements IList(Of T).Insert
        _Segments.Insert(index, item)
    End Sub

    Default Public Property Item(index As Integer) As T Implements IList(Of T).Item
        Get
            Return _Segments(index)
        End Get
        Set(value As T)
            _Segments(index) = value
        End Set
    End Property

    Public Sub RemoveAt(index As Integer) Implements IList(Of T).RemoveAt
        _Segments.RemoveAt(index)
    End Sub

    Private Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return _Segments.GetEnumerator
    End Function

    Public Sub AddRange(items As IEnumerable(Of T))
        _Segments.AddRange(items)
    End Sub
End Class

Public Class LoopContainer(Of T As ILoop)
    Inherits List(Of T)
    Implements ITransactionSetItem, IValidate, IParanted

    Public Overrides Function ToString() As String
        Return String.Format("LoopContainer, T: {0}, Table: {1}, Position: {2}, Maximum Repetitions: {3}, Count: {4}, Parent: {5}", GetType(T).ToString, Table, Position, MaximumRepetitions, Count, If(Parent IsNot Nothing, Parent.ToString, "(null)"))
    End Function

    Public ReadOnly Property Table As Integer

    Public ReadOnly Property Position As Integer

    Public Sub New(table As Integer, position As Integer)
        Me.New(0, table, position)
    End Sub

    Public Sub New(maximumRepetitions As Integer, table As Integer, position As Integer)
        MyBase.New()
        Me.MaximumRepetitions = maximumRepetitions
        Me.Table = table
        Me.Position = position
    End Sub

    Public ReadOnly Property MaximumRepetitions As Integer

    Friend ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Me
        End Get
    End Property

    Friend Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In Me
            Await node.WriteAsync(writer, clearAfterWrite, envelope)
        Next
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each node In Me
            If node IsNot Nothing Then
                rval += node.WriteCount
            End If
        Next

        Return rval
    End Function

    Public Sub Validate(results As ValidationResults) Implements IValidate.Validate
        Dim e As New ValidationFailureResult With {.Source = Me}

        If MaximumRepetitions > 0 AndAlso Count > MaximumRepetitions Then
            e.Errors.Add("The maximum number of repetitions for this loop has been exceeded.")
        End If

        For Each node In Me
            Dim n = TryCast(node, LoopBase)

            If n IsNot Nothing Then
                If n.SetTable <> Table OrElse n.SetPosition <> Position Then
                    e.Errors.Add(String.Format("The loop {0} with Table {1} and Position {2} is not valid.", n.LoopID, n.SetTable, n.SetPosition))
                End If
            End If
        Next

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Public Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        Dim TryItem As IValidate

        For Each node In Me
            TryItem = TryCast(node, IValidate)

            If TryItem IsNot Nothing Then
                TryItem.Validate(results)
                TryItem.ValidateChildren(results)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

End Class

Public Class LoopSubsetContainer(Of T As ILoop, K As ILoop)
    Implements IList(Of T), ICollection(Of T), ITransactionSetItem, IValidate, IParanted

    Private ReadOnly mRepeat As Integer

    Public Overrides Function ToString() As String
        Return String.Format("LoopSubsetContainer, T: {0}, K: {1}, Area: {2}, Sequence: {3}, Repeat: {4}, Count: {5}, Parent: {6}", GetType(T).ToString, GetType(K).ToString, Area, Sequence, mRepeat, Count, If(Parent?.ToString, "(null)"))
    End Function

    Friend ReadOnly Property Parent As LoopContainer(Of K)

    ''' <summary>
    ''' Gets the area that this loop instance is defined in the implementation.
    ''' </summary>
    Public ReadOnly Property Area As Integer

    ''' <summary>
    ''' Gets the sequence that this loop instance is defined in the implementation.
    ''' </summary>
    Public ReadOnly Property Sequence As Integer

    ''' <summary>
    ''' Creates a new instance of the <see cref="LoopSubsetContainer(Of T, K)">LoopSubsetContainer</see> class.
    ''' </summary>
    ''' <param name="parent">The base loop collection this subset is based on.</param>
    ''' <param name="area">The implementation area covered by this collection.</param>
    ''' <param name="sequence">The area sequence covered by this collection.</param>
    ''' <remarks></remarks>
    Friend Sub New(parent As LoopContainer(Of K), repeat As Integer, area As Integer, sequence As Integer)
        Me.Parent = parent
        Me.Area = area
        Me.Sequence = sequence
        mRepeat = repeat
    End Sub

    Private Property Parent1 As IParanted Implements IParanted.Parent

    Private ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Nothing
        End Get
    End Property

    Friend Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        Return Task.CompletedTask
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Return 0
    End Function

    Friend Sub Validate(results As ValidationResults) Implements IValidate.Validate

    End Sub

    Friend Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren

    End Sub

    ''' <summary>
    ''' Adds the given loop instance to the collection.
    ''' </summary>
    Public Sub Add(item As T) Implements ICollection(Of T).Add
        Dim L = TryCast(item, ILoop)

        If mRepeat > 1 AndAlso Count <= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        If L IsNot Nothing AndAlso TypeOf L Is K Then
            L.SetArea = Area
            L.SetSequence = Sequence

            Parent.Add(L)
        Else
            Throw New InvalidCastException
        End If
    End Sub

    Public Sub AddRange(items As IEnumerable(Of T))
        For Each node In items
            Add(node)
        Next
    End Sub

    ''' <summary>
    ''' Removes all loops from this collection.
    ''' </summary>
    Public Sub Clear() Implements ICollection(Of T).Clear
        For index = Parent.Count - 1 To 0 Step -1
            Dim n = TryCast(Parent(index), ILoop)

            If n IsNot Nothing AndAlso TypeOf n Is K AndAlso n.SetArea.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence.HasValue AndAlso n.SetSequence = Sequence Then
                Parent.RemoveAt(index)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Indicates whether the given item is contained by this collection.
    ''' </summary>
    Public Function Contains(item As T) As Boolean Implements ICollection(Of T).Contains
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is K AndAlso L.SetArea.HasValue AndAlso L.SetSequence.HasValue AndAlso L.SetArea = Area AndAlso L.SetSequence = Sequence Then
            Return Parent.Contains(L)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Copies all items contained in this collection to the given array, starting at the specified index.
    ''' </summary>
    Public Sub CopyTo(array() As T, arrayIndex As Integer) Implements ICollection(Of T).CopyTo
        For Each node In Parent
            Dim n = TryCast(node, ILoop)

            If n IsNot Nothing AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                array(arrayIndex) = n
                arrayIndex += 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' Gets the number of items contained by this collection.
    ''' </summary>
    Public ReadOnly Property Count As Integer Implements ICollection(Of T).Count
        Get
            Dim idx As Integer

            For Each node In Parent
                Dim n = TryCast(node, ILoop)

                If n IsNot Nothing AndAlso TypeOf n Is K AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                    idx += 1
                End If
            Next

            Return idx
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of T).IsReadOnly
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Removes the given item from the collection.
    ''' </summary>
    Public Function Remove(item As T) As Boolean Implements ICollection(Of T).Remove
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is K AndAlso L.SetArea.HasValue AndAlso L.SetSequence.HasValue AndAlso L.SetArea = Area AndAlso L.SetSequence = Sequence Then
            Return Parent.Remove(L)
        Else
            Return False
        End If
    End Function

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return New SubsetEnumerator(Me)
    End Function

    ''' <summary>
    ''' Gets the index that the given item is at in the collection.
    ''' </summary>
    Public Function IndexOf(item As T) As Integer Implements IList(Of T).IndexOf
        Dim idx As Integer
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is K AndAlso L.SetArea.HasValue AndAlso L.SetSequence.HasValue AndAlso L.SetArea = Area AndAlso L.SetSequence = Sequence Then
            For Each node In Parent
                If node.Equals(L) Then
                    Return idx
                End If

                Dim n = TryCast(node, ILoop)

                If n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                    idx += 1
                End If
            Next
        End If

        Return -1
    End Function

    ''' <summary>
    ''' Inserts the given item at the index specified.
    ''' </summary>
    Public Sub Insert(index As Integer, item As T) Implements IList(Of T).Insert
        Dim curt As Integer
        Dim idx As Integer
        Dim L = TryCast(item, ILoop)

        If mRepeat > 1 AndAlso Count <= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        If L IsNot Nothing AndAlso TypeOf L Is K Then
            L.SetArea = Area
            L.SetSequence = Sequence

            Do While curt < Parent.Count AndAlso idx <= index
                Dim n = TryCast(Parent(curt), ILoop)

                If n IsNot Nothing AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                    If idx = index Then
                        Parent.Insert(curt, L)
                        Exit Sub
                    End If

                    idx += 1
                End If

                curt += 1
            Loop

            Parent.Add(L)
        End If
    End Sub

    ''' <summary>
    ''' Gets/sets the item at the given index.
    ''' </summary>
    Default Public Property Item(index As Integer) As T Implements IList(Of T).Item
        Get
            Dim idx As Integer

            For Each node In Parent
                Dim n = TryCast(node, ILoop)

                If n IsNot Nothing AndAlso TypeOf n Is K AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                    If index = idx Then
                        n = TryCast(node, ILoop)
                        Return n
                    End If

                    idx += 1
                End If
            Next

            Throw New IndexOutOfRangeException
        End Get
        Set(value As T)
            Dim idx As Integer
            Dim L = TryCast(value, ILoop)

            If L IsNot Nothing AndAlso TypeOf L Is K Then
                For curt = 0 To Parent.Count - 1
                    Dim n = TryCast(Parent(curt), ILoop)

                    If n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                        If idx = index Then
                            L.SetArea = Area
                            L.SetSequence = Sequence

                            Parent(curt) = L
                            Exit Property
                        End If

                        idx += 1
                    End If
                Next

            End If
            Throw New IndexOutOfRangeException
        End Set
    End Property

    ''' <summary>
    ''' Removes the item at the given index.
    ''' </summary>
    Public Sub RemoveAt(index As Integer) Implements IList(Of T).RemoveAt
        Dim idx As Integer
        For curt = 0 To Parent.Count - 1
            Dim n = TryCast(Parent(curt), LoopBase)

            If n IsNot Nothing AndAlso TypeOf n Is K AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = Area AndAlso n.SetSequence = Sequence Then
                If index = idx Then
                    Parent.RemoveAt(curt)
                    Exit Sub
                End If

                idx += 1
            End If
        Next

        Throw New IndexOutOfRangeException
    End Sub

    Private Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

    Private Class SubsetEnumerator
        Implements IEnumerator(Of T)


        Private mParent As LoopSubsetContainer(Of T, K)
        Private mCurrent As Integer

        Public Sub New(parent As LoopSubsetContainer(Of T, K))
            mParent = parent
            mCurrent = -1
        End Sub

        Public ReadOnly Property Current As T Implements IEnumerator(Of T).Current
            Get
                If mCurrent < 0 Then
                    Throw New NotSupportedException
                Else
                    Return mParent(mCurrent)
                End If
            End Get
        End Property

        Private ReadOnly Property Current1 As Object Implements IEnumerator.Current
            Get
                Return Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            Do While mCurrent < mParent.Parent.Count - 1
                mCurrent += 1

                Dim n As LoopBase = TryCast(mParent(mCurrent), LoopBase)

                If n IsNot Nothing AndAlso TypeOf n Is K AndAlso n.SetArea.HasValue AndAlso n.SetSequence.HasValue AndAlso n.SetArea = mParent.Area AndAlso n.SetSequence = mParent.Sequence Then
                    Exit Do
                End If
            Loop

            Return mCurrent < mParent.Parent.Count
        End Function

        Public Sub Reset() Implements IEnumerator.Reset
            mCurrent = -1
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

Public MustInherit Class LoopBase
    Inherits List(Of ITransactionSetItem)
    Implements ILoop, IValidate, IParanted

    Public Overrides Function ToString() As String
        Return String.Format("Loop {3}, Table: {0}, Position: {1}, Count: {2}", SetTable, SetPosition, Count, If(LoopID, "(null)"))
    End Function

    Public ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ITransactionSetItem.Children
        Get
            Return Me
        End Get
    End Property

    Friend Async Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ITransactionSetItem.WriteAsync
        For Each node In Me
            If node IsNot Nothing Then
                Await node.WriteAsync(writer, clearAfterWrite, envelope)
            End If
        Next
    End Function

    Friend Function WriteCount() As Integer Implements ITransactionSetItem.WriteCount
        Dim rval As Integer

        For Each node In Me
            If node IsNot Nothing Then
                If TypeOf node Is Segment Then
                    rval += 1
                Else
                    rval += node.WriteCount
                End If
            End If
        Next

        Return rval
    End Function

    Public Overridable Sub Validate(results As ValidationResults) Implements IValidate.Validate

    End Sub

    Public Overridable Sub ValidateChildren(results As ValidationResults) Implements IValidate.ValidateChildren
        Dim TryValidate As IValidate

        For Each node In Me
            TryValidate = TryCast(node, IValidate)

            If TryValidate IsNot Nothing Then
                TryValidate.Validate(results)
                TryValidate.ValidateChildren(results)
            End If
        Next
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

    'These are used to link the actual instances of loops to their appropriate collections.
    Friend Property SetArea As Integer? Implements ILoop.SetArea
    Friend Property SetSequence As Integer? Implements ILoop.SetSequence

    'These are the standard positions for loops.
    Friend Property SetTable As Integer
    Friend Property SetPosition As Integer

    Private mLoop As String
    Public Property LoopID As String
        Get
            Return If(mLoop, String.Empty)
        End Get
        Friend Set(value As String)
            mLoop = value
        End Set
    End Property

    ''' <summary>
    ''' Reads the current loop from the supplied ReaderArgs object.
    ''' </summary>
    ''' <param name="args">An object that facilitates reading the transaction set.</param>
    Friend MustOverride Function ReadAsync(args As ReaderArgs) As Task

    ''' <summary>
    ''' Compares the given instance to the set of allowed options.
    ''' </summary>
    ''' <param name="instance">The specific expression to find in the set of allowed options.</param>
    ''' <param name="allowedOptions">A semicolon separated list of strings, with a leading and trailing semicolon to simplify the comparison.</param>
    ''' <returns>True, if the instance is in the set of allowed options, or the set of allowed options is empty. False otherwise.</returns>
    Protected Shared Function CompareKey(instance As String, allowedOptions As String) As Boolean
        If allowedOptions Is Nothing OrElse allowedOptions.Length = 0 Then
            Return True ' Just accept it as the allowed options is missing
        ElseIf instance Is Nothing OrElse instance.Length = 0 Then
            Return True
        Else
            Dim i = allowedOptions.IndexOf(instance, StringComparison.OrdinalIgnoreCase)

            Return i > 0 AndAlso i < allowedOptions.Length - 1 AndAlso allowedOptions(i - 1) = ";"c AndAlso allowedOptions(i + instance.Length) = ";"c
        End If
    End Function
End Class

Public Interface ILoop
    Inherits ITransactionSetItem

    Property SetArea As Integer?
    Property SetSequence As Integer?

End Interface