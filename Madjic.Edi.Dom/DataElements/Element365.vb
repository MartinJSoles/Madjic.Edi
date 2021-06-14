Namespace DataElements
    '''<summary>Communication Number Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying the type of communication number</para>
    '''</remarks>
    Partial Friend Class Element365
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "AA,AB,AC,AD,AE,AP,AS,AU,BN,BT,CA,CP,DN,EA,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT,PA,PC,PP,PS,SP,TE,TL,TM,TN,TX,UR,VM,WC,WF,WP")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element365
            Dim rval As New Element365

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace