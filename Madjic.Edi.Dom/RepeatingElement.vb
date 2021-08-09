Public MustInherit Class RepeatingElement(Of T)
    Inherits ElementBase
    Implements ICollection(Of T), IList(Of T)

    Private ReadOnly mList As New List(Of T)

    Private _MaximumRepetitions As Integer
    Public Property MaximumRepetitions As Integer
        Get
            Return _MaximumRepetitions
        End Get
        Protected Set(value As Integer)
            _MaximumRepetitions = value
        End Set
    End Property

    Public Sub Add(item As T) Implements ICollection(Of T).Add
        mList.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of T).Clear
        mList.Clear()
    End Sub

    Public Function Contains(item As T) As Boolean Implements ICollection(Of T).Contains
        Return mList.Contains(item)
    End Function

    Public Sub CopyTo(array() As T, arrayIndex As Integer) Implements ICollection(Of T).CopyTo
        mList.CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count As Integer Implements ICollection(Of T).Count
        Get
            Return mList.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of T).IsReadOnly
        Get
            Return False
        End Get
    End Property

    Public Function Remove(item As T) As Boolean Implements ICollection(Of T).Remove
        Return mList.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of T) Implements IEnumerable(Of T).GetEnumerator
        Return mList.GetEnumerator
    End Function

    Private Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return mList.GetEnumerator
    End Function

    Friend MustOverride Sub AddFromReader(fullElement As String, reader As EdiReader.SegmentReader)
    'Dim Values = fullElement.Split(reader.RepeatingElementSeparator)

    '    For Each value In Values
    '        Dim r As T

    '        If value.Length > 0 Then
    '            r = populator.Invoke(value, reader)

    '            If r IsNot Nothing Then
    '                Add(r)
    '            End If
    '        End If
    '    Next
    'End Sub

    Friend Delegate Function FromReader(text As String, reader As EdiReader.SegmentReader) As T

    Public Function IndexOf(item As T) As Integer Implements IList(Of T).IndexOf
        Return mList.IndexOf(item)
    End Function

    Public Sub Insert(index As Integer, item As T) Implements IList(Of T).Insert
        mList.Insert(index, item)
    End Sub

    Default Public Overloads Property Item(index As Integer) As T Implements IList(Of T).Item
        Get
            Return mList(index)
        End Get
        Set(value As T)
            mList(index) = value
        End Set
    End Property

    Public Sub RemoveAt(index As Integer) Implements IList(Of T).RemoveAt
        mList.RemoveAt(index)
    End Sub

    Public Overrides Property HasValue As Boolean
        Get
            Return mList.Count > 0
        End Get
        Protected Set(value As Boolean)
            Throw New NotSupportedException("Cannot set HasValue on a repeating element. Use Clear instead.")
        End Set
    End Property
End Class
