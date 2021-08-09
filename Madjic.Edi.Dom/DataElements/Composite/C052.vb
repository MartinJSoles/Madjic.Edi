Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Medicare Status Code</summary>
    '''<remarks>To provide Medicare coverage and associated reason for Medicare eligibility</remarks>
    Partial Friend Class C052_Obj
        Inherits CompositeElement
        Implements C052,
                   Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.INS_06.
            C052
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1218),
                                         CType(Nothing, Element1701),
                                         CType(Nothing, Element1701),
                                         CType(Nothing, Element1701)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C052_01 As String _
            Implements C052.C052_01,
                       Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.
                INS_06.C052.C052_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1218).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1218
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1218).Value = value
                End If
            End Set
        End Property

        Friend Property C052_02 As String _
            Implements C052.C052_02,
                       Transactions.Transaction834.Transaction834_A1.Composites.Loop2000.INS.
                INS_06.C052.C052_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1701).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1701
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1701).Value = value
                End If
            End Set
        End Property

        Friend Property C052_03 As String Implements C052.C052_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1701).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1701
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1701).Value = value
                End If
            End Set
        End Property

        Friend Property C052_04 As String Implements C052.C052_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1701).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1701
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1701).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C052_01 = values(0)
            End If
            If values.Length > 1 Then
                C052_02 = values(1)
            End If
            If values.Length > 2 Then
                C052_03 = values(2)
            End If
            If values.Length > 3 Then
                C052_04 = values(3)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C052_Obj
            Dim rval As New C052_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Medicare Status Code</summary>
    '''<remarks>To provide Medicare coverage and associated reason for Medicare eligibility</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C052
        '''<summary>Medicare Plan Code</summary>
        '''<remarks> 
        '''<para>Code identifying the Medicare Plan</para>
        '''</remarks>
        Property C052_01 As String

        '''<summary>Eligibility Reason Code</summary>
        '''<remarks> 
        '''<para>Code specifying reason for eligibility</para>
        '''</remarks>
        Property C052_02 As String

        '''<summary>Eligibility Reason Code</summary>
        '''<remarks> 
        '''<para>Code specifying reason for eligibility</para>
        '''</remarks>
        Property C052_03 As String

        '''<summary>Eligibility Reason Code</summary>
        '''<remarks> 
        '''<para>Code specifying reason for eligibility</para>
        '''</remarks>
        Property C052_04 As String
    End Interface
End Namespace