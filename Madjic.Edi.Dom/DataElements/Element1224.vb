Namespace DataElements
    '''<summary>Contribution Code</summary>
    '''<remarks>
    '''<para>Code indicating the category of contribution</para>
    '''</remarks>
    Partial Friend Class Element1224
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "AC,EA,EB,EC,ED,EI,EM,EP,ER,ES,ET,EU,IC,MB,MS,MT,MU,NC,NQ,PB,PS,PT,QC,QE,QM,QP,RA,RK,RO,RP,RS,RT,SD,SP,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1224
            Dim rval As New Element1224

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace