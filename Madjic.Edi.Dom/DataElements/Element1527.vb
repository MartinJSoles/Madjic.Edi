Namespace DataElements
    '''<summary>Exception Code</summary>
    '''<remarks>
    '''<para>Code specifying the exception reason for consideration of out-of-network health care services</para>
    '''</remarks>
    Partial Friend Class Element1527
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,5,6")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1527
            Dim rval As New Element1527

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace