Namespace DataElements
    '''<summary>Salary Grade</summary>
    '''<remarks>
    '''<para>The salary grade code assigned by the employer</para>
    '''</remarks>
    Partial Friend Class Element1214
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 5)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1214
            Dim rval As New Element1214

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace