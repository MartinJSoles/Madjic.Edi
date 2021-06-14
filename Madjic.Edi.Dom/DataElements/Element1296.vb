Namespace DataElements
    '''<summary>Special Processing Type</summary>
    '''<remarks>
    '''<para>Type of special processing that is required</para>
    '''</remarks>
    Partial Friend Class Element1296
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1296
            Dim rval As New Element1296

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace