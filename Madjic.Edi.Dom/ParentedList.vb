
''' <summary>
''' Enables an object to identify the parent it belongs to.
''' </summary>
''' <remarks>This interface is used exclusively by the <see cref="ParentedList">ParentedList</see> class.</remarks>
Friend Interface IParanted
    ''' <summary>
    ''' Gets/sets the parent object for this instance.
    ''' </summary>
    ''' <remarks>An object may only have one parent.</remarks>
    Property Parent As IParanted
End Interface

''' <summary>
''' A list of IParented objects.
''' </summary>
''' <remarks></remarks>
Friend Class ParentedList(Of tChild As IParanted, tParent As IParanted)
    Implements IList(Of tChild), ICollection(Of tChild)

    Public ReadOnly Property Parent As tParent

    Public Sub New(parent As tParent)
        Me.Parent = parent
    End Sub

    Private ReadOnly mList As New List(Of tChild)

    Public Sub Add(item As tChild) Implements ICollection(Of tChild).Add
        item.Parent = Parent
        mList.Add(item)
    End Sub

    Public Sub Clear() Implements ICollection(Of tChild).Clear
        mList.Clear()
    End Sub

    Public Function Contains(item As tChild) As Boolean Implements ICollection(Of tChild).Contains
        Return mList.Contains(item)
    End Function

    Public Sub CopyTo(array() As tChild, arrayIndex As Integer) Implements ICollection(Of tChild).CopyTo
        mList.CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count As Integer Implements ICollection(Of tChild).Count
        Get
            Return mList.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of tChild).IsReadOnly
        Get
            Return False
        End Get
    End Property

    Public Function Remove(item As tChild) As Boolean Implements ICollection(Of tChild).Remove
        Return mList.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of tChild) Implements IEnumerable(Of tChild).GetEnumerator
        Return mList.GetEnumerator
    End Function

    Public Function IndexOf(item As tChild) As Integer Implements IList(Of tChild).IndexOf
        Return mList.IndexOf(item)
    End Function

    Public Sub Insert(index As Integer, item As tChild) Implements IList(Of tChild).Insert
        item.Parent = Parent
        mList.Insert(index, item)
    End Sub

    Default Public Property Item(index As Integer) As tChild Implements IList(Of tChild).Item
        Get
            Return mList.Item(index)
        End Get
        Set(value As tChild)
            value.Parent = Parent
            mList.Item(index) = value
        End Set
    End Property

    Public Sub RemoveAt(index As Integer) Implements IList(Of tChild).RemoveAt
        mList.RemoveAt(index)
    End Sub

    Public Function GetEnumerator1() As IEnumerator Implements IEnumerable.GetEnumerator
        Return mList.GetEnumerator
    End Function
End Class
