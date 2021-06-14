Namespace DataElements
    '''<summary>Patient Location Code</summary>
    '''<remarks>
    '''<para>Code identifying the location where patient is receiving medical treatment</para>
    '''</remarks>
    Partial Friend Class Element1384
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,F,G,H,L,M,O,P,R,S,T")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1384
            Dim rval As New Element1384

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace