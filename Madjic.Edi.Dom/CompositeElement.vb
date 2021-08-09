Public Interface ICompositeElement
    Property HasValue As Boolean
End Interface

''' <summary>
''' Defines an element with multiple values contained within.
''' </summary>
''' <remarks></remarks>
Friend MustInherit Class CompositeElement
    Inherits ElementBase
    Implements ICompositeElement

    Private ReadOnly mRules2 As New List(Of SyntaxRule)

    Friend ReadOnly Property SubElements As New List(Of ElementBase)

    Friend ReadOnly Property SyntaxRules As New List(Of SyntaxRule)

    Friend Sub SetImplementationRules(rules As IEnumerable(Of SyntaxRule))
        mRules2.Clear()
        mRules2.AddRange(rules)
    End Sub

    Friend MustOverride Sub Read(fullElement As String, reader As EdiReader.SegmentReader)

    Friend Overrides Async Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Dim Last As Integer = -1
        Dim mComp As Char = envelope.ComponentElementSeparator

        For index = 0 To SubElements.Count - 1
            If SubElements(index) IsNot Nothing AndAlso SubElements(index).HasValue Then
                Last = index
            End If
        Next

        For index = 0 To Last
            If SubElements(index) IsNot Nothing Then
                If index > 0 Then
                    Await writer.WriteAsync(mComp).ConfigureAwait(False)
                End If

                If SubElements(index).HasValue Then
                    Await SubElements(index).WriteAsync(writer, envelope).ConfigureAwait(False)
                End If
            End If
        Next
    End Function

    Public Overrides Sub ValidateSubElements(results As ValidationResults)
        Dim E As New ValidationFailureResult With {.Source = Me}
        Dim w As New ValidationWarning With {.Source = Me}

        If SubElements.Count = 0 Then
            E.Errors.Add("The composite data element has no defined sub-elements. Every composite data element is required to contain at least one sub-element.")
        End If

        For Each rule In SyntaxRules
            If Not rule.ValidateRule(SubElements) Then
                E.Errors.Add("Failed validation: " & rule.ToString)
            End If
        Next

        For Each rule In mRules2
            If Not rule.ValidateRule(SubElements) Then
                E.Errors.Add("Failed Implementation validation: " & rule.ToString)
            End If
        Next

        If E.Errors.Count > 0 Then
            results.Failures.Add(E)
        End If

        If w.Warnings.Count > 0 Then
            results.Warnings.Add(w)
        End If

    End Sub

    Public Overrides Property HasValue As Boolean Implements ICompositeElement.HasValue
        Get
            For Each node In SubElements
                If node IsNot Nothing AndAlso node.HasValue Then
                    Return True
                End If
            Next

            Return False
        End Get
        Protected Set(value As Boolean)
            Throw New NotSupportedException("Cannot set HasValue on composite elements. You must either clear individual properties or instantiate a new composite.")
        End Set
    End Property
End Class
