Namespace DataElements
    '''<summary>Oxygen Delivery System Code</summary>
    '''<remarks>
    '''<para>Code to indicate if a particular form of delivery was prescribed</para>
    '''</remarks>
    Partial Friend Class Element1382
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1382
            Dim rval As New Element1382

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace