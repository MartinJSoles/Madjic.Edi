''' <summary>
''' Provides a raw segment that can be used by the Reader classes.
''' </summary>
''' <remarks>This class is not exposed outside of the reader methods.</remarks>
<DebuggerDisplay("{DebuggerText}")>
Friend Class GenericSegment
    Inherits Segment

    Public Sub New(id As String)
        MyBase.New(id)
    End Sub

    Friend Function ToTimeSpanValue(index As Integer) As TimeSpan?
        Return ToStringValue(index).ToTimeSpan
    End Function

    Friend Function ToDateValue(index As Integer) As Date?
        Return ToStringValue(index).ToDate
    End Function

    Friend Function ToFloatValue(index As Integer) As Decimal?
        Return ToStringValue(index).ToFloat
    End Function

    Friend Function ToDecimalValue(index As Integer, impliedDecimalPoint As Integer) As Decimal?
        Return ToStringValue(index).ToDecimal(impliedDecimalPoint)
    End Function

    Friend Function ToIntegerValue(index As Integer) As Integer?
        Return ToStringValue(index).ToInteger
    End Function

    Friend Function ToStringValue(index As Integer) As String
        If Elements.Count > index Then
            Return CType(Elements(index), StringElement).Value
        Else
            Return Nothing
        End If
    End Function

    Friend Function ToStringValue(index As Integer, subIndex As Integer, separator As Char) As String
        Dim s = ToStringValue(index)

        If s IsNot Nothing Then
            Dim children = s.Split(separator)

            If children.Length > subIndex Then
                Return children(subIndex)
            End If
        End If

        Return Nothing
    End Function

    Private Function DebuggerText() As String
        Dim sb As New Text.StringBuilder()

        sb.Append(SegmentID)

        For Each element As StringElement In Elements
            sb.Append("*"c)
            sb.Append(element.Value)
        Next

        sb.Append("~"c)

        Return sb.ToString
    End Function
End Class
