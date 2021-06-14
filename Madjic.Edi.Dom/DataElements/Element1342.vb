Namespace DataElements
    '''<summary>Nature of Condition Code</summary>
    '''<remarks>
    '''<para>Code indicating the nature of a patient's condition</para>
    '''</remarks>
    Partial Friend Class Element1342
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 1, Nothing, "A,C,D,E,F,G,M")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1342
            Dim rval As New Element1342

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace