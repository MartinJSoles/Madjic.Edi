Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Adjustment Identifier</summary>
    '''<remarks>To provide the category and identifying reference information for an adjustment</remarks>
    Partial Friend Class C042_Obj
        Inherits CompositeElement
        Implements C042
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element426),
                                         CType(Nothing, Element127)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification := "<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C042_01 As String Implements C042.C042_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element426).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element426
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element426).Value = value
                End If
            End Set
        End Property

        Friend Property C042_02 As String Implements C042.C042_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element127).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element127
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element127).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C042_Obj
            Dim rval As New C042_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C042_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C042_02 = values(1)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Adjustment Identifier</summary>
    '''<remarks>To provide the category and identifying reference information for an adjustment</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C042
        '''<summary>Adjustment Reason Code</summary>
        '''<remarks> 
        '''<para>Code indicating reason for debit or credit memo or adjustment to invoice, debit or credit memo, or payment</para>
        '''</remarks>
        Property C042_01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks> 
        '''<para>Reference information as defined for a particular Transaction Set or as specified by the Reference Identification Qualifier</para>
        '''</remarks>
        Property C042_02 As String
    End Interface
End Namespace