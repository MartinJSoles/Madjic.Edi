Namespace DataElements
    '''<summary>Functional Group Syntax Error Code</summary>
    '''<remarks>
    '''<para>Code indicating error found based on the syntax editing of the function group header and/or trailer</para>
    '''</remarks>
    Partial Friend Class Element716
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing, "1,10,11,12,13,14,15,16,17,18,19,2,23,24,25,26,3,4,5,6")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element716
            Dim rval As New Element716

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace