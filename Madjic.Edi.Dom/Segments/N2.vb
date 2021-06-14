Namespace Segments
    '''<summary>Additional Name Information</summary>
    '''<remarks>To specify additional names</remarks>
    Partial Friend Class N2_Obj
        Inherits Segment
        Implements N2,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("N2")
            Elements.AddRange({CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element93)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property N201 As String Implements N2.N201, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.N2.N201, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000B.N2.N201, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000C.N2.N201
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element93
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property N202 As String Implements N2.N202
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As N2
            Dim rval As New N2_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .N201 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .N202 = source.ToStringValue(1)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Additional Name Information</summary>
    '''<remarks>To specify additional names</remarks>
    Public Interface N2
        Inherits ISegment

        '''<summary>Name</summary>
        '''<remarks></remarks>
        Property N201 As String

        '''<summary>Name</summary>
        '''<remarks></remarks>
        Property N202 As String

    End Interface
End NameSpace