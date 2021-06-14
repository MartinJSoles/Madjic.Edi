Namespace DataElements
    '''<summary>Communication Number</summary>
    '''<remarks>
    '''<para>Complete communications number including country or area code when applicable</para>
    '''</remarks>
    Partial Friend Class Element364
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 256)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element364
            Dim rval As New Element364

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace