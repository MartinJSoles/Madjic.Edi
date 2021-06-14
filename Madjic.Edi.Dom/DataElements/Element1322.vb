Namespace DataElements
    '''<summary>Certification Type Code</summary>
    '''<remarks>
    '''<para>Code indicating the type of certification</para>
    '''</remarks>
    Partial Friend Class Element1322
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "1,2,3,4,5,6,A,B,C,D,E,I,N,R,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1322
            Dim rval As New Element1322

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace