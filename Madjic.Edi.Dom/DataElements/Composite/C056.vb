Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Composite Race or Ethnicity Information</summary>
    '''<remarks>To send general and detailed information on race or ethnicity</remarks>
    Partial Friend Class C056_Obj
        Inherits CompositeElement
        Implements C056
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1109),
                                         CType(Nothing, Element1270),
                                         CType(Nothing, Element1271)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification := "<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C056_01 As String Implements C056.C056_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1109).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1109
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1109).Value = value
                End If
            End Set
        End Property

        Friend Property C056_02 As String Implements C056.C056_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1270
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property C056_03 As String Implements C056.C056_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1271
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1271).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C056_Obj
            Dim rval As New C056_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C056_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C056_02 = values(1)
                End If
                If values.Length > 2 Then
                    .C056_03 = values(2)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Composite Race or Ethnicity Information</summary>
    '''<remarks>To send general and detailed information on race or ethnicity</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C056
        '''<summary>Race or Ethnicity Code</summary>
        '''<remarks> 
        '''<para>Code indicating the racial or ethnic background of a person; it is normally self-reported; Under certain circumstances this information is collected for United States Government statistical purposes</para>
        '''</remarks>
        Property C056_01 As String

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks> 
        '''<para>Code identifying a specific industry code list</para>
        '''</remarks>
        Property C056_02 As String

        '''<summary>Industry Code</summary>
        '''<remarks> 
        '''<para>Code indicating a code from a specific industry code list</para>
        '''</remarks>
        Property C056_03 As String
    End Interface
End Namespace