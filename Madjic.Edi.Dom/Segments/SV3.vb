Namespace Segments
    '''<summary>Dental Service</summary>
    '''<remarks>To specify the service line item detail for dental work</remarks>
    Partial Friend Class SV3_Obj
        Inherits Segment
        Implements SV3,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("SV3")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1331),
                                      CType(Nothing, DataElements.Composite.C006_Obj),
                                      CType(Nothing, DataElements.Element1358),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1327),
                                      CType(Nothing, DataElements.Element1360),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Composite.C004_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV301 As DataElements.Composite.C003 Implements SV3.SV301, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV301, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3.SV301
            Get
                Return CType(Elements(0), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(0) = value
            End Set
        End Property

        Private Property SV301_IFace As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.C003 Implements Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV301
            Get
                Return CType(SV301, Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.C003)
            End Get
            Set(value As Transactions.Transaction837.Transaction837_Q2.Composites.Loop2400.SV3.SV3_01.C003)
                SV301 = value
            End Set
        End Property

        Friend Property SV302 As Decimal? Implements SV3.SV302, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV302, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3.SV302, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element782
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property SV303 As String Implements SV3.SV303, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV303
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

        Friend Property SV304 As DataElements.Composite.C006 Implements SV3.SV304, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV304, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3.SV304, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV304
            Get
                Return CType(Elements(3), DataElements.Composite.C006_Obj)
            End Get
            Set(value As DataElements.Composite.C006)
                Elements(3) = value
            End Set
        End Property

        Friend Property SV305 As String Implements SV3.SV305, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV305, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3.SV305, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV305
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1358).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1358
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1358).Value = value
                End If
            End Set
        End Property

        Friend Property SV306 As Decimal? Implements SV3.SV306, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV306, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.SV3.SV306, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV306
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

        Friend Property SV307 As String Implements SV3.SV307, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.SV3.SV307
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element352
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property SV308 As String Implements SV3.SV308
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1327).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1327
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1327).Value = value
                End If
            End Set
        End Property

        Friend Property SV309 As String Implements SV3.SV309
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1360).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1360
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1360).Value = value
                End If
            End Set
        End Property

        Friend Property SV310 As String Implements SV3.SV310
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

        Friend Property SV311 As DataElements.Composite.C004 Implements SV3.SV311, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.SV3.SV311
            Get
                Return CType(Elements(10), DataElements.Composite.C004_Obj)
            End Get
            Set(value As DataElements.Composite.C004)
                Elements(10) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV3
            Dim rval As New SV3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .SV302 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SV303 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C006_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .SV305 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV306 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .SV307 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .SV308 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .SV309 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .SV310 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .Elements(10) = DataElements.Composite.C004_Obj.FromReader(source.ToStringValue(10), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Dental Service</summary>
    '''<remarks>To specify the service line item detail for dental work</remarks>
    Public Interface SV3
        Inherits ISegment

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks></remarks>
        Property SV301 As DataElements.Composite.C003

        '''<summary>Monetary Amount</summary>
        '''<remarks>SV302 is the submitted service line item amount.</remarks>
        Property SV302 As Decimal?

        '''<summary>Facility Code Value</summary>
        '''<remarks>SV303 is the place of service code representing the location where the dental treatment was rendered.</remarks>
        Property SV303 As String

        '''<summary>Oral Cavity Designation</summary>
        '''<remarks></remarks>
        Property SV304 As DataElements.Composite.C006

        '''<summary>Prosthesis, Crown or Inlay Code</summary>
        '''<remarks></remarks>
        Property SV305 As String

        '''<summary>Quantity</summary>
        '''<remarks>SV306 is the number of procedures.</remarks>
        Property SV306 As Decimal?

        '''<summary>Description</summary>
        '''<remarks>SV307 is the reason for replacement.</remarks>
        Property SV307 As String

        '''<summary>Copay Status Code</summary>
        '''<remarks></remarks>
        Property SV308 As String

        '''<summary>Provider Agreement Code</summary>
        '''<remarks></remarks>
        Property SV309 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV310 is the predetermination of benefits indicator. A "Y" value indicates that this service is being submitted for predetermination of benefits.</remarks>
        Property SV310 As String

        '''<summary>Composite Diagnosis Code Pointer</summary>
        '''<remarks></remarks>
        Property SV311 As DataElements.Composite.C004

    End Interface
End NameSpace