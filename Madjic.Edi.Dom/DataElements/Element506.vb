Namespace DataElements
    '''<summary>(DFI) ID Number Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the type of identification number of Depository Financial Institution (DFI)</para>
    '''</remarks>
    Partial Friend Class Element506
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "01,02,03,04,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element506
            Dim rval As New Element506

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace