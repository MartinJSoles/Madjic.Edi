Namespace DataElements
    '''<summary>Printer Carriage Control Code</summary>
    '''<remarks>
    '''<para>A field to be used for the control of the line feed of the receiving printer</para>
    '''</remarks>
    Partial Friend Class Element934
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 2, Nothing, "AA,AT,DS,LC,NP,NS,SS")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element934
            Dim rval As New Element934

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace