Namespace Segments
    '''<summary>Payroll Deduction</summary>
    '''<remarks>To specify payroll deduction information</remarks>
    Partial Friend Class PYD_Obj
        Inherits Segment
        Implements PYD
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PYD")
            Elements.AddRange({CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element1685),
                                      CType(Nothing, DataElements.Element1688),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PYD01 As Decimal? Implements PYD.PYD01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element782
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property PYD02 As String Implements PYD.PYD02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element594
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property PYD03 As String Implements PYD.PYD03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1685).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1685
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1685).Value = value
                End If
            End Set
        End Property

        Friend Property PYD04 As String Implements PYD.PYD04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1688).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1688
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1688).Value = value
                End If
            End Set
        End Property

        Friend Property PYD05 As String Implements PYD.PYD05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element352
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PYD
            Dim rval As New PYD_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PYD01 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PYD02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PYD03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PYD04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PYD05 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Payroll Deduction</summary>
    '''<remarks>To specify payroll deduction information</remarks>
    Public Interface PYD
        Inherits ISegment

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property PYD01 As Decimal?

        '''<summary>Frequency Code</summary>
        '''<remarks></remarks>
        Property PYD02 As String

        '''<summary>Tax Treatment Code</summary>
        '''<remarks></remarks>
        Property PYD03 As String

        '''<summary>Deduction Type Code</summary>
        '''<remarks></remarks>
        Property PYD04 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property PYD05 As String

    End Interface
End NameSpace