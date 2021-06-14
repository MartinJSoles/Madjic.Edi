Namespace DataElements
    '''<summary>Originating Company Identifier</summary>
    '''<remarks>
    '''<para>A unique identifier designating the company initiating the funds transfer instructions, business transaction or assigning tracking reference identification.</para>
    '''</remarks>
    Partial Friend Class Element509
        Inherits StringElement

        Public Sub New()
            MyBase.New(10, 10)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element509
            Dim rval As New Element509

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace