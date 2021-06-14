Namespace DataElements
    '''<summary>Interchange Date</summary>
    '''<remarks>
    '''<para>Date of the interchange</para>
    '''</remarks>
    Partial Friend Class ElementI08
        Inherits DateElement

        Public Sub New()
            MyBase.New(6, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI08
            Dim rval As New ElementI08

            rval.Value = fullElement.ToDate
            Return rval
        End Function
    End Class
End NameSpace