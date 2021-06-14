Namespace DataElements
    '''<summary>Account Number Qualifier</summary>
    '''<remarks>
    '''<para>Code indicating the type of account</para>
    '''</remarks>
    Partial Friend Class Element569
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing,
                       "01,03,05,06,07,08,1,10,11,12,13,14,2,3,4,5,6,7,8,9,AG,ALC,ANN,AP,BA,CB,CC,CDM,CDS,CM,CRU,DA,DC,EC,EPC,GL,LN,LTD,MUT,PRI,RD,REL,RS,SG,SKA,Z,ZB1,ZB2")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element569
            Dim rval As New Element569

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace