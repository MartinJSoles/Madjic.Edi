Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Oral Cavity Designation</summary>
    '''<remarks>To identify one or more areas of the oral cavity</remarks>
    Partial Friend Class C006_Obj
        Inherits CompositeElement
        Implements C006
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1361),
                                         CType(Nothing, Element1361),
                                         CType(Nothing, Element1361),
                                         CType(Nothing, Element1361),
                                         CType(Nothing, Element1361)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification := "<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C006_01 As String Implements C006.C006_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1361).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1361
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1361).Value = value
                End If
            End Set
        End Property

        Friend Property C006_02 As String Implements C006.C006_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1361).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1361
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1361).Value = value
                End If
            End Set
        End Property

        Friend Property C006_03 As String Implements C006.C006_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1361).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1361
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1361).Value = value
                End If
            End Set
        End Property

        Friend Property C006_04 As String Implements C006.C006_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1361).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1361
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1361).Value = value
                End If
            End Set
        End Property

        Friend Property C006_05 As String Implements C006.C006_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element1361).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element1361
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element1361).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C006_Obj
            Dim rval As New C006_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C006_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C006_02 = values(1)
                End If
                If values.Length > 2 Then
                    .C006_03 = values(2)
                End If
                If values.Length > 3 Then
                    .C006_04 = values(3)
                End If
                If values.Length > 4 Then
                    .C006_05 = values(4)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Oral Cavity Designation</summary>
    '''<remarks>To identify one or more areas of the oral cavity</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C006
        '''<summary>Oral Cavity Designation Code</summary>
        '''<remarks> 
        '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
        '''</remarks>
        Property C006_01 As String

        '''<summary>Oral Cavity Designation Code</summary>
        '''<remarks> 
        '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
        '''</remarks>
        Property C006_02 As String

        '''<summary>Oral Cavity Designation Code</summary>
        '''<remarks> 
        '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
        '''</remarks>
        Property C006_03 As String

        '''<summary>Oral Cavity Designation Code</summary>
        '''<remarks> 
        '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
        '''</remarks>
        Property C006_04 As String

        '''<summary>Oral Cavity Designation Code</summary>
        '''<remarks> 
        '''<para>Code Identifying the area of the oral cavity in which service is rendered</para>
        '''</remarks>
        Property C006_05 As String
    End Interface
End Namespace