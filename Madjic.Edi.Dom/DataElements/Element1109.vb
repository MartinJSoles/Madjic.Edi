Namespace DataElements
    '''<summary>Race or Ethnicity Code</summary>
    '''<remarks>
    '''<para>Code indicating the racial or ethnic background of a person; it is normally self-reported; Under certain circumstances this information is collected for United States Government statistical purposes</para>
    '''</remarks>
    Partial Friend Class Element1109
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Q,R,S,T,U,V,W,Z")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1109
            Dim rval As New Element1109

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace