Imports System.Runtime.CompilerServices

Friend Module HelperRoutines



    ''' <summary>
    ''' Ensures the original string is within the bounds specified.
    ''' </summary>
    ''' <param name="orig">The string to ensure is within limits.</param>
    ''' <param name="minLength">The minimum length of the string.</param>
    ''' <param name="maxLength">The maximum length of the string.</param>
    ''' <returns>The original string if within bounds, padded with spaces on the right if smaller than minLength, truncated to maxLength if larger.</returns>
    ''' <remarks></remarks>
    Friend Function BoundedString(ByVal orig As String, ByVal minLength As Integer, ByVal maxLength As Integer) As String
        If orig Is Nothing Then
            Return " ".PadRight(minLength)
        End If

        If orig.Length < minLength Then
            Return orig.PadRight(minLength)
        End If

        If orig.Length > maxLength Then
            Return orig.Substring(0, maxLength)
        End If

        Return orig
    End Function

    <Extension>
    Friend Function AsDateElement(src As ElementBase) As DateElement
        Return CType(src, DateElement)
    End Function

    <Extension>
    Friend Function AsNumericElement(src As ElementBase) As NumericElement
        Return CType(src, NumericElement)
    End Function

    <Extension>
    Friend Function AsIdentifierElement(src As ElementBase) As IdentifierElement
        Return CType(src, IdentifierElement)
    End Function

    <Extension>
    Friend Function AsDecimalElement(src As ElementBase) As DecimalElement
        Return CType(src, DecimalElement)
    End Function

    <Extension>
    Friend Function AsStringElement(src As ElementBase) As StringElement
        Return CType(src, StringElement)
    End Function

    <Extension>
    Friend Function AsTimeElement(src As ElementBase) As TimeElement
        Return CType(src, TimeElement)
    End Function

    <Extension>
    Friend Function ToTimeSpan(src As String) As TimeSpan?
        Dim Hr As Integer
        Dim Mi As Integer
        Dim Se As Integer
        Dim SubSecond As Integer
        Dim Value As TimeSpan?

        Dim i As Integer

        If Integer.TryParse(src, i) AndAlso i > -1 Then
            If src.Length >= 4 Then

                If src.Length < 8 Then
                    For iterations = src.Length + 1 To 8
                        i *= 10
                    Next
                ElseIf src.Length > 8 Then
                    For iterations = 9 To src.Length
                        i \= 10
                    Next
                End If

                SubSecond = i Mod 100
                i \= 100

                Se = i Mod 100
                i \= 100

                Mi = i Mod 100
                Hr = i \ 100

                Value = New TimeSpan(0, Hr, Mi, Se, SubSecond)
            End If
        End If

        Return Value
    End Function

    ''' <summary>
    ''' Parses the given value as a decimal with an explicit decimal point.
    ''' </summary>
    <Extension>
    Friend Function ToFloat(src As String) As Decimal?
        Dim Value As Decimal?

        Dim i As Decimal

        If src IsNot Nothing AndAlso Decimal.TryParse(src, i) Then
            Value = i
        End If

        Return Value
    End Function

    ''' <summary>
    ''' Parses the given value as a decimal with an implied decimal point.
    ''' </summary>
    ''' <param name="impliedDecimalPoint">The number of implied digits to the right of the decimal point.</param>
    <Extension>
    Friend Function ToDecimal(src As String, impliedDecimalPoint As Integer) As Decimal?
        Dim Value As Decimal?
        Dim i As Decimal

        If src IsNot Nothing AndAlso src.IndexOf(".") < 0 AndAlso Decimal.TryParse(src, i) Then
            While impliedDecimalPoint > 0
                i \= 10
                impliedDecimalPoint -= 1
            End While

            Value = i
        End If

        Return Value
    End Function

    ''' <summary>
    ''' Parses the given value as an integer.
    ''' </summary>
    <Extension>
    Friend Function ToInteger(src As String) As Integer?
        Dim value As Integer?
        Dim i As Integer

        If src IsNot Nothing AndAlso Integer.TryParse(src, i) Then
            value = i
        End If

        Return value
    End Function

    <Extension>
    Friend Function ToDate(src As String) As Date?
        Dim Value As Date?
        Dim i As Integer

        If src IsNot Nothing AndAlso Integer.TryParse(src, i) Then
            Dim Yr As Integer
            Dim Mo As Integer
            Dim Da As Integer

            Da = i Mod 100
            Mo = (i \ 100) Mod 100
            Yr = (i \ 10000)

            If src.Length = 6 Then
                Yr = Globalization.CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(Yr)
            End If

            If Mo > 0 AndAlso Mo < 13 AndAlso Da > 0 AndAlso Da <= Date.DaysInMonth(Yr, Mo) Then

                If src.Length = 6 OrElse src.Length = 8 Then
                    Value = New Date(Yr, Mo, Da)
                End If
            End If
        End If

        Return Value
    End Function

    <Extension>
    Friend Sub AddRange(src As ICollection(Of ITransactionSetItem), items As IEnumerable(Of ITransactionSetItem))
        For Each item In items
            src.Add(item)
        Next
    End Sub

End Module
