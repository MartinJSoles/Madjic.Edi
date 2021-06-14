''' <summary>
''' Acts as a base class for syntax rules.
''' </summary>
''' <remarks></remarks>
Friend MustInherit Class SyntaxRule

    Protected Sub New(fields As IEnumerable(Of Integer))
        mFields.AddRange(fields)
    End Sub

    Protected Sub New()

    End Sub

    Private ReadOnly mFields As New List(Of Integer)
    ''' <summary>
    ''' Gets a list of fields that participate in the syntax rule.
    ''' </summary>
    Protected ReadOnly Property Fields As List(Of Integer)
        Get
            Return mFields
        End Get
    End Property

    ''' <summary>
    ''' Determines if the item to be checked passes the syntax rule.
    ''' </summary>
    ''' <param name="itemToCheck">The item to check, must be a list of elements.</param>
    ''' <returns>True, if the rule is satisfied.</returns>
    Public MustOverride Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
End Class

''' <summary>
''' Indicates a rule where if one field is present, all identified fields must be present.
''' </summary>
Friend Class SyntaxRulePaired
    Inherits SyntaxRule

    Public Sub New(dependantFields As IEnumerable(Of Integer))
        MyBase.New(dependantFields)
    End Sub

    Public ReadOnly Property DependantFields As IEnumerable(Of Integer)
        Get
            Return Fields
        End Get
    End Property

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        For Each item In Fields
            Dim q = item - 1

            If itemToCheck.Count < item Then
                Return False 'The field is not at the end
            ElseIf itemToCheck(q) Is Nothing Then
                Return False 'The element isn't present in the array.
            ElseIf Not itemToCheck(q).HasValue Then
                Return False
            End If
        Next

        Return True
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("P"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function
End Class

''' <summary>
''' Indicates a syntax rule where at least one field must be present.
''' </summary>
Friend Class SyntaxRuleRequired
    Inherits SyntaxRule

    Public Sub New(dependantFields As IEnumerable(Of Integer))
        MyBase.New(dependantFields)
    End Sub

    Public ReadOnly Property DependantFields As IEnumerable(Of Integer)
        Get
            Return Fields
        End Get
    End Property

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        For Each item In Fields

            Dim q = item - 1

            If itemToCheck.Count >= item AndAlso itemToCheck(q) IsNot Nothing AndAlso itemToCheck(q).HasValue Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("R"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function
End Class

''' <summary>
''' Indicates a syntax rule where at most one field can be present.
''' </summary>
Friend Class SyntaxRuleExclusion
    Inherits SyntaxRule

    Public Sub New(dependantFields As IEnumerable(Of Integer))
        MyBase.New(dependantFields)
    End Sub

    Public ReadOnly Property DependantFields As IEnumerable(Of Integer)
        Get
            Return Fields
        End Get
    End Property

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        Dim Count As Integer = 0

        For Each item In Fields
            Dim q = item - 1

            If itemToCheck.Count >= item AndAlso itemToCheck(q) IsNot Nothing AndAlso itemToCheck(q).HasValue Then
                Count += 1
            End If
        Next

        Return Count < 2
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("E"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function
End Class

''' <summary>
''' Indicates a syntax rule where if the first element is present, then all other fields must also be present.
''' </summary>
Friend Class SyntaxRuleConditional
    Inherits SyntaxRule

    Public Sub New(primaryField As Integer, dependantFields As IEnumerable(Of Integer))
        MyBase.New()
        Fields.Add(primaryField)
        Fields.AddRange(dependantFields)
    End Sub

    Public ReadOnly Property PrimaryField As Integer
        Get
            Return Fields(0)
        End Get
    End Property

    Public ReadOnly Property DependantFields As IEnumerable(Of Integer)
        Get
            Dim rv As New List(Of Integer)

            For i = 1 To Fields.Count - 1
                rv.Add(Fields(i))
            Next

            Return rv
        End Get
    End Property

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        If itemToCheck.Count > Fields(0) AndAlso itemToCheck(Fields(0) - 1) IsNot Nothing Then
            For i = 1 To Fields.Count - 1
                If itemToCheck.Count < Fields(i) OrElse itemToCheck(Fields(i) - 1) Is Nothing OrElse Not itemToCheck(Fields(i) - 1).HasValue Then
                    Return False
                End If
            Next

            Return True
        Else
            Return True
        End If
    End Function

    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("C"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function

End Class

''' <summary>
''' Indicates a syntax rule where if the first element is present, then at least one of the remaining elements must be present.
''' </summary>
Friend Class SyntaxRuleListConditional
    Inherits SyntaxRule

    Public Sub New(primaryField As Integer, dependantFields As IEnumerable(Of Integer))
        MyBase.New()
        Fields.Add(primaryField)
        Fields.AddRange(dependantFields)
    End Sub

    Public ReadOnly Property PrimaryField As Integer
        Get
            Return Fields(0)
        End Get
    End Property

    Public ReadOnly Property DependantFields As IEnumerable(Of Integer)
        Get
            Dim rv As New List(Of Integer)

            For i = 1 To Fields.Count - 1
                rv.Add(Fields(i))
            Next

            Return rv
        End Get
    End Property

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        If itemToCheck.Count > Fields(0) AndAlso itemToCheck(Fields(0) - 1) IsNot Nothing Then
            For i = 1 To Fields.Count - 1
                If itemToCheck.Count >= Fields(i) AndAlso itemToCheck(Fields(i) - 1) IsNot Nothing AndAlso itemToCheck(Fields(i) - 1).HasValue Then
                    Return True
                End If
            Next

            Return False
        Else
            Return True
        End If
    End Function
    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("L"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function

End Class

''' <summary>
''' Indicates a syntax rule where all elements must be present.
''' </summary>
''' <remarks>This is not an ASC X12 syntax rule. This is a custom implementation to handle the "mandatory" or "required" rule on an element.</remarks>
Friend Class SyntaxRuleAllRequired
    Inherits SyntaxRule

    Public Sub New(requiredFields As IEnumerable(Of Integer))
        MyBase.New(requiredFields)
    End Sub

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        For Each index In Fields
            If itemToCheck.Count >= index Then
                If itemToCheck(index - 1) Is Nothing OrElse Not itemToCheck(index - 1).HasValue Then
                    Return False
                End If
            End If
        Next

        Return True
    End Function
    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("M"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function

End Class

''' <summary>
''' Indicates a syntax rule where no element can be present.
''' </summary>
''' <remarks>This is not an ASC X12 syntax rule. This is a custom implementation to handle the "Not Used" rule on an element.</remarks>
Friend Class SyntaxRuleAllNotUsed
    Inherits SyntaxRule

    Public Sub New(fieldsThatMustNotBeUsed As IEnumerable(Of Integer))
        MyBase.New(fieldsThatMustNotBeUsed)
    End Sub

    Public Overrides Function ValidateRule(itemToCheck As List(Of ElementBase)) As Boolean
        For Each index In Fields
            If itemToCheck.Count >= index Then
                If itemToCheck(index - 1) IsNot Nothing AndAlso itemToCheck(index - 1).HasValue Then
                    Return False
                End If
            End If
        Next

        Return True
    End Function
    Public Overrides Function ToString() As String
        Dim sb As New Text.StringBuilder

        sb.Append("N"c)
        For Each item In Fields
            sb.Append(item.ToString("D2"))
        Next

        Return sb.ToString
    End Function

End Class