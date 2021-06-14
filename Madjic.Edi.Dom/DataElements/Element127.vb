Namespace DataElements
    '''<summary>Reference Identification</summary>
    '''<remarks>
    '''<para>Reference information as defined for a particular Transaction Set or as specified by the Reference Identification Qualifier</para>
    '''</remarks>
    Partial Friend Class Element127
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 50)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element127
            Dim rval As New Element127

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace