Namespace DataElements
    '''<summary>Number of Accepted Transaction Sets</summary>
    '''<remarks>
    '''<para>Number of accepted Transaction Sets in a Functional Group</para>
    '''</remarks>
    Partial Friend Class Element2
        Inherits NumericElement

        Public Sub New()
            MyBase.New(1, 0, 6)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element2
            Dim rval As New Element2

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace