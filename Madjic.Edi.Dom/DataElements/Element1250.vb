Namespace DataElements
    '''<summary>Date Time Period Format Qualifier</summary>
    '''<remarks>
    '''<para>Code indicating the date format, time format, or date and time format</para>
    '''</remarks>
    Partial Friend Class Element1250
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(2, 3, Nothing,
                       "CC,CD,CM,CQ,CY,D6,D8,DA,DB,DD,DDT,DT,DTD,DTS,EH,KA,MCY,MD,MM,RD,RD2,RD4,RD5,RD6,RD8,RDM,RDT,RMD,RMY,RTM,RTS,TC,TM,TQ,TR,TS,TT,TU,UN,YM,YMM,YY")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element1250
            Dim rval As New Element1250

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace