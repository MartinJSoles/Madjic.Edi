''' <summary>
''' Represents an identifier data element type.
''' </summary>
''' <remarks></remarks>
Friend Class IdentifierElement
    Inherits StringElement

    Public ReadOnly Property Codelist As String

    Public ReadOnly Property AllowedValues As String

    Public Sub New(minimumLength As Integer, maximumLength As Integer, codelist As String, allowedValues As String)
        MyBase.New(minimumLength, maximumLength)

        'If codelist Is Nothing Then
        '    Throw New ArgumentNullException("codelist")
        'End If

        Me.Codelist = codelist
        Me.AllowedValues = allowedValues.ToUpperInvariant()
    End Sub

    Public Overrides Sub ValidateElement(results As ValidationResults)
        MyBase.ValidateElement(results)

        Dim e As New ValidationFailureResult With {.Source = Me}

        If Value Is Nothing Then
            e.Errors.Add("The identifier does not have any value.")
        ElseIf AllowedValues IsNot Nothing AndAlso AllowedValues.Length > 0 AndAlso Not CompareKey(EdiValueAsUpper, AllowedValues) Then
            e.Errors.Add(String.Format("The value specified, {0}, is not in the list of allowed items.", Value))
        End If

        If e.Errors.Count > 0 Then
            results.Failures.Add(e)
        End If
    End Sub

    Private Shared Function CompareKey(ByVal instance As String, ByVal definition As String) As Boolean
        If instance Is Nothing OrElse definition Is Nothing OrElse instance.Length = 0 OrElse definition.Length = 0 Then
            Return False
        End If

        Dim i As Integer
        Dim j As Integer = instance.IndexOf(","c)

        i = definition.IndexOf(instance)

        If i > -1 AndAlso j < 0 Then
            j = definition.IndexOf(","c, i)
            If j > -1 Then
                Return ((j - i) = instance.Length)
            Else
                Return definition.Length - i = instance.Length
            End If
        Else
            Return False
        End If
    End Function
End Class

