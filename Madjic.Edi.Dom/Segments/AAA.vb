Namespace Segments

    '''<summary>Request Validation</summary>
    '''<remarks>To specify the validity of the request and indicate follow-up action authorized</remarks>
    Partial Friend Class AAA_Obj
        Inherits Segment
        Implements AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.AAA,
               Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA,
               Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Friend Sub New()
            MyBase.New("AAA")
            Elements.AddRange({CType(Nothing, DataElements.Element1073),
                                        CType(Nothing, DataElements.Element559),
                                        CType(Nothing, DataElements.Element901),
                                        CType(Nothing, DataElements.Element889)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()

        End Sub

        Friend Property AAA01 As String Implements AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.AAA.AAA01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA.AAA01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA.AAA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1073
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property AAA02 As String Implements AAA.AAA02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element559
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property AAA03 As String Implements AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.AAA.AAA03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA.AAA03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA.AAA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element901).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element901
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element901).Value = value
                End If
            End Set
        End Property

        Friend Property AAA04 As String Implements AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000A.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100A.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100B.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.AAA.AAA04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000A.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010A.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010B.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010C.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010D.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EA.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010EC.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.AAA.AAA04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2010FA.AAA.AAA04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element889).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element889
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element889).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AAA
            Dim rval As New AAA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AAA01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AAA02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .AAA03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .AAA04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Request Validation</summary>
    '''<remarks>To specify the validity of the request and indicate follow-up action authorized</remarks>
    Public Interface AAA
        Inherits ISegment

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>AAA01 designates whether the request is valid or invalid. Code "Y" indicates that the code is valid; code "N" indicates that the code is invalid.</remarks>
        Property AAA01 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks>If AAA02 is used, AAA03 contains a code from an industry code list.</remarks>
        Property AAA02 As String

        '''<summary>Reject Reason Code</summary>
        '''<remarks></remarks>
        Property AAA03 As String

        '''<summary>Follow-up Action Code</summary>
        '''<remarks></remarks>
        Property AAA04 As String

    End Interface
End NameSpace