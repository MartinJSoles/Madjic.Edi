Namespace DataElements
    '''<summary>Ambulance Transport Reason Code</summary>
    '''<remarks>
    '''<para>Code indicating the reason for ambulance transport</para>
    '''</remarks>
    Partial Friend Class Element1317
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,B,C,D,E,F")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1317
            Dim rval As New Element1317

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace