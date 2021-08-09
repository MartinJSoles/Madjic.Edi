Imports Madjic.Edi.Dom.EdiReader

Public Class RepeatingSimpleElementList
    Inherits RepeatingElement(Of String)

    Friend Sub New(actualElement As StringElement, maximumRepetitions As Integer)
        MyBase.New()

        Me.MaximumRepetitions = maximumRepetitions
        _ActualElement = actualElement
    End Sub

    Private _ActualElement As StringElement

    Friend Overrides Async Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        If Count > 0 Then
            Dim WrittenCount As Integer

            For Each elm In Me
                If Not String.IsNullOrEmpty(elm) Then
                    If WrittenCount > 0 Then
                        Await writer.WriteAsync(envelope.RepetitionSeparator)
                    End If

                    Await writer.WriteAsync(elm)
                    WrittenCount += 1

                    If WrittenCount = MaximumRepetitions Then
                        Exit For
                    End If
                End If
            Next
        End If
    End Function

    Public Overrides Sub ValidateElement(results As ValidationResults)
        Dim e As New ValidationFailureResult() With {.Source = Me}

        Dim FilledCount = Aggregate c In Me Where Not String.IsNullOrEmpty(c) Into Count

        If MaximumRepetitions < FilledCount Then
            e.Errors.Add($"The repeating element container allows a maximum of {MaximumRepetitions} repetitions; current non trivial count is {FilledCount}")
        End If

        Dim TempResults As New ValidationResults()
        Dim Position As Integer
        Dim sb As Text.StringBuilder = Nothing

        For Each elm In Me
            Position += 1
            _ActualElement.Value = elm
            _ActualElement.ValidateElement(TempResults)

            If TempResults.HasErrors Then
                If sb Is Nothing Then
                    sb = New Text.StringBuilder
                Else
                    sb.Clear()
                End If

                sb.Append("Repetition ")
                sb.Append(Position)

                Dim SubErrors = TempResults.Failures.First.Errors

                If SubErrors.Count = 1 Then
                    sb.Append(" has an error: ")
                    sb.Append(SubErrors.First)
                Else
                    sb.Append(" has ")
                    sb.Append(SubErrors.Count)
                    sb.Append(" errors: ")

                    For subindex = 0 To SubErrors.Count - 1
                        If subindex > 0 Then
                            sb.Append("; ")
                        End If

                        sb.Append(SubErrors(subindex))
                    Next
                End If

                e.Errors.Append(sb.ToString)

                TempResults.Reset()
            End If
        Next
    End Sub

    Friend Overrides Sub AddFromReader(fullElement As String, reader As SegmentReader)
        Dim Values = fullElement.Split(reader.RepeatingElementSeparator)

        For Each value In Values
            If value.Length > 0 Then
                Add(value)
            End If
        Next
    End Sub
End Class
