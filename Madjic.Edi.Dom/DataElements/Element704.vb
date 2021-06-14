Namespace DataElements
    '''<summary>Paperwork/Report Action Code</summary>
    '''<remarks>
    '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
    '''</remarks>
    Partial Friend Class Element704
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 2, Nothing, "1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element704
            Dim rval As New Element704

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace