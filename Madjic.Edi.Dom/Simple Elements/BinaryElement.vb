Friend Class BinaryElement
    Inherits SimpleElement

    Public Sub New()
        MyBase.New(0, 1)
    End Sub

    Public Sub New(initialValue As Byte())
        Me.New()

        Value = initialValue
    End Sub

    Public Sub New(initialValue As String)
        Me.New()

        If initialValue IsNot Nothing Then
            If initialValue.Length Mod 2 = 0 Then
                Dim temp As New List(Of Byte)

                For i = 0 To initialValue.Length Step 2

                Next
            Else
                Throw New ArgumentOutOfRangeException(NameOf(initialValue), "The string must contain an even number of nibbles.")
            End If
        End If
    End Sub

    Public Property Value As Byte()

    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        If Value IsNot Nothing Then
            For i = 0 To Value.Length - 1
                sb.Append(Value(i).ToString("X2"))
            Next
        End If

        Return sb.ToString
    End Function

    Friend Overrides Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Throw New NotImplementedException
    End Function
End Class
