Namespace DataElements
    '''<summary>Interchange Control Number</summary>
    '''<remarks>
    '''<para>A control number assigned by the interchange sender</para>
    '''</remarks>
    Partial Friend Class ElementI12
        Inherits NumericElement

        Public Sub New()
            MyBase.New(9, 0, 9)
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI12
            Dim rval As New ElementI12

            rval.Value = fullElement.ToDecimal(0)
            Return rval
        End Function
    End Class
End NameSpace