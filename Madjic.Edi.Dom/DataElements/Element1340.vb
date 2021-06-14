Namespace DataElements
    '''<summary>Multiple Procedure Code</summary>
    '''<remarks>
    '''<para>Code indicating proper adjudication and payment determination in cases involving multiple surgical procedures during the same surgical session</para>
    '''</remarks>
    Partial Friend Class Element1340
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "N,P,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1340
            Dim rval As New Element1340

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace