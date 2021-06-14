Namespace DataElements
    '''<summary>Allowance or Charge Method of Handling Code</summary>
    '''<remarks>
    '''<para>Code indicating method of handling for an allowance or charge</para>
    '''</remarks>
    Partial Friend Class Element331
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "01,02,03,04,05,06,07,08,09,10,11,12,13,15,18,20,21,25,CA,CC,PP,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element331
            Dim rval As New Element331

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace