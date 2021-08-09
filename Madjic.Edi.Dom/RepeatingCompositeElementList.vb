Friend Class RepeatingCompositeElementList(Of T As {ICompositeElement})
    Inherits RepeatingElement(Of T)

    Friend Sub New(maximumRepetitions As Integer, populator As Func(Of T))
        MyBase.New()
        Me.MaximumRepetitions = maximumRepetitions
        Me._Populator = populator
    End Sub

    Private _Populator As Func(Of T)

    Friend Overrides Sub AddFromReader(fullElement As String, reader As EdiReader.SegmentReader)
        If String.IsNullOrEmpty(fullElement) Then
            Exit Sub
        End If

        Dim Values = fullElement.Split(reader.RepeatingElementSeparator)

        For Each value In Values
            If Not String.IsNullOrEmpty(value) Then
                Dim p = _Populator.Invoke()
                Dim c As CompositeElement = TryCast(p, CompositeElement)

                c.Read(value, reader)
                Add(p)
            End If
        Next
    End Sub

    Friend Overrides Async Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Dim WrittenCount As Integer

        For Each I In Me
            Dim elm = TryCast(I, CompositeElement)

            If elm.HasValue Then
                If WrittenCount > 0 Then
                    Await writer.WriteAsync(envelope.RepetitionSeparator)
                End If

                Await elm.WriteAsync(writer, envelope)
                WrittenCount += 1

                If WrittenCount = MaximumRepetitions Then
                    Exit For
                End If
            End If
        Next
    End Function

    Public Overrides Sub ValidateElement(results As ValidationResults)
        MyBase.ValidateElement(results)
    End Sub

    Public Overrides Property HasValue As Boolean
        Get
            If Count = 0 Then
                Return False
            End If

            For Each obj In Me
                If obj.HasValue Then
                    Return True
                End If
            Next

            Return False
        End Get
        Protected Set(value As Boolean)
            MyBase.HasValue = value 'Will throw an exception
        End Set
    End Property
End Class
