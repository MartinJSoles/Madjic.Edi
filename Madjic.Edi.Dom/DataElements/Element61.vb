Namespace DataElements
    '''<summary>Free-form Information</summary>
    '''<remarks>
    '''<para>Free-form information</para>
    '''</remarks>
    Partial Friend Class Element61
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element61
            Dim rval As New Element61

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace