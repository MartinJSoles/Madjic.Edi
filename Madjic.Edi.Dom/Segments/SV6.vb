Namespace Segments
    '''<summary>Anesthesia Service</summary>
    '''<remarks>To specify the claim service detail for anesthesia</remarks>
    Partial Friend Class SV6_Obj
        Inherits Segment
        Implements SV6
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3}),
                                                 New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SV6")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element1332),
                                      CType(Nothing, DataElements.Element1331),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Composite.C004_Obj),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV601 As DataElements.Composite.C003 Implements SV6.SV601
            Get
                Return CType(Elements(0), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(0) = value
            End Set
        End Property

        Friend Property SV602 As String Implements SV6.SV602
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1332).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1332
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1332).Value = value
                End If
            End Set
        End Property

        Friend Property SV603 As String Implements SV6.SV603
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1331).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1331
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1331).Value = value
                End If
            End Set
        End Property

        Friend Property SV604 As Decimal? Implements SV6.SV604
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element782
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property SV605 As DataElements.Composite.C004 Implements SV6.SV605
            Get
                Return CType(Elements(4), DataElements.Composite.C004_Obj)
            End Get
            Set(value As DataElements.Composite.C004)
                Elements(4) = value
            End Set
        End Property

        Friend Property SV606 As Decimal? Implements SV6.SV606
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element380
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SV607 As String Implements SV6.SV607
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1073
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV6
            Dim rval As New SV6_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .SV602 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SV603 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV604 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C004_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .SV606 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SV607 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Anesthesia Service</summary>
    '''<remarks>To specify the claim service detail for anesthesia</remarks>
    Public Interface SV6
        Inherits ISegment

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV601 As DataElements.Composite.C003

        '''<summary>Facility Code Qualifier</summary>
        '''<remarks></remarks>
        Property SV602 As String

        '''<summary>Facility Code Value</summary>
        '''<remarks></remarks>
        Property SV603 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV604 is the submitted charge.</remarks>
        Property SV604 As Decimal?

        '''<summary>Composite Diagnosis Code Pointer</summary>
        '''<remarks></remarks>
        Property SV605 As DataElements.Composite.C004

        '''<summary>Quantity</summary>
        '''<remarks>SV606 is the number of anesthesia minutes.</remarks>
        Property SV606 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV607 is the Certified Registered Nurse Anesthetist (CRNA) supervision indicator. A "Y" value indicates that services were performed personally by a CRNA who was medically directed by a physician other than the operating surgeon, assistant surgeon, or attending physician; an "N" value indicates that the services were performed personally by a CRNA who was medically directed by the operating surgeon, assistant surgeon, or attending physician.</remarks>
        Property SV607 As String

    End Interface
End NameSpace