Namespace DataElements
    '''<summary>Interchange Delivery Date</summary>
    '''<remarks>
    '''<para>This is the earliest date the interchange can be delivered to the recipient</para>
    '''</remarks>
    Partial Friend Class ElementI35
        Inherits DateElement

        Public Sub New()
            MyBase.New(6, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI35
            Dim rval As New ElementI35

            rval.Value = fullElement.ToDate
            Return rval
        End Function
    End Class
End NameSpace