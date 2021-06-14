Namespace DataElements
    '''<summary>State or Province Code</summary>
    '''<remarks>
    '''<para>Code (Standard State/Province) as defined by appropriate government agency</para>
    '''</remarks>
    Partial Friend Class Element156
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element156
            Dim rval As New Element156

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace