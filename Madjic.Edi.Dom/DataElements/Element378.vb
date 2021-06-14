Namespace DataElements
    '''<summary>Allowance/Charge Percent Qualifier</summary>
    '''<remarks>
    '''<para>Code indicating on what basis allowance or charge percent is calculated</para>
    '''</remarks>
    Partial Friend Class Element378
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3,4,5,6,7,8,9,A,B,C,D,H,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element378
            Dim rval As New Element378

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace