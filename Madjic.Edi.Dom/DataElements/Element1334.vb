Namespace DataElements
    '''<summary>Health Care Professional Shortage Area Code</summary>
    '''<remarks>
    '''<para>Code identifying the Health Care Professional Shortage Area Code (HPSA)</para>
    '''</remarks>
    Partial Friend Class Element1334
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, Nothing)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1334
            Dim rval As New Element1334

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace