Namespace DataElements
    '''<summary>National or Local Assigned Review Value</summary>
    '''<remarks>
    '''<para>Value assigned by national or local organizations for various healthcare data elements</para>
    '''</remarks>
    Partial Friend Class Element1341
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1341
            Dim rval As New Element1341

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace