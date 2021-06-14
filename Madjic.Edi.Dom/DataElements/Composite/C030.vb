Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Position in Segment</summary>
    '''<remarks>Code indicating the relative position of the simple data element or composite data structure in error within a segment, count beginning with 1 for the position immediately following the segment ID; additionally indicating the relative position of a repeating structure in error, count beginning with 1 for the position immediately following the preceeding element separator; aditionally indicating the relative position of a component of a composite data structure in error, count beginning with 1 for the position following the preceeding element or repetition separator</remarks>
    Partial Friend Class C030_Obj
        Inherits CompositeElement
        Implements C030
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element722),
                                         CType(Nothing, Element1528),
                                         CType(Nothing, Element1686)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification := "<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C030_01 As Decimal? Implements C030.C030_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element722).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element722
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element722).Value = value
                End If
            End Set
        End Property

        Friend Property C030_02 As Decimal? Implements C030.C030_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element1528).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element1528
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element1528).Value = value
                End If
            End Set
        End Property

        Friend Property C030_03 As Decimal? Implements C030.C030_03
            Get
                Return If(SubElements(2) IsNot Nothing, CType(SubElements(2), Element1686).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(2) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(2) = New Element1686
                End If

                If SubElements(2) IsNot Nothing Then
                    CType(SubElements(2), Element1686).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C030_Obj
            Dim rval As New C030_Obj

            Dim values = fullElement.Split(reader.CompositeSeparator)

            With rval
                If values.Length > 0 Then
                    .C030_01 = values(0).ToDecimal(0)
                End If
                If values.Length > 1 Then
                    .C030_02 = values(1).ToDecimal(0)
                End If
                If values.Length > 2 Then
                    .C030_03 = values(2).ToDecimal(0)
                End If
            End With

            Return rval
        End Function
    End Class

    '''<summary>Position in Segment</summary>
    '''<remarks>Code indicating the relative position of the simple data element or composite data structure in error within a segment, count beginning with 1 for the position immediately following the segment ID; additionally indicating the relative position of a repeating structure in error, count beginning with 1 for the position immediately following the preceeding element separator; aditionally indicating the relative position of a component of a composite data structure in error, count beginning with 1 for the position following the preceeding element or repetition separator</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C030
        '''<summary>Element Position in Segment</summary>
        '''<remarks> 
        '''<para>This is used to indicate the relative position of a simple data element, or the relative position or a composite data structure with the relative position of the component within the composite data structure, in error; in the data segment the count starts with 1 for the simple data element or composite data structure immediately followign the segment ID</para>
        '''</remarks>
        Property C030_01 As Decimal?

        '''<summary>Component Data Element Position in Composite</summary>
        '''<remarks> 
        '''<para>To identify the component data element position within the composite that is in error</para>
        '''</remarks>
        Property C030_02 As Decimal?

        '''<summary>Repeating Data Element Position</summary>
        '''<remarks> 
        '''<para>To identify the specific repetition of a data element that is in error</para>
        '''</remarks>
        Property C030_03 As Decimal?
    End Interface
End Namespace