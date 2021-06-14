Public MustInherit Class ElementBase
    Implements IValidate, IParanted

    Protected Sub New()

    End Sub

    Private mHasValue As Boolean
    Public Overridable Property HasValue As Boolean
        Get
            Return mHasValue
        End Get
        Protected Set(value As Boolean)
            mHasValue = value
        End Set
    End Property

    ''' <summary>
    ''' Writes the element to the output writer.
    ''' </summary>
    ''' <param name="writer">The destination to write the element to.</param>
    ''' <param name="envelope">The envelope object to use for the separator characters.</param>
    ''' <remarks></remarks>
    Friend MustOverride Function WriteAsync(writer As IO.TextWriter, envelope As Envelope) As Task

    ''' <summary>
    ''' Allows a data element to validate itself.
    ''' </summary>
    ''' <param name="results">An object containing the validation errors and warnings for this data element.</param>
    ''' <remarks>Simple data elements are required to override this method. Composite data elements shouldn't override.</remarks>
    Public Overridable Sub ValidateElement(results As ValidationResults) Implements IValidate.Validate

    End Sub

    ''' <summary>
    ''' Allows a composite data element to validate its child subelements.
    ''' </summary>
    ''' <param name="results">An object containing the validation errors and warnings for this composite data element's sub elements.</param>
    ''' <remarks>Simple data elements should not override this method. Composite data elements are required to override.</remarks>
    Public Overridable Sub ValidateSubElements(results As ValidationResults) Implements IValidate.ValidateChildren

    End Sub

    Friend Property Parent As IParanted Implements IParanted.Parent

End Class

