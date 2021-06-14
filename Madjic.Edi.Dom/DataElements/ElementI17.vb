Namespace DataElements
    '''<summary>Interchange Acknowledgment Code</summary>
    '''<remarks>
    '''<para>Code indicating the status of the receipt of the interchange control structure</para>
    '''</remarks>
    Partial Friend Class ElementI17
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "E,R")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI17
            Dim rval As New ElementI17

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace