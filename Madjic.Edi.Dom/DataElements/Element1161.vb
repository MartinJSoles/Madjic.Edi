Namespace DataElements
    '''<summary>Product Option Code</summary>
    '''<remarks>
    '''<para>Code indicating an option chosen for the product</para>
    '''</remarks>
    Partial Friend Class Element1161
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,10,11,12,13,14,15,2,28,29,3,30,31,4,5,6,7,8,9,A,B,BA,C,D,GA,N,NC,O,PD,S")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1161
            Dim rval As New Element1161

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace