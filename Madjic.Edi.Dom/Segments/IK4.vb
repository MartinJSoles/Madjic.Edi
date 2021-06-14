Namespace Segments
    '''<summary>Implementation Data Element Note</summary>
    '''<remarks>To report implementation errors in a data element or composite data structure and identify the location of the data element</remarks>
    Partial Friend Class IK4_Obj
        Inherits Segment
        Implements IK4,
                   Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 3})}

        Public Sub New()
            MyBase.New("IK4")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C030_Obj),
                                      CType(Nothing, DataElements.Element725),
                                      CType(Nothing, DataElements.Element621),
                                      CType(Nothing, DataElements.Element724)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property IK401 As DataElements.Composite.C030 Implements IK4.IK401, Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4.IK401
            Get
                Return CType(Elements(0), DataElements.Composite.C030_Obj)
            End Get
            Set(value As DataElements.Composite.C030)
                Elements(0) = value
            End Set
        End Property

        Friend Property IK402 As Decimal? Implements IK4.IK402, Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4.IK402
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element725).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element725
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element725).Value = value
                End If
            End Set
        End Property

        Friend Property IK403 As String Implements IK4.IK403, Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4.IK403
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element621).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element621
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element621).Value = value
                End If
            End Set
        End Property

        Friend Property IK404 As String Implements IK4.IK404, Transactions.Transaction999.Transaction999.Segments.Loop3000.IK4.IK404
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element724).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element724
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element724).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IK4
            Dim rval As New IK4_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C030_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .IK402 = source.ToDecimalValue(1, 0)
                End If
                If source.Elements.Count > 2 Then
                    .IK403 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IK404 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Implementation Data Element Note</summary>
    '''<remarks>To report implementation errors in a data element or composite data structure and identify the location of the data element</remarks>
    Public Interface IK4
        Inherits ISegment

        '''<summary>Position in Segment</summary>
        '''<remarks></remarks>
        Property IK401 As DataElements.Composite.C030

        '''<summary>Data Element Reference Number</summary>
        '''<remarks></remarks>
        Property IK402 As Decimal?

        '''<summary>Implementation Data Element Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK403 As String

        '''<summary>Copy of Bad Data Element</summary>
        '''<remarks></remarks>
        Property IK404 As String

    End Interface
End NameSpace