Namespace DataElements
    '''<summary>Coverage Level Code</summary>
    '''<remarks>
    '''<para>Code indicating the level of coverage being provided for this insured</para>
    '''</remarks>
    Partial Friend Class Element1207
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing,
                       "CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,S1C,S5C,S6C,SPC,SPO,SS1,SS5,SS6,SSP,TWO")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1207
            Dim rval As New Element1207

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace