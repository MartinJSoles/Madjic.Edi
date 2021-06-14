Namespace DataElements
    '''<summary>Provider Specialty Code</summary>
    '''<remarks>
    '''<para>Code indicating the primary specialty of the provider, as defined by the receiver</para>
    '''</remarks>
    Partial Friend Class Element1222
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 3)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1222
            Dim rval As New Element1222

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace