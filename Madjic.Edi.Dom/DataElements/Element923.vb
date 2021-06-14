Namespace DataElements
    '''<summary>Prognosis Code</summary>
    '''<remarks>
    '''<para>Code indicating physician's prognosis for the patient</para>
    '''</remarks>
    Partial Friend Class Element923
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,7,8")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element923
            Dim rval As New Element923

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace