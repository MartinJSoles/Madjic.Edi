Namespace DataElements
    '''<summary>Interchange Note Code</summary>
    '''<remarks>
    '''<para>Code specifying the error found processing the interchange control structure</para>
    '''</remarks>
    Partial Friend Class ElementI18
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing,
                       "000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As ElementI18
            Dim rval As New ElementI18

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace