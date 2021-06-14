''' <summary>
''' Represents a simple string using EDI formatting.
''' </summary>
Friend Class StringElement
    Inherits SimpleElement

    Public Sub New(minimumLength As Integer, maximumLength As Integer)
        MyBase.New(minimumLength, maximumLength)
    End Sub

    Public Property Value As String
        Get
            Return EdiValue
        End Get
        Set(value As String)
            EdiValue = value
            HasValue = value IsNot Nothing AndAlso value.Length > 0
        End Set
    End Property

    Public Overrides Function ToString() As String
        Dim tmp As New Text.StringBuilder

        If Value IsNot Nothing Then
            tmp.Append(Value.Trim)
        End If

        If tmp.Length > MaximumLength Then
            tmp.Length = MaximumLength
        End If

        While tmp.Length < MinimumLength
            tmp.Append(" "c)
        End While

        Return tmp.ToString
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Return writer.WriteAsync(Me.ToString)
    End Function

    Public Overrides Sub ValidateElement(results As ValidationResults)
        MyBase.ValidateElement(results)

        If Value IsNot Nothing Then
            Dim L = Value.Length

            If L < MinimumLength Then
                Dim e As New ValidationFailureResult With {.Source = Me}
                e.Errors.Add($"Value length, {L}, does not meet minimum length requirement of {MinimumLength}.")
                results.Failures.Add(e)
            ElseIf L > MaximumLength Then
                Dim e As New ValidationFailureResult With {.Source = Me}
                e.Errors.Add($"Value length, {L}, does not meet maximum length requirement of {MaximumLength}.")
                results.Failures.Add(e)
            End If
        End If

    End Sub
End Class
