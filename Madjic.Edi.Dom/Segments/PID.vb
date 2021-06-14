Namespace Segments
    '''<summary>Product/Item Description</summary>
    '''<remarks>To describe a product or process in coded or free-form format</remarks>
    Partial Friend Class PID_Obj
        Inherits Segment
        Implements PID
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleConditional(4, {3}),
                                                 New SyntaxRuleRequired({4, 5}),
                                                 New SyntaxRuleConditional(7, {3}),
                                                 New SyntaxRuleConditional(8, {4}),
                                                 New SyntaxRuleConditional(9, {5}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("PID")
            Elements.AddRange({CType(Nothing, DataElements.Element349),
                                      CType(Nothing, DataElements.Element750),
                                      CType(Nothing, DataElements.Element559),
                                      CType(Nothing, DataElements.Element751),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element752),
                                      CType(Nothing, DataElements.Element822),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element819)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PID01 As String Implements PID.PID01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element349).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element349
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element349).Value = value
                End If
            End Set
        End Property

        Friend Property PID02 As String Implements PID.PID02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element750).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element750
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element750).Value = value
                End If
            End Set
        End Property

        Friend Property PID03 As String Implements PID.PID03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element559).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element559
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element559).Value = value
                End If
            End Set
        End Property

        Friend Property PID04 As String Implements PID.PID04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element751).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element751
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element751).Value = value
                End If
            End Set
        End Property

        Friend Property PID05 As String Implements PID.PID05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element352
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property PID06 As String Implements PID.PID06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element752).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element752
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element752).Value = value
                End If
            End Set
        End Property

        Friend Property PID07 As String Implements PID.PID07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element822).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element822
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element822).Value = value
                End If
            End Set
        End Property

        Friend Property PID08 As String Implements PID.PID08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1073
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property PID09 As String Implements PID.PID09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element819).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element819
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element819).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PID
            Dim rval As New PID_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PID01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PID02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PID03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PID04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PID05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PID06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .PID07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .PID08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .PID09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Product/Item Description</summary>
    '''<remarks>To describe a product or process in coded or free-form format</remarks>
    Public Interface PID
        Inherits ISegment

        '''<summary>Item Description Type</summary>
        '''<remarks>If PID01 equals "F", then PID05 is used. If PID01 equals "S", then PID04 is used. If PID01 equals "X", then both PID04 and PID05 are used.</remarks>
        Property PID01 As String

        '''<summary>Product/Process Characteristic Code</summary>
        '''<remarks></remarks>
        Property PID02 As String

        '''<summary>Agency Qualifier Code</summary>
        '''<remarks>Use PID03 to indicate the organization that publishes the code list being referred to.</remarks>
        Property PID03 As String

        '''<summary>Product Description Code</summary>
        '''<remarks>PID04 should be used for industry-specific product description codes.</remarks>
        Property PID04 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property PID05 As String

        '''<summary>Surface/Layer/Position Code</summary>
        '''<remarks>Use PID06 when necessary to refer to the product surface or layer being described in the segment.</remarks>
        Property PID06 As String

        '''<summary>Source Subqualifier</summary>
        '''<remarks>PID07 specifies the individual code list of the agency specified in PID03.</remarks>
        Property PID07 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>PID08 describes the physical characteristics of the product identified in PID04. A "Y" indicates that the specified attribute applies to this item; an "N" indicates it does not apply. Any other value is indeterminate.</remarks>
        Property PID08 As String

        '''<summary>Language Code</summary>
        '''<remarks>PID09 is used to identify the language being used in PID05.</remarks>
        Property PID09 As String

    End Interface
End NameSpace