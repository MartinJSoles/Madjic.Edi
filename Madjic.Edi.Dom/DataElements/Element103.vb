Namespace DataElements
    '''<summary>Packaging Code</summary>
    '''<remarks>
    '''<para>Code identifying the type of packaging; Part 1: Packaging Form, Part 2: Packaging Material; if the Data Element is used, then Part 1 is always required</para>
    '''</remarks>
    Partial Friend Class Element103
        Inherits StringElement

        Public Sub New()
            MyBase.New(3, 5)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element103
            Dim rval As New Element103

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace