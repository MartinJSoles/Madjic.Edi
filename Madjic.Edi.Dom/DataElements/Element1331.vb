Namespace DataElements
    '''<summary>Facility Code Value</summary>
    '''<remarks>
    '''<para>Code identifying where services were, or may be, performed; the first and second positions of the Uniform Bill Type Code for Institutional Services or the Place of Service Codes for Professional or Dental Services.</para>
    '''</remarks>
    Partial Friend Class Element1331
        Inherits StringElement

        Public Sub New()
            MyBase.New(1, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1331
            Dim rval As New Element1331

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace