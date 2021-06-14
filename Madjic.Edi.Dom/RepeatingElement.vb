Public Class RepeatingElement(Of T As ElementBase)
    Inherits ElementBase
    Implements ICollection(Of T), IList(Of T)

    Private ReadOnly mList As New List(Of T)

    Public Sub New()

    End Sub

    Public Sub New(maximumRepetitions As Integer)
        Me.MaximumRepetitions = maximumRepetitions
    End Sub

    Public ReadOnly Property MaximumRepetitions As Integer

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

    Friend Overrides Async Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Dim WriteCount As Integer

        For Each node In mList
            If node.HasValue Then
                If WriteCount > 0 Then
                    Await writer.WriteAsync(envelope.RepetitionSeparator).ConfigureAwait(False)
                End If

                WriteCount += 1

                Await node.WriteAsync(writer, envelope).ConfigureAwait(False)

                If MaximumRepetitions > 0 AndAlso WriteCount = MaximumRepetitions Then
                    Exit For
                End If
            End If
        Next
    End Function

    Public Overrides Sub ValidateElement(results As ValidationResults)
        If MaximumRepetitions > 0 Then
            Dim WriteCount As Integer

            For Each node In mList
                If node.HasValue Then
                    WriteCount += 1
                End If
            Next

            If MaximumRepetitions < WriteCount Then
                Dim e As New ValidationFailureResult With {.Source = Me}

                e.Errors.Add("There are more elements than allowed by the MaximumRepetition property.")

                results.Failures.Add(e)
            End If
        End If
    End Sub

    Public Overrides Property HasValue As Boolean
        Get
            For Each node In mList
                If node.HasValue Then
                    Return True
                End If
            Next

            Return False
        End Get
        Protected Set(value As Boolean)
            MyBase.HasValue = value
        End Set
    End Property

    Friend Sub AddFromReader(fullElement As String, reader As EdiReader.SegmentReader, populator As FromReader)
        Dim Values = fullElement.Split(reader.RepeatingElementSeparator)

        For Each value In Values
            Dim r As T

            If value.Length > 0 Then
                r = populator.Invoke(value, reader)

                If r IsNot Nothing Then
                    Add(r)
                End If
            End If
        Next
    End Sub

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
End Class
