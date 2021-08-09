Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Related Causes Information</summary>
    '''<remarks>To identify one or more related causes and associated state or country information</remarks>
    Partial Friend Class C024_Obj
        Inherits CompositeElement
        Implements C024,
                   Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.CLM_11.
            C024,
                   Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.CLM_11.
            C024
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1362),
                                         CType(Nothing, Element1362),
                                         CType(Nothing, Element1362),
                                         CType(Nothing, Element156),
                                         CType(Nothing, Element26)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C024_01 As String _
            Implements C024.C024_01,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_11.C024.C024_01,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_11.C024.C024_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1362).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1362
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1362).Value = value
                End If
            End Set
        End Property

        Friend Property C024_02 As String _
            Implements C024.C024_02,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_11.C024.C024_02,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_11.C024.C024_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1362).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1362
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1362).Value = value
                End If
            End Set
        End Property

        Friend Property C024_03 As String Implements C024.C024_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1362).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1362
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1362).Value = value
                End If
            End Set
        End Property

        Friend Property C024_04 As String _
            Implements C024.C024_04,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_11.C024.C024_04,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_11.C024.C024_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element156).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element156
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element156).Value = value
                End If
            End Set
        End Property

        Friend Property C024_05 As String _
            Implements C024.C024_05,
                       Transactions.Transaction837.Transaction837_Q1.Composites.Loop2300.CLM.
                CLM_11.C024.C024_05,
                       Transactions.Transaction837.Transaction837_Q2.Composites.Loop2300.CLM.
                CLM_11.C024.C024_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element26).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element26
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element26).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C024_01 = values(0)
            End If
            If values.Length > 1 Then
                C024_02 = values(1)
            End If
            If values.Length > 2 Then
                C024_03 = values(2)
            End If
            If values.Length > 3 Then
                C024_04 = values(3)
            End If
            If values.Length > 4 Then
                C024_05 = values(4)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C024_Obj
            Dim rval As New C024_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Related Causes Information</summary>
    '''<remarks>To identify one or more related causes and associated state or country information</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C024
        '''<summary>Related-Causes Code</summary>
        '''<remarks> 
        '''<para>Code identifying an accompanying cause of an illness, injury or an accident</para>
        '''</remarks>
        Property C024_01 As String

        '''<summary>Related-Causes Code</summary>
        '''<remarks> 
        '''<para>Code identifying an accompanying cause of an illness, injury or an accident</para>
        '''</remarks>
        Property C024_02 As String

        '''<summary>Related-Causes Code</summary>
        '''<remarks> 
        '''<para>Code identifying an accompanying cause of an illness, injury or an accident</para>
        '''</remarks>
        Property C024_03 As String

        '''<summary>State or Province Code</summary>
        '''<remarks> 
        '''<para>Code (Standard State/Province) as defined by appropriate government agency</para>
        '''</remarks>
        Property C024_04 As String

        '''<summary>Country Code</summary>
        '''<remarks> 
        '''<para>Code identifying the country</para>
        '''</remarks>
        Property C024_05 As String
    End Interface
End Namespace