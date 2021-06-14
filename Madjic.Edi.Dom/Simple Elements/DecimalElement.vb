''' <summary>
''' Identifies a floating decimal number.
''' </summary>
Friend Class DecimalElement
    Inherits SimpleElement

    Private mValue As Decimal?
    Public Property Value As Decimal?
        Get
            Return mValue
        End Get
        Set(value As Decimal?)
            mValue = value
            HasValue = mValue.HasValue
        End Set
    End Property

    Public Sub New(minimumLength As Integer, maximumLength As Integer)
        MyBase.New(minimumLength, maximumLength)
    End Sub

    Friend Sub FromString(value As String)
        Me.Value = value.ToFloat
    End Sub

    Public Overrides Function ToString() As String
        If HasValue Then
            Dim tmp As New Text.StringBuilder

            If Value.HasValue Then
                tmp.Append(Value.Value) 'Use standard formatting
                'Strip off any leading zero characters

                While tmp.Length > 0 AndAlso tmp.Chars(0) = "0"c
                    tmp.Remove(0, 1)
                End While
            End If

            If tmp.Length > MaximumLength Then
                Throw New ArgumentOutOfRangeException("Value", "The specified value will not fit within the bounds defined.")
            End If

            If tmp.Length < MinimumLength Then
                Dim InsertAt = If(Value < 0, 1, 0)
                While tmp.Length < MinimumLength
                    tmp.Insert(InsertAt, "0"c)
                End While
            End If

            Return tmp.ToString
        Else
            Return Nothing
        End If
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Return writer.WriteAsync(Me.ToString)
    End Function
End Class
