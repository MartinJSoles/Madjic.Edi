Namespace DataElements
    '''<summary>Type of Account Code</summary>
    '''<remarks>
    '''<para>Code defining the type of ownership</para>
    '''</remarks>
    Partial Friend Class Element1187
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing,
                       "01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1187
            Dim rval As New Element1187

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace