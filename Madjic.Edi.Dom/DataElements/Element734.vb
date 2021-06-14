Namespace DataElements
    '''<summary>Hierarchical Parent ID Number</summary>
    '''<remarks>
    '''<para>Identification number of the next higher hierarchical data segment that the data segment being described is subordinate to</para>
    '''</remarks>
    Partial Friend Class Element734
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 12)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element734
            Dim rval As New Element734

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace