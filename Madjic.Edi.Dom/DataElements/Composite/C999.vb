Imports Madjic.Edi.Dom.EdiReader

Namespace Global.Madjic.Edi.Dom.DataElements.Composite
    '''<summary>Reference in Segment</summary>
    '''<remarks>To hold the reference number of a data element and optionally a component data element within a composite</remarks>
    Partial Friend Class C999_Obj
        Inherits CompositeElement
        Implements C999
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New

            SubElements.AddRange({CType(Nothing, Element725),
                                         CType(Nothing, Element725)})
            SyntaxRules.AddRange(_Rules)

            Initialize()
        End Sub

        <CodeAnalysis.SuppressMessage("Performance", "CA1822:Mark members as static", Justification:="<Pending>")>
        Partial Private Sub Initialize()
        End Sub

#Region " Properties "

        Friend Property C999_01 As Decimal? Implements C999.C999_01
            Get
                Return If(SubElements(0) IsNot Nothing, CType(SubElements(0), Element725).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(0) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(0) = New Element725
                End If

                If SubElements(0) IsNot Nothing Then
                    CType(SubElements(0), Element725).Value = value
                End If
            End Set
        End Property

        Friend Property C999_02 As Decimal? Implements C999.C999_02
            Get
                Return If(SubElements(1) IsNot Nothing, CType(SubElements(1), Element725).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If SubElements(1) Is Nothing AndAlso value IsNot Nothing Then
                    SubElements(1) = New Element725
                End If

                If SubElements(1) IsNot Nothing Then
                    CType(SubElements(1), Element725).Value = value
                End If
            End Set
        End Property

#End Region

        Friend Overrides Sub Read(fullElement As String, reader As SegmentReader)
            Dim values = fullElement.Split(reader.CompositeSeparator)

            If values.Length > 0 Then
                C999_01 = values(0).ToDecimal(0)
            End If
            If values.Length > 1 Then
                C999_02 = values(1).ToDecimal(0)
            End If
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As C999_Obj
            Dim rval As New C999_Obj

            rval.Read(fullElement, reader)

            Return rval
        End Function
    End Class

    '''<summary>Reference in Segment</summary>
    '''<remarks>To hold the reference number of a data element and optionally a component data element within a composite</remarks>
    <CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification := "<Pending>")>
    Public Interface C999
        '''<summary>Data Element Reference Number</summary>
        '''<remarks> 
        '''<para>Reference number used to locate the data element in the Data Element Dictionary</para>
        '''</remarks>
        Property C999_01 As Decimal?

        '''<summary>Data Element Reference Number</summary>
        '''<remarks> 
        '''<para>Reference number used to locate the data element in the Data Element Dictionary</para>
        '''</remarks>
        Property C999_02 As Decimal?
    End Interface
End Namespace