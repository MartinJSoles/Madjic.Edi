Namespace DataElements
    '''<summary>Implementation Data Element Syntax Error Code</summary>
    '''<remarks>
    '''<para>Code indicating the implementation error found after syntax edits of a data element</para>
    '''</remarks>
    Partial Friend Class Element621
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "1,10,12,13,2,3,4,5,6,7,8,9,I10,I11,I12,I13,I6,I9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element621
            Dim rval As New Element621

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace