''' <summary>
''' Identifies objects that can be validated.
''' </summary>
''' <remarks>This interface allows various objects in the document tree to be validated.</remarks>
Friend Interface IValidate

    ''' <summary>
    ''' Validates the current object only.
    ''' </summary>
    ''' <param name="results">An object that holds the validation failures and warnings.</param>
    ''' <remarks></remarks>
    Sub Validate(results As ValidationResults)

    ''' <summary>
    ''' Validates any child objects that this object has.
    ''' </summary>
    ''' <param name="results">An object that holds the validation failures and warnings.</param>
    ''' <remarks></remarks>
    Sub ValidateChildren(results As ValidationResults)

End Interface

''' <summary>
''' Contains the validation failures and warnings.
''' </summary>
Public Class ValidationResults

    ''' <summary>
    ''' Gets a list of validation failures.
    ''' </summary>
    Public ReadOnly Property Failures As New List(Of ValidationFailureResult)

    ''' <summary>
    ''' Gets a list of validation warnings.
    ''' </summary>
    Public ReadOnly Property Warnings As New List(Of ValidationWarning)

    ''' <summary>
    ''' Gets whether there are any validation errors.
    ''' </summary>
    ''' <returns>True, if there are any validation errors. False, otherwise.</returns>
    Public ReadOnly Property HasErrors As Boolean
        Get
            Return Failures.Count > 0
        End Get
    End Property

    ''' <summary>
    ''' Gets whether this object is considered error and warning free.
    ''' </summary>
    ''' <returns>True, if there are no validation warnings and no validation errors. False, otherwise.</returns>
    Public ReadOnly Property IsClean As Boolean
        Get
            Return Failures.Count = 0 AndAlso Warnings.Count = 0
        End Get
    End Property

    Friend Sub Reset()
        Failures.Clear()
        Warnings.Clear()
    End Sub
End Class

''' <summary>
''' Indicates a validation failure.
''' </summary>
Public Class ValidationFailureResult
    ''' <summary>
    ''' Gets/sets the object that failed validation.
    ''' </summary>
    Public Property Source As Object

    ''' <summary>
    ''' Gets a list of error messages tied directly to this source object.
    ''' </summary>
    Public ReadOnly Property Errors As New List(Of String)
End Class

''' <summary>
''' Indicates a validation warning.
''' </summary>
Public Class ValidationWarning
    ''' <summary>
    ''' Gets/sets the object that generated at least one warning.
    ''' </summary>
    Public Property Source As Object

    ''' <summary>
    ''' Gets a list of warning messages tied directly to this source object.
    ''' </summary>
    Public ReadOnly Property Warnings As New List(Of String)
End Class