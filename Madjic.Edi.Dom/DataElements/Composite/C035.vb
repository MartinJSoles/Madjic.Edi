Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Provider Specialty Information</summary>
    '''<remarks>To provide provider specialty information</remarks>
    Partial Friend Class C035_Obj
        Inherits CompositeElement
        Implements C035
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1222),
                                         CType(Nothing, Element559),
                                         CType(Nothing, Element1073)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C035_01 As String Implements C035.C035_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1222).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1222
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1222).Value = value
                End If
            End Set
        End Property

        Friend Property C035_02 As String Implements C035.C035_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element559).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element559
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element559).Value = value
                End If
            End Set
        End Property

        Friend Property C035_03 As String Implements C035.C035_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1073
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1073).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C035_01 = values(0)
            End If
            If values.Length > 1 Then
                C035_02 = values(1)
            End If
            If values.Length > 2 Then
                C035_03 = values(2)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C035_Obj
            Dim rval As New C035_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Provider Specialty Information</summary>
    '''<remarks>To provide provider specialty information</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C035
        '''<summary>Provider Specialty Code</summary>
        '''<remarks> 
        '''<para>Code indicating the primary specialty of the provider, as defined by the receiver</para>
        '''</remarks>
        Property C035_01 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks> 
        '''<para>Code identifying the agency assigning the code values</para>
        '''</remarks>
        Property C035_02 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks> 
        '''<para>Code indicating a Yes or No condition or response</para>
        '''</remarks>
        Property C035_03 As String
    End Interface
End Namespace