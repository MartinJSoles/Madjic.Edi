Namespace DataElements
    '''<summary>Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying</summary>
    '''<remarks>
    '''<para>A Qualifying Event is any of the following which results in loss of coverage for a Qualified Beneficiary</para>
    '''</remarks>
    Partial Friend Class Element1219
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,10,2,3,4,5,6,7,8,9,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1219
            Dim rval As New Element1219

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace