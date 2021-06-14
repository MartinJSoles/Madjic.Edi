Namespace DataElements
    '''<summary>Measurement Method or Device</summary>
    '''<remarks>
    '''<para>The method or device used to record the measurement</para>
    '''</remarks>
    Partial Friend Class Element1373
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 4, Nothing, "BM,BO,DM,FT,HN,MA,MM,OM,OU,PT,TM,VA,VB,VC")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1373
            Dim rval As New Element1373

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace