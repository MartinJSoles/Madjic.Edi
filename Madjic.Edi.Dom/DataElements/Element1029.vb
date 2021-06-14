Namespace DataElements
    '''<summary>Claim Status Code</summary>
    '''<remarks>
    '''<para>Code identifying the status of an entire claim as assigned by the payor, claim review organization or repricing organization</para>
    '''</remarks>
    Partial Friend Class Element1029
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing,
                       "1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9,AD,AP,CC,CL,CP,I,RA,RB,RC,RD,RO")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1029
            Dim rval As New Element1029

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace