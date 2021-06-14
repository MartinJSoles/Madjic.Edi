Namespace DataElements
    '''<summary>Ambulance Transport Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of ambulance transport</para>
    '''</remarks>
    Partial Friend Class Element1316
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "I,R,T,X")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1316
            Dim rval As New Element1316

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace