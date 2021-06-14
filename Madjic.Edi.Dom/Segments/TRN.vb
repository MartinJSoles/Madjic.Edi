Namespace Segments
    '''<summary>Trace</summary>
    '''<remarks>To uniquely identify a transaction to an application</remarks>
    Partial Friend Class TRN_Obj
        Inherits Segment
        Implements TRN,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.TRN,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.TRN,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.TRN,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.TRN,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.TRN,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.TRN,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN,
                   Transactions.Transaction820.Transaction820_A1.Segments.TRN,
                   Transactions.Transaction835.Transaction835_W1.Segments.TRN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("TRN")
            Elements.AddRange({CType(Nothing, DataElements.Element481),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element509),
                                      CType(Nothing, DataElements.Element127)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TRN01 As String Implements TRN.TRN01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN.TRN01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN.TRN01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.TRN.TRN01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.TRN.TRN01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.TRN.TRN01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.TRN.TRN01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.TRN.TRN01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.TRN.TRN01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN.TRN01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN.TRN01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN.TRN01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN.TRN01, Transactions.Transaction820.Transaction820_A1.Segments.TRN.TRN01, Transactions.Transaction835.Transaction835_W1.Segments.TRN.TRN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element481).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element481
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element481).Value = value
                End If
            End Set
        End Property

        Friend Property TRN02 As String Implements TRN.TRN02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN.TRN02, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN.TRN02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.TRN.TRN02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.TRN.TRN02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.TRN.TRN02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.TRN.TRN02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.TRN.TRN02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.TRN.TRN02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN.TRN02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN.TRN02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN.TRN02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN.TRN02, Transactions.Transaction820.Transaction820_A1.Segments.TRN.TRN02, Transactions.Transaction835.Transaction835_W1.Segments.TRN.TRN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element127
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property TRN03 As String Implements TRN.TRN03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN.TRN03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN.TRN03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.TRN.TRN03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.TRN.TRN03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN.TRN03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN.TRN03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN.TRN03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN.TRN03, Transactions.Transaction820.Transaction820_A1.Segments.TRN.TRN03, Transactions.Transaction835.Transaction835_W1.Segments.TRN.TRN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element509).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element509
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element509).Value = value
                End If
            End Set
        End Property

        Friend Property TRN04 As String Implements TRN.TRN04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN.TRN04, Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN.TRN04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000C.TRN.TRN04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2000D.TRN.TRN04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.TRN.TRN04, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TRN.TRN04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.TRN.TRN04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TRN.TRN04, Transactions.Transaction820.Transaction820_A1.Segments.TRN.TRN04, Transactions.Transaction835.Transaction835_W1.Segments.TRN.TRN04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element127
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TRN
            Dim rval As New TRN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TRN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TRN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .TRN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .TRN04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Trace</summary>
    '''<remarks>To uniquely identify a transaction to an application</remarks>
    Public Interface TRN
        Inherits ISegment

        '''<summary>Trace Type Code</summary>
        '''<remarks></remarks>
        Property TRN01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>TRN02 provides unique identification for the transaction.</remarks>
        Property TRN02 As String

        '''<summary>Originating Company Identifier</summary>
        '''<remarks>TRN03 identifies an organization.</remarks>
        Property TRN03 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>TRN04 identifies a further subdivision within the organization.</remarks>
        Property TRN04 As String

    End Interface
End NameSpace