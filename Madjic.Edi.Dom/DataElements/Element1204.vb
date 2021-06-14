Namespace DataElements
    '''<summary>Plan Coverage Description</summary>
    '''<remarks>
    '''<para>A description or number that identifies the plan or coverage</para>
    '''</remarks>
    Partial Friend Class Element1204
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 50)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1204
            Dim rval As New Element1204

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace