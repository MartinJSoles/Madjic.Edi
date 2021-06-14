Namespace Segments
    '''<summary>Implementation Data Segment Note</summary>
    '''<remarks>To report implementation errors in a data segment and identify the location of the data segment</remarks>
    Partial Friend Class IK3_Obj
        Inherits Segment
        Implements IK3,
                   Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("IK3")
            Elements.AddRange({CType(Nothing, DataElements.Element721),
                                      CType(Nothing, DataElements.Element719),
                                      CType(Nothing, DataElements.Element447),
                                      CType(Nothing, DataElements.Element620)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property IK301 As String Implements IK3.IK301, Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3.IK301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element721).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element721
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element721).Value = value
                End If
            End Set
        End Property

        Friend Property IK302 As Decimal? Implements IK3.IK302, Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3.IK302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element719).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element719
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element719).Value = value
                End If
            End Set
        End Property

        Friend Property IK303 As String Implements IK3.IK303, Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3.IK303
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element447).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element447
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element447).Value = value
                End If
            End Set
        End Property

        Friend Property IK304 As String Implements IK3.IK304, Transactions.Transaction999.Transaction999.Segments.Loop2000.IK3.IK304
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element620).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element620
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element620).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As IK3
            Dim rval As New IK3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .IK301 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .IK302 = source.ToDecimalValue(1, 0)
                End If
                If source.Elements.Count > 2 Then
                    .IK303 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .IK304 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Implementation Data Segment Note</summary>
    '''<remarks>To report implementation errors in a data segment and identify the location of the data segment</remarks>
    Public Interface IK3
        Inherits ISegment

        '''<summary>Segment ID Code</summary>
        '''<remarks></remarks>
        Property IK301 As String

        '''<summary>Segment Position in Transaction Set</summary>
        '''<remarks></remarks>
        Property IK302 As Decimal?

        '''<summary>Loop Identifier Code</summary>
        '''<remarks></remarks>
        Property IK303 As String

        '''<summary>Implementation Segment Syntax Error Code</summary>
        '''<remarks></remarks>
        Property IK304 As String

    End Interface
End NameSpace