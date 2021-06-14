Namespace DataElements
    '''<summary>Basis of Days Supply Determination Code</summary>
    '''<remarks>
    '''<para>Code indicating the method by which the days supply was determined</para>
    '''</remarks>
    Partial Friend Class Element1320
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1320
            Dim rval As New Element1320

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace