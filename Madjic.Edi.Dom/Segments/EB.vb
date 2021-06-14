Namespace Segments
    '''<summary>Eligibility or Benefit Information</summary>
    '''<remarks>To supply eligibility or benefit information</remarks>
    Partial Friend Class EB_Obj
        Inherits Segment
        Implements EB,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({9, 10}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("EB")
            Elements.AddRange({CType(Nothing, DataElements.Element1390),
                                      CType(Nothing, DataElements.Element1207),
                                      CType(Nothing, DataElements.Element1365),
                                      CType(Nothing, DataElements.Element1336),
                                      CType(Nothing, DataElements.Element1204),
                                      CType(Nothing, DataElements.Element615),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element673),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Composite.C004_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property EB01 As String Implements EB.EB01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1390).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1390
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1390).Value = value
                End If
            End Set
        End Property

        Friend Property EB02 As String Implements EB.EB02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1207).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1207
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1207).Value = value
                End If
            End Set
        End Property

        Friend Property EB03 As String Implements EB.EB03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1365
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1365).Value = value
                End If
            End Set
        End Property

        Friend Property EB04 As String Implements EB.EB04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1336).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1336
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1336).Value = value
                End If
            End Set
        End Property

        Friend Property EB05 As String Implements EB.EB05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1204).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1204
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1204).Value = value
                End If
            End Set
        End Property

        Friend Property EB06 As String Implements EB.EB06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element615).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element615
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element615).Value = value
                End If
            End Set
        End Property

        Friend Property EB07 As Decimal? Implements EB.EB07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element782
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property EB08 As Decimal? Implements EB.EB08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB08, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element954
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property EB09 As String Implements EB.EB09, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB09, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element673).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element673
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element673).Value = value
                End If
            End Set
        End Property

        Friend Property EB10 As Decimal? Implements EB.EB10, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB10, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element380
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property EB11 As String Implements EB.EB11, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB11, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1073
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property EB12 As String Implements EB.EB12, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB12, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1073
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property EB13 As DataElements.Composite.C003 Implements EB.EB13
            Get
                Return CType(Elements(12), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(12) = value
            End Set
        End Property

        Private Property EB13_IFace As Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13.C003 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB13
            Get
                Return CType(EB13, Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13.C003)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2110C.EB.EB_13.C003)
                EB13 = value
            End Set
        End Property

        Private Property EB13_IFace_1 As Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13.C003 Implements Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB13
            Get
                Return CType(EB13, Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13.C003)
            End Get
            Set(value As Transactions.Transaction271.Transaction271_B1.Composites.Loop2110D.EB.EB_13.C003)
                EB13 = value
            End Set
        End Property

        Friend Property EB14 As DataElements.Composite.C004 Implements EB.EB14, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110C.EB.EB14, Transactions.Transaction271.Transaction271_B1.Segments.Loop2110D.EB.EB14
            Get
                Return CType(Elements(13), DataElements.Composite.C004_Obj)
            End Get
            Set(value As DataElements.Composite.C004)
                Elements(13) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As EB
            Dim rval As New EB_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .EB01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .EB02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .EB03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .EB04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .EB05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .EB06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .EB07 = source.ToFloatValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .EB08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .EB09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .EB10 = source.ToFloatValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .EB11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .EB12 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .Elements(12) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(12), reader)
                End If
                If source.Elements.Count > 13 Then
                    .Elements(13) = DataElements.Composite.C004_Obj.FromReader(source.ToStringValue(13), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Eligibility or Benefit Information</summary>
    '''<remarks>To supply eligibility or benefit information</remarks>
    Public Interface EB
        Inherits ISegment

        '''<summary>Eligibility or Benefit Information Code</summary>
        '''<remarks>EB01 qualifies EB06 through EB10.</remarks>
        Property EB01 As String

        '''<summary>Coverage Level Code</summary>
        '''<remarks></remarks>
        Property EB02 As String

        '''<summary>Service Type Code</summary>
        '''<remarks>Position of data in the repeating data element conveys no significance.</remarks>
        Property EB03 As String

        '''<summary>Insurance Type Code</summary>
        '''<remarks></remarks>
        Property EB04 As String

        '''<summary>Plan Coverage Description</summary>
        '''<remarks></remarks>
        Property EB05 As String

        '''<summary>Time Period Qualifier</summary>
        '''<remarks></remarks>
        Property EB06 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property EB07 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks></remarks>
        Property EB08 As Decimal?

        '''<summary>Quantity Qualifier</summary>
        '''<remarks></remarks>
        Property EB09 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property EB10 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>EB11 is the authorization or certification indicator. A "Y" value indicates that an authorization or certification is required per plan provisions. An "N" value indicates that an authorization or certification is not required per plan provisions. A "U" value indicates it is unknown whether the plan provisions require an authorization or certification.</remarks>
        Property EB11 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>EB12 is the plan network indicator. A "Y" value indicates the benefits identified are considered In-Plan-Network. An "N" value indicates that the benefits identified are considered Out-Of-Plan-Network. A "U" value indicates it is unknown whether the benefits identified are part of the Plan Network.</remarks>
        Property EB12 As String

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property EB13 As DataElements.Composite.C003

        '''<summary>Composite Diagnosis Code Pointer</summary>
        '''<remarks></remarks>
        Property EB14 As DataElements.Composite.C004

    End Interface
End NameSpace