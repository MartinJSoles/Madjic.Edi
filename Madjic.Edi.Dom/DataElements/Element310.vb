Namespace DataElements
    '''<summary>Location Identifier</summary>
    '''<remarks>
    '''<para>Code which identifies a specific location</para>
    '''</remarks>
    Partial Friend Class Element310
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element310
            Dim rval As New Element310

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace