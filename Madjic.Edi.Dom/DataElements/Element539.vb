Namespace DataElements
    '''<summary>Vehicle Identification Number</summary>
    '''<remarks>
    '''<para>Unique identification number stamped on the vehicle by the manufacturer</para>
    '''</remarks>
    Partial Friend Class Element539
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 30)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element539
            Dim rval As New Element539

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace