
''' <summary>
''' Represents a number that has an implied number of digits beyond the decimal point.
''' </summary>
''' <remarks></remarks>
Friend Class NumericElement
    Inherits SimpleElement

    ''' <summary>
    ''' Gets the minimum number of digits that must be present in a serialized string value.
    ''' </summary>
    ''' <remarks>This value should always be as large or larger than the ImpliedDecimalDigitCount property.</remarks>
    Public ReadOnly Property MinimumDigitCount As Integer

    ''' <summary>
    ''' Gets the number of digits that are present beyond the implied decimal point.
    ''' </summary>
    ''' <remarks>This should be a positive value between 0 and 9.</remarks>
    Public ReadOnly Property ImpliedDecimalDigitCount As Integer

    Public ReadOnly Property MaximumDigitCount As Integer

    Public Sub New(minimumDigitCount As Integer, impliedDecimalDigitCount As Integer, maximumDigitCount As Integer)
        MyBase.New(minimumDigitCount + If(impliedDecimalDigitCount > 0, 1, 0), maximumDigitCount + If(impliedDecimalDigitCount > 0, 2, 1) + impliedDecimalDigitCount)

        If minimumDigitCount < 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(minimumDigitCount), "The minimum digit count must not be negative.")
        End If

        If impliedDecimalDigitCount < minimumDigitCount Then
            'Throw New ArgumentOutOfRangeException("impliedDecimalDigitCount", "The implied decimal digit count cannot be less than the minimum digit count.")
        End If

        If maximumDigitCount < minimumDigitCount + impliedDecimalDigitCount Then
            Throw New ArgumentOutOfRangeException(NameOf(maximumDigitCount), "The maximum digit count cannot be less than the sum of the minimum and implied digit counts.")
        End If

        Me.MinimumDigitCount = minimumDigitCount
        Me.ImpliedDecimalDigitCount = impliedDecimalDigitCount
        Me.MaximumDigitCount = maximumDigitCount
    End Sub

    Private mValue As Decimal?
    Public Property Value As Decimal?
        Get
            Return mValue
        End Get
        Set(value As Decimal?)
            mValue = value
            EdiValue = Nothing
            HasValue = value.HasValue
        End Set
    End Property

    Friend Sub FromString(value As String)
        Me.Value = value.ToDecimal(ImpliedDecimalDigitCount)
    End Sub

    ''' <summary>
    ''' Convert the given decimal value into an EDI string.
    ''' </summary>
    ''' <param name="value">The value to be converted into an EDI string.</param>
    ''' <param name="impliedDecimalDigits">The number of digits allowed past the decimal point.</param>
    ''' <param name="minimumDigitCount">The minium length of the resulting EDI string, padded to the left with zeroes.</param>
    ''' <remarks></remarks>
    Private Sub SetAsImpliedDecimal(value As Decimal, impliedDecimalDigits As Integer, minimumDigitCount As Integer)
        Dim IsNegative As Boolean = value < 0

        If IsNegative Then
            value = -value
        End If

        Dim Whole = Decimal.Truncate(value)
        Dim Fractional As Decimal
        Dim Temp As New Text.StringBuilder

        Temp.Append(Whole)

        value -= Whole

        While value > 0 AndAlso impliedDecimalDigits > 0
            value *= 10
            Fractional = Decimal.Truncate(value)

            Temp.Append(Fractional)

            value -= Fractional
            impliedDecimalDigits -= 1
        End While

        'If impliedDecimalDigits > 0 Then
        '    Throw New ArgumentOutOfRangeException("value", "The given value has more precision than the implied decimal digits parameter allows.")
        'End If

        While Temp.Length < minimumDigitCount
            Temp.Insert(0, "0"c)
        End While

        If IsNegative Then
            Temp.Insert(0, "-"c)
        End If

        'If Temp.Length > MaximumLength Then
        '    Throw New ArgumentOutOfRangeException("value", "The given value will generate an EDI value that is out of range.")
        'End If

        EdiValue = Temp.ToString
    End Sub

    Public Overrides Function ToString() As String
        If Value.HasValue Then
            If EdiValue Is Nothing Then
                SetAsImpliedDecimal(Value.Value, ImpliedDecimalDigitCount, MinimumDigitCount)
            End If

            Return EdiValue
        Else
            Return String.Empty
        End If
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Return writer.WriteAsync(Me.ToString)
    End Function

    Public Overrides Sub ValidateElement(results As ValidationResults)
        MyBase.ValidateElement(results)
    End Sub
End Class
