Namespace DataElements.Composite
    Public Class RepeatingC056List
        Inherits ElementBase
        Implements IList(Of C056), ICollection(Of C056)

        Private Container As RepeatingCompositeElementList(Of C056_Obj)
        Public ReadOnly Property MaximumRepetitions As Integer

        Friend Sub New(container As RepeatingCompositeElementList(Of C056_Obj))
            MyBase.New()

            Me.Container = container
            Me.MaximumRepetitions = container.MaximumRepetitions
        End Sub

        Default Public Property Item(index As Integer) As C056 Implements IList(Of C056).Item
            Get
                Return Container.Item(index)
            End Get
            Set(value As C056)
                Container.Item(index) = value
            End Set
        End Property

        Public ReadOnly Property Count As Integer Implements ICollection(Of C056).Count
            Get
                Return Container.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of C056).IsReadOnly
            Get
                Return Container.IsReadOnly
            End Get
        End Property

        Public Sub Insert(index As Integer, item As C056) Implements IList(Of C056).Insert
            Container.Insert(index, item)
        End Sub

        Public Sub RemoveAt(index As Integer) Implements IList(Of C056).RemoveAt
            Container.RemoveAt(index)
        End Sub

        Public Sub Add(item As C056) Implements ICollection(Of C056).Add
            Container.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of C056).Clear
            Container.Clear()
        End Sub

        Public Sub CopyTo(array() As C056, arrayIndex As Integer) Implements ICollection(Of C056).CopyTo
            Container.CopyTo(array, arrayIndex)
        End Sub

        Public Function IndexOf(item As C056) As Integer Implements IList(Of C056).IndexOf
            Return Container.IndexOf(item)
        End Function

        Public Function Contains(item As C056) As Boolean Implements ICollection(Of C056).Contains
            Return Container.Contains(item)
        End Function

        Public Function Remove(item As C056) As Boolean Implements ICollection(Of C056).Remove
            Return Container.Remove(item)
        End Function

        Public Function GetEnumerator() As IEnumerator(Of C056) Implements IEnumerable(Of C056).GetEnumerator
            Return Container.GetEnumerator
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return Container.GetEnumerator
        End Function

        Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
            Return Container.WriteAsync(writer, envelope)
        End Function
    End Class

End Namespace