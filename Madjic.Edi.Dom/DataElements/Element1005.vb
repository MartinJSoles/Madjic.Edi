Namespace DataElements
    '''<summary>Hierarchical Structure Code</summary>
    '''<remarks>
    '''<para>Code indicating the hierarchical application structure of a transaction set that utilizes the HL segment to define the structure of the transaction set</para>
    '''</remarks>
    Partial Friend Class Element1005
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(4, 4, Nothing,
                       "0001,0002,0003,0004,0005,0006,0007,0010,0011,0012,0013,0014,0015,0016,0017,0018,0019,0020,0021,0022,0023,0024,0025,0026,0027,0028,0029,0035,0036,0055,0056,0057,0058,0059,0060,0061,0062,0063,0064,0065,0066,0067,0068,0069,0070,0071,0072,0073,0074,0075,0076,0077,0078,0079,0080,0081,0082,0083,0084,0085,0200,0201,0202,0203,0204,0205,0206,0207,0208,0209,0210,0211,0212,0213,0214,0400,0401,0402,0403,0407,ZZZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1005
            Dim rval As New Element1005

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace