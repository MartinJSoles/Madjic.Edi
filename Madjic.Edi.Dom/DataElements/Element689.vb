Namespace DataElements
    '''<summary>Occupancy Code</summary>
    '''<remarks>
    '''<para>Code specifying occupancy status of real estate property</para>
    '''</remarks>
    Partial Friend Class Element689
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element689
            Dim rval As New Element689

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace