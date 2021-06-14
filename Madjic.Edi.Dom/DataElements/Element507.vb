Namespace DataElements
    '''<summary>(DFI) Identification Number</summary>
    '''<remarks>
    '''<para>Depository Financial Institution (DFI) identification number</para>
    '''</remarks>
    Partial Friend Class Element507
        Inherits StringElement

        Public Sub New()
            MyBase.New(3, 12)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element507
            Dim rval As New Element507

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace