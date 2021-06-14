Namespace DataElements
    '''<summary>Provider Agreement Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of agreement under which the provider is submitting this claim</para>
    '''</remarks>
    Partial Friend Class Element1360
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "D,E,H,I,N,P,Y")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1360
            Dim rval As New Element1360

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace