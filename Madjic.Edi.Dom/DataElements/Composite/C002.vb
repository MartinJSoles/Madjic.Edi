Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Actions Indicated</summary>
    '''<remarks>Actions to be performed on the piece of paperwork identified</remarks>
    Partial Friend Class C002_Obj
        Inherits CompositeElement
        Implements C002
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element704),
                                         CType(Nothing, Element704),
                                         CType(Nothing, Element704),
                                         CType(Nothing, Element704),
                                         CType(Nothing, Element704)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C002_01 As String Implements C002.C002_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element704).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element704
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element704).Value = value
                End If
            End Set
        End Property

        Friend Property C002_02 As String Implements C002.C002_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element704).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element704
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element704).Value = value
                End If
            End Set
        End Property

        Friend Property C002_03 As String Implements C002.C002_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element704).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element704
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element704).Value = value
                End If
            End Set
        End Property

        Friend Property C002_04 As String Implements C002.C002_04
            Get
                Return If(SubElements(3) IsNot Nothing, CType(SubElements(3), Element704).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(3) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(3) = New Element704
                End If

                If SubElements(3) IsNot Nothing Then
                    CType(SubElements(3), Element704).Value = value
                End If
            End Set
        End Property

        Friend Property C002_05 As String Implements C002.C002_05
            Get
                Return If(SubElements(4) IsNot Nothing, CType(SubElements(4), Element704).Value, Nothing)
            End Get
            Set(value As String)
                If SubElements(4) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(4) = New Element704
                End If

                If SubElements(4) IsNot Nothing Then
                    CType(SubElements(4), Element704).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C002_Obj
            Dim rval As New C002_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C002_01 = values(0)
                End If
                If values.Length > 1 Then
                    .C002_02 = values(1)
                End If
                If values.Length > 2 Then
                    .C002_03 = values(2)
                End If
                If values.Length > 3 Then
                    .C002_04 = values(3)
                End If
                If values.Length > 4 Then
                    .C002_05 = values(4)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Actions Indicated</summary>
    '''<remarks>Actions to be performed on the piece of paperwork identified</remarks>
    Public Interface C002
        '''<summary>Paperwork/Report Action Code</summary>
        '''<remarks> 
        '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
        '''</remarks>
        Property C002_01 As String

        '''<summary>Paperwork/Report Action Code</summary>
        '''<remarks> 
        '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
        '''</remarks>
        Property C002_02 As String

        '''<summary>Paperwork/Report Action Code</summary>
        '''<remarks> 
        '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
        '''</remarks>
        Property C002_03 As String

        '''<summary>Paperwork/Report Action Code</summary>
        '''<remarks> 
        '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
        '''</remarks>
        Property C002_04 As String

        '''<summary>Paperwork/Report Action Code</summary>
        '''<remarks> 
        '''<para>Code specifying how the paperwork or report that is identified in the PWK segment relates to the transaction set or to identify the action that is required</para>
        '''</remarks>
        Property C002_05 As String
    End Interface
End Namespace