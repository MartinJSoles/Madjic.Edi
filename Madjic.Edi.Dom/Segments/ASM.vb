Namespace Segments
    '''<summary>Amount and Settlement Method</summary>
    '''<remarks>Defines a participant's monetary commitment and settlement method</remarks>
    Partial Friend Class ASM_Obj
        Inherits Segment
        Implements ASM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("ASM")
            Elements.AddRange({CType(Nothing, DataElements.Element610),
                                      CType(Nothing, DataElements.Element107),
                                      CType(Nothing, DataElements.Element522)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ASM01 As Decimal? Implements ASM.ASM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element610).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element610
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element610).Value = value
                End If
            End Set
        End Property

        Friend Property ASM02 As String Implements ASM.ASM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element107).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element107
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element107).Value = value
                End If
            End Set
        End Property

        Friend Property ASM03 As String Implements ASM.ASM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element522).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element522
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element522).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ASM
            Dim rval As New ASM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ASM01 = source.ToDecimalValue(0, 2)
                End If
                If source.Elements.Count > 1 Then
                    .ASM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ASM03 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Amount and Settlement Method</summary>
    '''<remarks>Defines a participant's monetary commitment and settlement method</remarks>
    Public Interface ASM
        Inherits ISegment

        '''<summary>Amount</summary>
        '''<remarks></remarks>
        Property ASM01 As Decimal?

        '''<summary>Payment Method Type Code</summary>
        '''<remarks></remarks>
        Property ASM02 As String

        '''<summary>Amount Qualifier Code</summary>
        '''<remarks></remarks>
        Property ASM03 As String

    End Interface
End NameSpace