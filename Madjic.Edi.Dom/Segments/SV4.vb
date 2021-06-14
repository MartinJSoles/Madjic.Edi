Namespace Segments
    '''<summary>Drug Service</summary>
    '''<remarks>To specify the claim service detail for prescription drugs</remarks>
    Partial Friend Class SV4_Obj
        Inherits Segment
        Implements SV4
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SV4")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1329),
                                      CType(Nothing, DataElements.Element1338),
                                      CType(Nothing, DataElements.Element1356),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1370),
                                      CType(Nothing, DataElements.Element1319),
                                      CType(Nothing, DataElements.Element1320),
                                      CType(Nothing, DataElements.Element1330),
                                      CType(Nothing, DataElements.Element1327),
                                      CType(Nothing, DataElements.Element1384),
                                      CType(Nothing, DataElements.Element1337),
                                      CType(Nothing, DataElements.Element1357)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV401 As String Implements SV4.SV401
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element127
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property SV402 As DataElements.Composite.C003 Implements SV4.SV402
            Get
                Return CType(Elements(1), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(1) = value
            End Set
        End Property

        Friend Property SV403 As String Implements SV4.SV403
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property SV404 As String Implements SV4.SV404
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1073
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV405 As String Implements SV4.SV405
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1329).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1329
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1329).Value = value
                End If
            End Set
        End Property

        Friend Property SV406 As String Implements SV4.SV406
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1338).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1338
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1338).Value = value
                End If
            End Set
        End Property

        Friend Property SV407 As String Implements SV4.SV407
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1356).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1356
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1356).Value = value
                End If
            End Set
        End Property

        Friend Property SV408 As String Implements SV4.SV408
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element352
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property SV409 As String Implements SV4.SV409
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1073
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV410 As String Implements SV4.SV410
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1073
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property SV411 As String Implements SV4.SV411
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1370).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1370
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1370).Value = value
                End If
            End Set
        End Property

        Friend Property SV412 As String Implements SV4.SV412
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element1319).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element1319
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element1319).Value = value
                End If
            End Set
        End Property

        Friend Property SV413 As String Implements SV4.SV413
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element1320).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element1320
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element1320).Value = value
                End If
            End Set
        End Property

        Friend Property SV414 As String Implements SV4.SV414
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1330).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1330
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1330).Value = value
                End If
            End Set
        End Property

        Friend Property SV415 As String Implements SV4.SV415
            Get
                Return If(Elements(14) IsNot Nothing, CType(Elements(14), DataElements.Element1327).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(14) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(14) = New DataElements.Element1327
                End If

                If Elements(14) IsNot Nothing Then
                    CType(Elements(14), DataElements.Element1327).Value = value
                End If
            End Set
        End Property

        Friend Property SV416 As String Implements SV4.SV416
            Get
                Return If(Elements(15) IsNot Nothing, CType(Elements(15), DataElements.Element1384).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(15) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(15) = New DataElements.Element1384
                End If

                If Elements(15) IsNot Nothing Then
                    CType(Elements(15), DataElements.Element1384).Value = value
                End If
            End Set
        End Property

        Friend Property SV417 As String Implements SV4.SV417
            Get
                Return If(Elements(16) IsNot Nothing, CType(Elements(16), DataElements.Element1337).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(16) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(16) = New DataElements.Element1337
                End If

                If Elements(16) IsNot Nothing Then
                    CType(Elements(16), DataElements.Element1337).Value = value
                End If
            End Set
        End Property

        Friend Property SV418 As String Implements SV4.SV418
            Get
                Return If(Elements(17) IsNot Nothing, CType(Elements(17), DataElements.Element1357).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(17) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(17) = New DataElements.Element1357
                End If

                If Elements(17) IsNot Nothing Then
                    CType(Elements(17), DataElements.Element1357).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV4
            Dim rval As New SV4_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SV401 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .Elements(1) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(1), reader)
                End If
                If source.Elements.Count > 2 Then
                    .SV403 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV404 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SV405 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV406 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SV407 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SV408 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SV409 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SV410 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .SV411 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .SV412 = source.ToStringValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .SV413 = source.ToStringValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .SV414 = source.ToStringValue(13)
                End If
                If source.Elements.Count > 14 Then
                    .SV415 = source.ToStringValue(14)
                End If
                If source.Elements.Count > 15 Then
                    .SV416 = source.ToStringValue(15)
                End If
                If source.Elements.Count > 16 Then
                    .SV417 = source.ToStringValue(16)
                End If
                If source.Elements.Count > 17 Then
                    .SV418 = source.ToStringValue(17)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Drug Service</summary>
    '''<remarks>To specify the claim service detail for prescription drugs</remarks>
    Public Interface SV4
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>SV401 is a prescription number.</remarks>
        Property SV401 As String

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV402 As DataElements.Composite.C003

        '''<summary>Reference Identification</summary>
        '''<remarks>SV403 is a new or refill number. A value of zero indicates a new prescription, any other value is the refill number of an existing prescription.</remarks>
        Property SV403 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV404 is the generic indicator. A "Y" value indicates a generic drug; an "N" value indicates a branded drug.</remarks>
        Property SV404 As String

        '''<summary>Dispense as Written Code</summary>
        '''<remarks></remarks>
        Property SV405 As String

        '''<summary>Level of Service Code</summary>
        '''<remarks></remarks>
        Property SV406 As String

        '''<summary>Prescription Origin Code</summary>
        '''<remarks></remarks>
        Property SV407 As String

        '''<summary>Description</summary>
        '''<remarks>SV408 is the drug name.</remarks>
        Property SV408 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV409 is the multisource indicator. A "Y" indicates drug is available from more than one manufacturer; an "N" value indicates drug is available from one manufacturer.</remarks>
        Property SV409 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV410 is the compound indicator. A "Y" indicates a compound drug; an "N" value indicates a noncompound drug. A "U" value indicates a nonspecified drug compound.</remarks>
        Property SV410 As String

        '''<summary>Unit Dose Code</summary>
        '''<remarks></remarks>
        Property SV411 As String

        '''<summary>Basis of Cost Determination Code</summary>
        '''<remarks></remarks>
        Property SV412 As String

        '''<summary>Basis of Days Supply Determination Code</summary>
        '''<remarks></remarks>
        Property SV413 As String

        '''<summary>Dosage Form Code</summary>
        '''<remarks></remarks>
        Property SV414 As String

        '''<summary>Copay Status Code</summary>
        '''<remarks></remarks>
        Property SV415 As String

        '''<summary>Patient Location Code</summary>
        '''<remarks></remarks>
        Property SV416 As String

        '''<summary>Level of Care Code</summary>
        '''<remarks></remarks>
        Property SV417 As String

        '''<summary>Prior Authorization Type Code</summary>
        '''<remarks></remarks>
        Property SV418 As String

    End Interface
End NameSpace