Namespace DataElements
    '''<summary>Hierarchical Child Code</summary>
    '''<remarks>
    '''<para>Code indicating if there are hierarchical child data segments subordinate to the level being described</para>
    '''</remarks>
    Partial Friend Class Element736
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element736
            Dim rval As New Element736

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace