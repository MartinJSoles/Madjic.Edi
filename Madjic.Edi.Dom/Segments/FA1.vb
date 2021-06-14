Namespace Segments
    '''<summary>Type of Financial Accounting Data</summary>
    '''<remarks>To specify the organization controlling the content of the accounting citation, and the purpose associated with the accounting citation</remarks>
    Partial Friend Class FA1_Obj
        Inherits Segment
        Implements FA1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("FA1")
            Elements.AddRange({CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element1300),
                                      CType(Nothing, DataElements.Element248)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property FA101 As String Implements FA1.FA101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element559
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property FA102 As String Implements FA1.FA102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1300).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1300
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1300).Value = value
                End If
            End Set
        End Property

        Friend Property FA103 As String Implements FA1.FA103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element248).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element248
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element248).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As FA1
            Dim rval As New FA1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .FA101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .FA102 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .FA103 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Type of Financial Accounting Data</summary>
    '''<remarks>To specify the organization controlling the content of the accounting citation, and the purpose associated with the accounting citation</remarks>
    Public Interface FA1
        Inherits ISegment

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks></remarks>
        Property FA101 As String

        '''<summary>Service, Promotion, Allowance, or Charge Code</summary>
        '''<remarks></remarks>
        Property FA102 As String

        '''<summary>Allowance or Charge Indicator</summary>
        '''<remarks></remarks>
        Property FA103 As String

    End Interface
End NameSpace