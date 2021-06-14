Namespace DataElements
    '''<summary>Grade of Service Code</summary>
    '''<remarks>
    '''<para>Code indicating the relative urgency of the interchange as determined by the interchange sender</para>
    '''</remarks>
    Partial Friend Class ElementI34
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI34
            Dim rval As New ElementI34

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace