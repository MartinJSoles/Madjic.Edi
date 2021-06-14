Namespace DataElements
    '''<summary>Price Multiplier Qualifier</summary>
    '''<remarks>
    '''<para>Code indicating the type of price multiplier</para>
    '''</remarks>
    Partial Friend Class Element648
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing, "CSD,CSR,DIS,ILP,PSP,SEL")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element648
            Dim rval As New Element648

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace