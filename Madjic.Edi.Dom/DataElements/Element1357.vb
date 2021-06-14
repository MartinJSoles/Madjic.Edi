Namespace DataElements
    '''<summary>Prior Authorization Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of prior authorization or medical certification that has occurred</para>
    '''</remarks>
    Partial Friend Class Element1357
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3,4,5,6,7")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1357
            Dim rval As New Element1357

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace