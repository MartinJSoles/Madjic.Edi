Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Composite Diagnosis Code Pointer</summary>
    '''<remarks>To identify one or more diagnosis code pointers</remarks>
    Partial Friend Class C004_Obj
        Inherits CompositeElement
        Implements C004
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element1328),
                                         CType(Nothing, Element1328),
                                         CType(Nothing, Element1328),
                                         CType(Nothing, Element1328)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C004_01 As Decimal? Implements C004.C004_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element1328).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element1328
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element1328).Value = value
                End If
            End Set
        End Property

        Friend Property C004_02 As Decimal? Implements C004.C004_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1328).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1328
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1328).Value = value
                End If
            End Set
        End Property

        Friend Property C004_03 As Decimal? Implements C004.C004_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1328).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1328
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1328).Value = value
                End If
            End Set
        End Property

        Friend Property C004_04 As Decimal? Implements C004.C004_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element1328).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element1328
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element1328).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C004_Obj
            Dim rval As New C004_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C004_01 = values(0).ToDecimal(0)
                End If
                If values.Length > 1 Then
                    .C004_02 = values(1).ToDecimal(0)
                End If
                If values.Length > 2 Then
                    .C004_03 = values(2).ToDecimal(0)
                End If
                If values.Length > 3 Then
                    .C004_04 = values(3).ToDecimal(0)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Composite Diagnosis Code Pointer</summary>
    '''<remarks>To identify one or more diagnosis code pointers</remarks>
    Public Interface C004
        '''<summary>Diagnosis Code Pointer</summary>
        '''<remarks> 
        '''<para>A pointer to the diagnosis code in the order of importance to this service</para>
        '''</remarks>
        Property C004_01 As Decimal?

        '''<summary>Diagnosis Code Pointer</summary>
        '''<remarks> 
        '''<para>A pointer to the diagnosis code in the order of importance to this service</para>
        '''</remarks>
        Property C004_02 As Decimal?

        '''<summary>Diagnosis Code Pointer</summary>
        '''<remarks> 
        '''<para>A pointer to the diagnosis code in the order of importance to this service</para>
        '''</remarks>
        Property C004_03 As Decimal?

        '''<summary>Diagnosis Code Pointer</summary>
        '''<remarks> 
        '''<para>A pointer to the diagnosis code in the order of importance to this service</para>
        '''</remarks>
        Property C004_04 As Decimal?
    End Interface
End Namespace
