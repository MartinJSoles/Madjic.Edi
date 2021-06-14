Namespace DataElements
    '''<summary>Loop Identifier Code</summary>
    '''<remarks>
    '''<para>The loop ID number given on the transaction set diagram is the value for this data element in segments LS and LE</para>
    '''</remarks>
    Partial Friend Class Element447
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 4)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element447
            Dim rval As New Element447

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace