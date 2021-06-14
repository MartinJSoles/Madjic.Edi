Friend Class TimeElement
    Inherits SimpleElement

    Private mValue As TimeSpan?
    Public Property Value As TimeSpan?
        Get
            Return mValue
        End Get
        Set(value As TimeSpan?)
            mValue = value
            EdiValue = Nothing
            HasValue = value.HasValue
        End Set
    End Property

    Public Sub New(minimumLength As Integer, maximumLength As Integer)
        MyBase.New(minimumLength, maximumLength)
    End Sub

    Public Sub New(maximumLength As Integer)
        Me.New(4, maximumLength)
    End Sub

    Public Overrides Function ToString() As String
        If Value.HasValue Then
            If EdiValue Is Nothing OrElse EdiValue.Length = 0 Then
                If MaximumLength = 4 Then
                    EdiValue = Value.Value.ToString("hhmm")
                ElseIf MaximumLength = 6 OrElse (Value.Value.Milliseconds = 0 AndAlso MinimumLength < 7) Then
                    EdiValue = Value.Value.ToString("hhmmss")
                ElseIf MaximumLength > 6 AndAlso (Value.Value.Milliseconds > 0 OrElse MinimumLength > 6) Then
                    EdiValue = Value.Value.ToString("hhmmss") & Value.Value.Milliseconds.ToString("D4").Substring(0, MaximumLength - 6)
                Else
                    Throw New ArgumentOutOfRangeException("MaximumLength", "The maximum length of a time structure should be 4, 6, or greater.")
                End If
            End If
        End If

        Return EdiValue
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Return writer.WriteAsync(Me.ToString)
    End Function
End Class
