''' <summary>
''' Defines a simple element that only contains a single value.
''' </summary>
''' <remarks>This is a base class. Use one of the derived simple data element types.</remarks>
Friend MustInherit Class SimpleElement
    Inherits ElementBase

    Public ReadOnly Property MinimumLength As Integer

    Public ReadOnly Property MaximumLength As Integer

    Protected Sub New(minimumLength As Integer, maximumLength As Integer)
        If minimumLength < 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(minimumLength), "The minimum length must not be negative.")
        End If

        If minimumLength > maximumLength Then
            Throw New ArgumentOutOfRangeException(NameOf(minimumLength), "The minimum length cannot be greater than the maximum allowed.")
        End If

        If maximumLength = 0 Then
            Throw New ArgumentOutOfRangeException(NameOf(minimumLength), "The maximum length must be one or greater.")
        End If

        Me.MinimumLength = minimumLength
        Me.MaximumLength = maximumLength
    End Sub

    Private mValue As String
    Protected Property EdiValue As String
        Get
            Return mValue
        End Get
        Set(value As String)
            mValue = value

            If value IsNot Nothing Then
                mValueUpper = value.ToUpperInvariant()
            End If

            HasValue = mValue IsNot Nothing
        End Set
    End Property

    Private mValueUpper As String
    Protected ReadOnly Property EdiValueAsUpper As String
        Get
            Return mValueUpper
        End Get
    End Property
End Class
