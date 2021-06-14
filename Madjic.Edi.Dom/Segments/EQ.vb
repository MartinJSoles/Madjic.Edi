Namespace Segments
    '''<summary>Eligibility or Benefit Inquiry</summary>
    '''<remarks>To specify inquired eligibility or benefit information</remarks>
    Partial Friend Class EQ_Obj
        Inherits Segment
        Implements EQ,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ,
                   Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleRequired({1, 2})}

        Public Sub New()
            MyBase.New("EQ")
            Elements.AddRange({CType(Nothing, DataElements.Element1365),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element1207),
                                      CType(Nothing, DataElements.Element1336),
                                      CType(Nothing, DataElements.Composite.C004_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property EQ01 As String Implements EQ.EQ01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ.EQ01, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ.EQ01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1365
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1365).Value = value
                End If
            End Set
        End Property

        Friend Property EQ02 As DataElements.Composite.C003 Implements EQ.EQ02
            Get
                Return CType(Elements(1), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(1) = value
            End Set
        End Property

        Private Property EQ02_IFace As Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02.C003 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ.EQ02
            Get
                Return CType(EQ02, Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02.C003)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2110C.EQ.EQ_02.C003)
                EQ02 = value
            End Set
        End Property

        Private Property EQ02_IFace_1 As Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02.C003 Implements Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ.EQ02
            Get
                Return CType(EQ02, Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02.C003)
            End Get
            Set(value As Transactions.Transaction270.Transaction270_B1.Composites.Loop2110D.EQ.EQ_02.C003)
                EQ02 = value
            End Set
        End Property

        Friend Property EQ03 As String Implements EQ.EQ03, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ.EQ03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1207).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1207
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1207).Value = value
                End If
            End Set
        End Property

        Friend Property EQ04 As String Implements EQ.EQ04
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

        Friend Property EQ05 As DataElements.Composite.C004 Implements EQ.EQ05, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ.EQ05, Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ.EQ05
            Get
                Return CType(Elements(4), DataElements.Composite.C004_Obj)
            End Get
            Set(value As DataElements.Composite.C004)
                Elements(4) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As EQ
            Dim rval As New EQ_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .EQ01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .Elements(1) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(1), reader)
                End If
                If source.Elements.Count > 2 Then
                    .EQ03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .EQ04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C004_Obj.FromReader(source.ToStringValue(4), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Eligibility or Benefit Inquiry</summary>
    '''<remarks>To specify inquired eligibility or benefit information</remarks>
    Public Interface EQ
        Inherits ISegment

        '''<summary>Service Type Code</summary>
        '''<remarks>Position of data in the repeating data element conveys no significance.</remarks>
        Property EQ01 As String

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property EQ02 As DataElements.Composite.C003

        '''<summary>Coverage Level Code</summary>
        '''<remarks></remarks>
        Property EQ03 As String

        '''<summary>Insurance Type Code</summary>
        '''<remarks></remarks>
        Property EQ04 As String

        '''<summary>Composite Diagnosis Code Pointer</summary>
        '''<remarks></remarks>
        Property EQ05 As DataElements.Composite.C004

    End Interface
End NameSpace