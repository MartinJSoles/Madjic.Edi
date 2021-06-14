Namespace DataElements
    '''<summary>Oxygen Test Findings Code</summary>
    '''<remarks>
    '''<para>Code indicating the findings of oxygen tests performed on a patient</para>
    '''</remarks>
    Partial Friend Class Element1350
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1350
            Dim rval As New Element1350

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace