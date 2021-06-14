Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Tooth Surface</summary>
    '''<remarks>To identify one or more tooth surface codes</remarks>
    Partial Friend Class C005_Obj
        Inherits CompositeElement
        Implements C005
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1369),
                                         CType(Nothing, Element1369),
                                         CType(Nothing, Element1369),
                                         CType(Nothing, Element1369),
                                         CType(Nothing, Element1369)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C005_01 As String Implements C005.C005_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1369).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1369
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1369).Value = value
                End If
            End Set
        End Property

        Friend Property C005_02 As String Implements C005.C005_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1369).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1369
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1369).Value = value
                End If
            End Set
        End Property

        Friend Property C005_03 As String Implements C005.C005_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1369).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1369
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1369).Value = value
                End If
            End Set
        End Property

        Friend Property C005_04 As String Implements C005.C005_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1369).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1369
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1369).Value = value
                End If
            End Set
        End Property

        Friend Property C005_05 As String Implements C005.C005_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element1369).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element1369
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element1369).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C005_Obj
            Dim rval As New C005_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C005_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C005_02 = values(1)
                End If
                If values.Length > 2 Then
                    .C005_03 = values(2)
                End If
                If values.Length > 3 Then
                    .C005_04 = values(3)
                End If
                If values.Length > 4 Then
                    .C005_05 = values(4)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Tooth Surface</summary>
    '''<remarks>To identify one or more tooth surface codes</remarks>
    Public Interface C005
        '''<summary>Tooth Surface Code</summary>
        '''<remarks> 
        '''<para>Code identifying the area of the tooth that was treated</para>
        '''</remarks>
        Property C005_01 As String

        '''<summary>Tooth Surface Code</summary>
        '''<remarks> 
        '''<para>Code identifying the area of the tooth that was treated</para>
        '''</remarks>
        Property C005_02 As String

        '''<summary>Tooth Surface Code</summary>
        '''<remarks> 
        '''<para>Code identifying the area of the tooth that was treated</para>
        '''</remarks>
        Property C005_03 As String

        '''<summary>Tooth Surface Code</summary>
        '''<remarks> 
        '''<para>Code identifying the area of the tooth that was treated</para>
        '''</remarks>
        Property C005_04 As String

        '''<summary>Tooth Surface Code</summary>
        '''<remarks> 
        '''<para>Code identifying the area of the tooth that was treated</para>
        '''</remarks>
        Property C005_05 As String
    End Interface
End Namespace