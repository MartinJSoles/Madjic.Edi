Namespace DataElements
    '''<summary>City Name</summary>
    '''<remarks>
    '''<para>Free-form text for city name</para>
    '''</remarks>
    Partial Friend Class Element19
        Inherits StringElement

        Public Sub New()
            MyBase.New(2, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element19
            Dim rval As New Element19

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace