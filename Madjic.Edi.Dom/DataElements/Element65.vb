Namespace DataElements
    '''<summary>Height</summary>
    '''<remarks>
    '''<para>Vertical dimension of an object measured when the object is in the upright position</para>
    '''</remarks>
    Partial Friend Class Element65
        Inherits DecimalElement

        Public Sub New()
            MyBase.New(1, 8)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element65
            Dim rval As New Element65

            rval.Value = fullElement.ToFloat
            Return rval
        End Function
    End Class
End NameSpace