Namespace DataElements
    '''<summary>Procedure Modifier</summary>
    '''<remarks>
    '''<para>This identifies special circumstances related to the performance of the service, as defined by trading partners</para>
    '''</remarks>
    Partial Friend Class Element1339
        Inherits StringElement

        Public Sub New()
            MyBase.New(2, 2)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1339
            Dim rval As New Element1339

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace