Namespace Segments
    '''<summary>Administrative Communications Contact</summary>
    '''<remarks>To identify a person or office to whom administrative communications should be directed</remarks>
    Partial Friend Class PER_Obj
        Inherits Segment
        Implements PER,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({3, 4}),
                                                 New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRulePaired({7, 8}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PER")
            Elements.AddRange({CType(Nothing, DataElements.Element366),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element365),
                                      CType(Nothing, DataElements.Element364),
                                      CType(Nothing, DataElements.Element365),
                                      CType(Nothing, DataElements.Element364),
                                      CType(Nothing, DataElements.Element365),
                                      CType(Nothing, DataElements.Element364),
                                      CType(Nothing, DataElements.Element443)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PER01 As String Implements PER.PER01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER01, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER01, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER.PER01, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER01, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER01, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2.PER01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element366).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element366
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element366).Value = value
                End If
            End Set
        End Property

        Friend Property PER02 As String Implements PER.PER02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER02, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER02, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER02, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER02, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER02, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER02, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element93
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property PER03 As String Implements PER.PER03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER03, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER03, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER.PER03, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER03, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER03, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2.PER03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element365
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element365).Value = value
                End If
            End Set
        End Property

        Friend Property PER04 As String Implements PER.PER04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER04, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER04, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2330.PER.PER04, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER04, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER04, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_2.PER04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER04, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER04, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element364).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element364
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element364).Value = value
                End If
            End Set
        End Property

        Friend Property PER05 As String Implements PER.PER05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER05, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER05, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER05, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER05, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER05, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER05, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER05, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER05, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element365
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element365).Value = value
                End If
            End Set
        End Property

        Friend Property PER06 As String Implements PER.PER06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER06, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER06, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER06, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER06, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER06, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER06, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010BA.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010CA.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2310C.PER.PER06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element364).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element364
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element364).Value = value
                End If
            End Set
        End Property

        Friend Property PER07 As String Implements PER.PER07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER07, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER07, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER07, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER07, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER07, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER07, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER07, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER07, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER07, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element365
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element365).Value = value
                End If
            End Set
        End Property

        Friend Property PER08 As String Implements PER.PER08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.PER.PER08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120C.PER.PER08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2120D.PER.PER08, Transactions.Transaction277.Transaction277_A1.Segments.Loop2100A.PER.PER08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010B.PER.PER08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010EA.PER.PER08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2010F.PER.PER08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.PER.PER08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.PER.PER08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EB.PER.PER08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.PER.PER08, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FB.PER.PER08, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.PER.PER08, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100D.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100E.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100F.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100G.PER.PER08, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PER.PER08, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER.PER08, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000A.PER_1.PER08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.PER.PER08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop1000A.PER.PER08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2010AA.PER.PER08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2420E.PER.PER08, Transactions.Transaction837.Transaction837_Q2.Segments.Loop1000A.PER.PER08, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2010AA.PER.PER08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop1000A.PER.PER08, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2010AA.PER.PER08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element364).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element364
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element364).Value = value
                End If
            End Set
        End Property

        Friend Property PER09 As String Implements PER.PER09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element443).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element443
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element443).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PER
            Dim rval As New PER_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PER01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PER02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PER03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PER04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PER05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PER06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .PER07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .PER08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .PER09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Administrative Communications Contact</summary>
    '''<remarks>To identify a person or office to whom administrative communications should be directed</remarks>
    Public Interface PER
        Inherits ISegment

        '''<summary>Contact Function Code</summary>
        '''<remarks></remarks>
        Property PER01 As String

        '''<summary>Name</summary>
        '''<remarks></remarks>
        Property PER02 As String

        '''<summary>Communication Number Qualifier</summary>
        '''<remarks></remarks>
        Property PER03 As String

        '''<summary>Communication Number</summary>
        '''<remarks></remarks>
        Property PER04 As String

        '''<summary>Communication Number Qualifier</summary>
        '''<remarks></remarks>
        Property PER05 As String

        '''<summary>Communication Number</summary>
        '''<remarks></remarks>
        Property PER06 As String

        '''<summary>Communication Number Qualifier</summary>
        '''<remarks></remarks>
        Property PER07 As String

        '''<summary>Communication Number</summary>
        '''<remarks></remarks>
        Property PER08 As String

        '''<summary>Contact Inquiry Reference</summary>
        '''<remarks></remarks>
        Property PER09 As String

    End Interface
End NameSpace