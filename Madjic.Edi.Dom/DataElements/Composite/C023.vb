Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Health Care Service Location Information</summary>
    '''<remarks>To provide information that identifies the place of service or the type of bill related to the location at which a health care service was rendered</remarks>
    Partial Friend Class C023_Obj
        Inherits CompositeElement
        Implements C023,
                   Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.
            C023, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023,
                   Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04.
            C023, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04.C023,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_05.
            C023,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_05.
            C023,
                   Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.CLM_05.
            C023
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1331),
                                         CType(Nothing, Element1332),
                                         CType(Nothing, Element1325)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C023_01 As String _
            Implements C023.C023_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04 _
                .C023.C023_01,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04 _
                .C023.C023_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04 _
                .C023.C023_01,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04 _
                .C023.C023_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_05.C023.C023_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_05.C023.C023_01,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.
                CLM_05.C023.C023_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1331).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1331
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1331).Value = value
                End If
            End Set
        End Property

        Friend Property C023_02 As String _
            Implements C023.C023_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04 _
                .C023.C023_02,
                       Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04 _
                .C023.C023_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04 _
                .C023.C023_02,
                       Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04 _
                .C023.C023_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_05.C023.C023_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_05.C023.C023_02,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.
                CLM_05.C023.C023_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1332).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1332
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1332).Value = value
                End If
            End Set
        End Property

        Friend Property C023_03 As String _
            Implements C023.C023_03,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_05.C023.C023_03,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_05.C023.C023_03,
                       Transactions.Transaction837.Transaction837_Q3.Composites.Loop2300.CLM.
                CLM_05.C023.C023_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1325).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1325
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1325).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C023_01 = values(0)
            End If
            If values.Length > 1 Then
                C023_02 = values(1)
            End If
            If values.Length > 2 Then
                C023_03 = values(2)
            End If
        End Sub
        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C023_Obj
            Dim rval As New C023_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Health Care Service Location Information</summary>
    '''<remarks>To provide information that identifies the place of service or the type of bill related to the location at which a health care service was rendered</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C023
        '''<summary>Facility Code Value</summary>
        '''<remarks> 
        '''<para>Code identifying where services were, or may be, performed; the first and second positions of the Uniform Bill Type Code for Institutional Services or the Place of Service Codes for Professional or Dental Services.</para>
        '''</remarks>
        Property C023_01 As String

        '''<summary>Facility Code Qualifier</summary>
        '''<remarks> 
        '''<para>Code identifying the type of facility referenced</para>
        '''</remarks>
        Property C023_02 As String

        '''<summary>Claim Frequency Type Code</summary>
        '''<remarks> 
        '''<para>Code specifying the frequency of the claim; this is the third position of the Uniform Billing Claim Form Bill Type</para>
        '''</remarks>
        Property C023_03 As String
    End Interface
End Namespace