Namespace DataElements
    '''<summary>Dispense as Written Code</summary>
    '''<remarks>
    '''<para>Code indicating whether or not the prescriber's instructions regarding generic substitution were followed</para>
    '''</remarks>
    Partial Friend Class Element1329
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "0,1,2,3,4,5,6,7,8,9")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1329
            Dim rval As New Element1329

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace