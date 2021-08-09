Namespace DataElements.Composite
    Public Class RepeatingC998List
        Inherits ElementBase
        Implements IList(Of C998), ICollection(Of C998)

        Private Container As RepeatingCompositeElementList(Of C998_Obj)

        Friend Sub New(container As RepeatingCompositeElementList(Of C998_Obj))
            MyBase.New()

            Me.Container = container
            Me.MaximumRepetitions = container.MaximumRepetitions
        End Sub


        Public ReadOnly MaximumRepetitions As Integer

        Default Public Property Item(index As Integer) As C998 Implements IList(Of C998).Item
            Get
                Return Container.Item(index)
            End Get
            Set(value As C998)
                Container(index) = value
            End Set
        End Property

        Public ReadOnly Property Count As Integer Implements ICollection(Of C998).Count
            Get
                Return Container.Count
            End Get
        End Property

        Public ReadOnly Property IsReadOnly As Boolean Implements ICollection(Of C998).IsReadOnly
            Get
                Return Container.IsReadOnly
            End Get
        End Property

        Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
            Return Container.WriteAsync(writer, envelope)
        End Function

        Public Function IndexOf(item As C998) As Integer Implements IList(Of C998).IndexOf
            Return Container.IndexOf(item)
        End Function

        Public Sub Insert(index As Integer, item As C998) Implements IList(Of C998).Insert
            Container.Insert(index, item)
        End Sub

        Public Sub RemoveAt(index As Integer) Implements IList(Of C998).RemoveAt
            Container.RemoveAt(index)
        End Sub

        Public Sub Add(item As C998) Implements ICollection(Of C998).Add
            Container.Add(item)
        End Sub

        Public Sub Clear() Implements ICollection(Of C998).Clear
            Container.Clear()
        End Sub

        Public Function Contains(item As C998) As Boolean Implements ICollection(Of C998).Contains
            Return Container.Contains(item)
        End Function

        Public Sub CopyTo(array() As C998, arrayIndex As Integer) Implements ICollection(Of C998).CopyTo
            Container.CopyTo(array, arrayIndex)
        End Sub

        Public Function Remove(item As C998) As Boolean Implements ICollection(Of C998).Remove
            Return Container.Remove(item)
        End Function

        Public Function GetEnumerator() As IEnumerator(Of C998) Implements IEnumerable(Of C998).GetEnumerator
            Return Container.GetEnumerator
        End Function

        Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return Container.GetEnumerator
        End Function
    End Class

End Namespace