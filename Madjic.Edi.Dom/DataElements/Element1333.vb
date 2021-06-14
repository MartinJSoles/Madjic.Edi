Namespace DataElements
    '''<summary>Record Format Code</summary>
    '''<remarks>
    '''<para>Code specifying the format of information</para>
    '''</remarks>
    Partial Friend Class Element1333
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "C,D,E,F,P,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1333
            Dim rval As New Element1333

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace