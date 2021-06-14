Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Context Identification</summary>
    '''<remarks>Holds information to identify a context</remarks>
    Partial Friend Class C998_Obj
        Inherits CompositeElement
        Implements C998
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element9999),
                                         CType(Nothing, Element9998)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification := "<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C998_01 As String Implements C998.C998_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element9999).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element9999
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element9999).Value = value
                End If
            End Set
        End Property

        Friend Property C998_02 As String Implements C998.C998_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element9998).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element9998
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element9998).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C998_Obj
            Dim rval As New C998_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C998_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C998_02 = values(1)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Context Identification</summary>
    '''<remarks>Holds information to identify a context</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C998
        '''<summary>Context Name</summary>
        '''<remarks> 
        '''<para>Holds the name or 'tag' or a context</para>
        '''</remarks>
        Property C998_01 As String

        '''<summary>Context Reference</summary>
        '''<remarks> 
        '''<para>Holds a reference to or for a context</para>
        '''</remarks>
        Property C998_02 As String
    End Interface
End Namespace