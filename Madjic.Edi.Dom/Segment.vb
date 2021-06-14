Public Interface ISegment
    Inherits ITransactionSetItem

    Property SetArea As Integer?
    Property SetSequence As Integer?
End Interface

''' <summary>
''' Defines a segment which contains elements.
''' </summary>
''' <remarks></remarks>
Public MustInherit Class Segment
    Implements ISegment, IValidate, IParanted

    Private ReadOnly mRules2 As New List(Of SyntaxRule)

    ''' <summary>
    ''' Creates a new instance of a segment
    ''' </summary>
    ''' <param name="segmentID">The name of the segment.</param>
    ''' <remarks></remarks>
    Protected Sub New(segmentID As String)
        'Validation: the segment ID should be a 2 or 3 alphanumeric character
        Me.SegmentID = segmentID
    End Sub

    ''' <summary>
    ''' Gets the Segment ID for this object.
    ''' </summary>
    ''' <value>The segment ID for this object.</value>
    ''' <returns>A string representing the ID of the segment.</returns>
    ''' <remarks>The ID is a value such as REF, NM1, or CLM.</remarks>
    Public ReadOnly Property SegmentID As String

    ''' <summary>
    ''' Gets a List of objects derived from ElementBase for this segment.
    ''' </summary>
    ''' <value>A List of objects derived from ElementBase for this segment.</value>
    ''' <returns>A <see cref="List(Of ElementBase)">List</see> of objects derived from ElementBase.</returns>
    ''' <remarks>This will be a zero-based list of elements contained by this segment.</remarks>
    Friend ReadOnly Property Elements As New List(Of ElementBase)

    ''' <summary>
    ''' Gets a list of syntax rules that can be applied to the segment.
    ''' </summary>
    Friend ReadOnly Property SyntaxRules As New List(Of SyntaxRule)

    Friend Sub SetImplementationRules(rules As IEnumerable(Of SyntaxRule))
        mRules2.Clear()
        mRules2.AddRange(rules)
    End Sub

    ''' <summary>
    ''' This is needed to satisfy the requirements of the interface. Segments don't have any child items that need to handle themselves.
    ''' </summary>
    Private ReadOnly Property Children As IList(Of ITransactionSetItem) Implements ISegment.Children
        Get
            Return Elements
        End Get
    End Property

    ''' <summary>
    ''' Since a segment doesn't need to clear itself, the interface implementation will ignore that parameter and then delegate to an
    ''' inherited class definition.
    ''' </summary>
    Private Function WriteAsync(writer As IO.TextWriter, clearAfterWrite As Boolean, envelope As Envelope) As Task Implements ISegment.WriteAsync
        Return WriteAsync(writer, envelope)
    End Function

    Private Function WriteCount() As Integer Implements ISegment.WriteCount
        Return 1
    End Function

    Friend Overridable Async Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task
        Dim Last As Integer = -1

        For index = 0 To Elements.Count - 1
            If Elements(index) IsNot Nothing AndAlso Elements(index).HasValue Then
                Last = index
            End If
        Next

        Await writer.WriteAsync(SegmentID)

        For index = 0 To Last
            Await writer.WriteAsync(envelope.ElementSeparator)
            If Elements(index) IsNot Nothing AndAlso Elements(index).HasValue Then
                Await Elements(index).WriteAsync(writer, envelope)
            End If
        Next

        Await writer.WriteAsync(envelope.SegmentTerminator)
    End Function

    ''' <summary>
    ''' Validate the segment elements.
    ''' </summary>
    ''' <param name="results">An object to contain any validation errors and warnings for the segment elements.</param>
    Public Overridable Sub ValidateElements(results As ValidationResults) Implements IValidate.ValidateChildren
        For Each item In Elements
            item.ValidateElement(results)
            item.ValidateSubElements(results)
        Next
    End Sub

    ''' <summary>
    ''' Validate the segment itself.
    ''' </summary>
    ''' <param name="results">An object to contain any validation errors and warnings for the sgement itself (not its elements).</param>
    ''' <remarks>This method may be overridden if the segment can detect something wrong internally.</remarks>
    Public Overridable Sub ValidateSegmentItself(results As ValidationResults) Implements IValidate.Validate
        Dim E As New ValidationFailureResult With {.Source = Me}
        Dim w As New ValidationWarning With {.Source = Me}

        If Elements.Count = 0 Then
            E.Errors.Add("The segment has no defined elements. Every segment is required to contain at least one value.")
        End If

        For Each rule In SyntaxRules
            If Not rule.ValidateRule(Elements) Then
                E.Errors.Add("Failed validation: " & rule.ToString)
            End If
        Next

        For Each rule In mRules2
            If Not rule.ValidateRule(Elements) Then
                E.Errors.Add("Failed Implementation Validation: " & rule.ToString)
            End If
        Next

        If E.Errors.Count > 0 Then
            results.Failures.Add(E)
        End If

        If w.Warnings.Count > 0 Then
            results.Warnings.Add(w)
        End If
    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

    'These are used to link the actual instances of segments to their appropriate collections.
    Friend Property SetArea As Integer? Implements ISegment.SetArea
    Friend Property SetSequence As Integer? Implements ISegment.SetSequence

    'These are the standard positions for segments.
    Friend Property SetTable As Integer
    Friend Property SetPosition As Integer
End Class
