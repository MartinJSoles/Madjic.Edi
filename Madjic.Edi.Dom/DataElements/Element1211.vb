Namespace DataElements
    '''<summary>Drug House Code</summary>
    '''<remarks>
    '''<para>Code indicating a drug house with which the insurance plan is affiliated</para>
    '''</remarks>
    Partial Friend Class Element1211
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing, "AM,BAX,FLR,HCS,NP,PCS,THR,ZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1211
            Dim rval As New Element1211

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace