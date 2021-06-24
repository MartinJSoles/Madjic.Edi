Public Class EdiException
    Inherits Exception

    Friend Sub New()
        MyBase.New()
    End Sub

    Friend Sub New(message As String)
        MyBase.New(message)
    End Sub

    Friend Sub New(message As String, segmentPositionInEnvelope As Integer)
        MyBase.New(message)

        _CountISA = segmentPositionInEnvelope
    End Sub

    Friend Sub New(message As String, innerException As Exception)
        MyBase.New(message, innerException)
    End Sub

    Private _CountISA
    Public Property SegmentPositionInEnvelope As Integer
        Get
            Return _CountISA
        End Get
        Friend Set(value As Integer)
            _CountISA = value
        End Set
    End Property

End Class
