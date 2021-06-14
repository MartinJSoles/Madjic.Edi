Namespace DataElements
    '''<summary>Interchange Delivery Time Code</summary>
    '''<remarks>
    '''<para>Code identifying the delivery time; in accordance with International Organization for Standardization (ISO) standard 8601, time can be specified by a + or - and an indication in hours in relation to universal time coordination (UTC) time; since + is a restricted character, the +  and - are substituted by P an M in the codes that follow</para>
    '''</remarks>
    Partial Friend Class ElementI37
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI37
            Dim rval As New ElementI37

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace