Namespace DataElements
    '''<summary>Maintenance Type Code</summary>
    '''<remarks>
    '''<para>Code identifying the specific type of item maintenance</para>
    '''</remarks>
    Partial Friend Class Element875
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(3, 3, Nothing,
                       "001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,028,029,030,031,032,033,050,051,052,053,054,055,056,057,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,100,101,102,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,CEP,PRI,TBV,ZZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element875
            Dim rval As New Element875

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace