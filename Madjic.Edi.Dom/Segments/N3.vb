Namespace Segments
    '''<summary>Party Location</summary>
    '''<remarks>To specify the location of the named party</remarks>
    Partial Friend Class N3_Obj
        Inherits Segment
        Implements N3,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N3,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N3,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N3,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N3,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("N3")
            Elements.AddRange({CType(Nothing, DataElements.Element166),
                                      CType(Nothing, DataElements.Element166)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property N301 As String Implements N3.N301, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3.N301, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3.N301, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3.N301, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N3.N301, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N3.N301, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N3.N301, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N3.N301, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3.N301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3.N301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3.N301, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3.N301, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3.N301, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3.N301, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3.N301, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3.N301, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N3.N301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N3.N301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N3.N301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N3.N301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element166).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element166
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element166).Value = value
                End If
            End Set
        End Property

        Friend Property N302 As String Implements N3.N302, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3.N302, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3.N302, Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3.N302, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.N3.N302, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.N3.N302, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.N3.N302, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.N3.N302, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010C.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010D.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EB.N3.N302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.N3.N302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.N3.N302, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N3.N302, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N3.N302, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100C.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100H.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.N3.N302, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.N3.N302, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.N3.N302, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AB.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AC.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BB.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310E.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310F.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330A.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2330B.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420C.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420G.N3.N302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420H.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AB.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AC.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BA.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010BB.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010CA.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2310C.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330A.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2330B.N3.N302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2420D.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AB.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AC.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BA.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010BB.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010CA.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2310E.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330A.N3.N302, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2330B.N3.N302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element166).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element166
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element166).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As N3
            Dim rval As New N3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .N301 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .N302 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Party Location</summary>
    '''<remarks>To specify the location of the named party</remarks>
    Public Interface N3
        Inherits ISegment

        '''<summary>Address Information</summary>
        '''<remarks></remarks>
        Property N301 As String

        '''<summary>Address Information</summary>
        '''<remarks></remarks>
        Property N302 As String

    End Interface
End NameSpace