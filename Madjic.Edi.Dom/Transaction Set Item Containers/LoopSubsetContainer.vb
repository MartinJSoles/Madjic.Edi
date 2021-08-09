Public Class LoopSubsetContainer(Of TPublic As ILoop, TStandard As ILoop)
    Implements IList(Of TPublic), ICollection(Of TPublic), ITransactionSetItem, IValidate, IParanted

    Private ReadOnly mRepeat As Integer

    Public Overrides Function ToString() As String
        Return String.Format("LoopSubsetContainer, T: {0}, K: {1}, Area: {2}, Sequence: {3}, Repeat: {4}, Count: {5}, Parent: {6}", GetType(TPublic).ToString, GetType(TStandard).ToString, Area, Sequence, mRepeat, Count, If(Parent?.ToString, "(null)"))
    End Function

    Friend ReadOnly Property Parent As LoopContainer(Of TStandard)

    ''' <summary>
    ''' Gets the area that this loop instance is defined in the implementation.
    ''' </summary>
    Public ReadOnly Property Area As String

    ''' <summary>
    ''' Gets the sequence that this loop instance is defined in the implementation.
    ''' </summary>
    Public ReadOnly Property Sequence As String

    ''' <summary>
    ''' Creates a new instance of the <see cref="LoopSubsetContainer(Of TPublic, TStandard)">LoopSubsetContainer</see> class.
    ''' </summary>
    ''' <param name="parent">The base loop collection this subset is based on.</param>
    ''' <param name="area">The implementation area covered by this collection.</param>
    ''' <param name="sequence">The area sequence covered by this collection.</param>
    ''' <remarks></remarks>
    Friend Sub New(parent As LoopContainer(Of TStandard), repeat As Integer, area As String, sequence As String)
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
    Public Sub Add(item As TPublic) Implements ICollection(Of TPublic).Add
        Dim L = TryCast(item, ILoop)

        If mRepeat > 0 AndAlso Count >= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        If L IsNot Nothing AndAlso TypeOf L Is TStandard Then
            L.SetArea = Area
            L.SetSequence = Sequence

            Parent.Add(L)
        Else
            Throw New InvalidCastException
        End If
    End Sub

    Public Sub AddRange(items As IEnumerable(Of TPublic))
        For Each node In items
            Add(node)
        Next
    End Sub

    ''' <summary>
    ''' Removes all loops from this collection.
    ''' </summary>
    Public Sub Clear() Implements ICollection(Of TPublic).Clear
        For index = Parent.Count - 1 To 0 Step -1
            Dim n = TryCast(Parent(index), ILoop)

            If n IsNot Nothing AndAlso TypeOf n Is TStandard AndAlso String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                Parent.RemoveAt(index)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Indicates whether the given item is contained by this collection.
    ''' </summary>
    Public Function Contains(item As TPublic) As Boolean Implements ICollection(Of TPublic).Contains
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is TStandard AndAlso String.Compare(L.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(L.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
            Return Parent.Contains(L)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Copies all items contained in this collection to the given array, starting at the specified index.
    ''' </summary>
    Public Sub CopyTo(array() As TPublic, arrayIndex As Integer) Implements ICollection(Of TPublic).CopyTo
        For Each node In Parent
            Dim n = TryCast(node, ILoop)

            If n IsNot Nothing AndAlso String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                array(arrayIndex) = n
                arrayIndex += 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' Gets the number of items contained by this collection.
    ''' </summary>
    Public ReadOnly Property Count As Integer Implements ICollection(Of TPublic).Count
        Get
            Return (From c In Parent Where String.Compare(c.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(c.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0).Count
        End Get
    End Property

    Private ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of TPublic).IsReadOnly
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Removes the given item from the collection.
    ''' </summary>
    Public Function Remove(item As TPublic) As Boolean Implements ICollection(Of TPublic).Remove
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is TStandard AndAlso String.Compare(L.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(L.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
            Return Parent.Remove(L)
        Else
            Return False
        End If
    End Function

    Public Function GetEnumerator() As IEnumerator(Of TPublic) Implements IEnumerable(Of TPublic).GetEnumerator
        Return (From c In Parent Where String.Compare(c.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(c.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0).Cast(Of TPublic).GetEnumerator
    End Function

    ''' <summary>
    ''' Gets the index that the given item is at in the collection.
    ''' </summary>
    Public Function IndexOf(item As TPublic) As Integer Implements IList(Of TPublic).IndexOf
        Dim idx As Integer
        Dim L = TryCast(item, ILoop)

        If L IsNot Nothing AndAlso TypeOf L Is TStandard AndAlso String.Compare(L.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(L.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
            For Each node In Parent
                If node.Equals(L) Then
                    Return idx
                End If

                Dim n = TryCast(node, ILoop)

                If String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                    idx += 1
                End If
            Next
        End If

        Return -1
    End Function

    ''' <summary>
    ''' Inserts the given item at the index specified.
    ''' </summary>
    Public Sub Insert(index As Integer, item As TPublic) Implements IList(Of TPublic).Insert
        Dim curt As Integer
        Dim idx As Integer
        Dim L = TryCast(item, ILoop)

        If mRepeat > 0 AndAlso Count >= mRepeat Then
            Throw New IndexOutOfRangeException
        End If

        If L IsNot Nothing AndAlso TypeOf L Is TStandard Then
            L.SetArea = Area
            L.SetSequence = Sequence

            Do While curt < Parent.Count AndAlso idx <= index
                Dim n = TryCast(Parent(curt), ILoop)

                If n IsNot Nothing AndAlso String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
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
    Default Public Property Item(index As Integer) As TPublic Implements IList(Of TPublic).Item
        Get
            Dim idx As Integer

            For Each node In Parent
                Dim n = TryCast(node, ILoop)

                If n IsNot Nothing AndAlso TypeOf n Is TStandard AndAlso String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
                    If index = idx Then
                        n = TryCast(node, ILoop)
                        Return n
                    End If

                    idx += 1
                End If
            Next

            Throw New IndexOutOfRangeException
        End Get
        Set(value As TPublic)
            Dim idx As Integer
            Dim L = TryCast(value, ILoop)

            If L IsNot Nothing AndAlso TypeOf L Is TStandard Then
                For curt = 0 To Parent.Count - 1
                    Dim n = TryCast(Parent(curt), ILoop)

                    If String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
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
    Public Sub RemoveAt(index As Integer) Implements IList(Of TPublic).RemoveAt
        Dim idx As Integer
        For curt = 0 To Parent.Count - 1
            Dim n = TryCast(Parent(curt), LoopBase)

            If n IsNot Nothing AndAlso TypeOf n Is TStandard AndAlso String.Compare(n.SetArea, Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
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

    '    Private Class SubsetEnumerator
    '        Implements IEnumerator(Of T)


    '        Private mParent As LoopSubsetContainer(Of T, K)
    '        Private mCurrent As Integer

    '        Public Sub New(parent As LoopSubsetContainer(Of T, K))
    '            mParent = parent
    '            mCurrent = -1
    '        End Sub

    '        Public ReadOnly Property Current As T Implements IEnumerator(Of T).Current
    '            Get
    '                If mCurrent < 0 Then
    '                    Throw New NotSupportedException
    '                Else
    '                    Return mParent(mCurrent)
    '                End If
    '            End Get
    '        End Property

    '        Private ReadOnly Property Current1 As Object Implements IEnumerator.Current
    '            Get
    '                Return Current
    '            End Get
    '        End Property

    '        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
    '            Do While mCurrent < mParent.Parent.Count - 1
    '                mCurrent += 1

    '                Dim n As LoopBase = TryCast(mParent(mCurrent), LoopBase)

    '                If n IsNot Nothing AndAlso TypeOf n Is K AndAlso String.Compare(n.SetArea, mParent.Area, StringComparison.OrdinalIgnoreCase) = 0 AndAlso String.Compare(n.SetSequence, mParent.Sequence, StringComparison.OrdinalIgnoreCase) = 0 Then
    '                    Exit Do
    '                End If
    '            Loop

    '            Return mCurrent < mParent.Parent.Count
    '        End Function

    '        Public Sub Reset() Implements IEnumerator.Reset
    '            mCurrent = -1
    '        End Sub

    '#Region "IDisposable Support"
    '        Private disposedValue As Boolean ' To detect redundant calls

    '        ' IDisposable
    '        Protected Overridable Sub Dispose(disposing As Boolean)
    '            If Not Me.disposedValue Then
    '                If disposing Then
    '                    mParent = Nothing
    '                End If
    '            End If
    '            Me.disposedValue = True
    '        End Sub

    '        ' This code added by Visual Basic to correctly implement the disposable pattern.
    '        Public Sub Dispose() Implements IDisposable.Dispose
    '            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '            Dispose(True)
    '            GC.SuppressFinalize(Me)
    '        End Sub
    '#End Region

    '    End Class
End Class
