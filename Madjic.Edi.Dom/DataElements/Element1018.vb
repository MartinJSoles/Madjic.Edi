Namespace DataElements
    '''<summary>Exponent</summary>
    '''<remarks>
    '''<para>Power to which a unit is raised</para>
    '''</remarks>
    Partial Friend Class Element1018
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 15)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1018
            Dim rval As New Element1018

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace