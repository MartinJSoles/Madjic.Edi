Namespace DataElements
    '''<summary>Review Code</summary>
    '''<remarks>
    '''<para>Code identifying extenuating circumstances or justifications which might assist any review of the medical necessity for this service</para>
    '''</remarks>
    Partial Friend Class Element1364
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "A,B,C,D,E,F,L,N")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1364
            Dim rval As New Element1364

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace