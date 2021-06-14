Namespace DataElements
    '''<summary>Name Last or Organization Name</summary>
    '''<remarks>
    '''<para>Individual last name or organizational name</para>
    '''</remarks>
    Partial Friend Class Element1035
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 60)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1035
            Dim rval As New Element1035

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace