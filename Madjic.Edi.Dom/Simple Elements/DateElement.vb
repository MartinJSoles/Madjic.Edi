''' <summary>
''' Represents a date using EDI formatting rules.
''' </summary>
Friend Class DateElement
    Inherits SimpleElement

    Public Sub New(minimumLength As Integer, maximumLength As Integer)
        MyBase.New(minimumLength, maximumLength)

        mUseCentury = maximumLength > 6
    End Sub

    Private ReadOnly mUseCentury As Boolean

    Private mValue As Date?
    Public Property Value As Date?
        Get
            Return mValue
        End Get
        Set(value As Date?)
            mValue = value
            EdiValue = Nothing

            MyBase.HasValue = value.HasValue
        End Set
    End Property

    Friend Sub FromString(value As String)
        Me.Value = value.ToDate()
    End Sub

    Private Sub SetAsDate(value As Date, digitCount As Integer)
        If digitCount = 8 Then
            EdiValue = value.ToString("yyyyMMdd")
            HasValue = True
        ElseIf digitCount = 6 Then
            EdiValue = value.ToString("yyMMdd")
            HasValue = True
        Else
            Throw New ArgumentOutOfRangeException(NameOf(digitCount), "The parameter must be 6 or 8.")
        End If
    End Sub

    Public Overrides Function ToString() As String
        If mValue.HasValue Then
            If EdiValue Is Nothing Then
                SetAsDate(mValue.Value, If(mUseCentury, 8, 6))
            End If

            Return EdiValue
        Else
            Return String.Empty
        End If
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Return writer.WriteAsync(Me.ToString)
    End Function
End Class
