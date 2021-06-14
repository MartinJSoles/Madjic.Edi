Namespace Segments
    '''<summary>Ambulance Certification</summary>
    '''<remarks>To supply information related to the ambulance service rendered to a patient</remarks>
    Partial Friend Class CR1_Obj
        Inherits Segment
        Implements CR1,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2}),
                                                 New SyntaxRulePaired({5, 6})}

        Public Sub New()
            MyBase.New("CR1")
            Elements.AddRange({CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element1316),
                                      CType(Nothing, DataElements.Element1317),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element166),
                                      CType(Nothing, DataElements.Element166),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR101 As String Implements CR1.CR101, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR101, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR101, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element355
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR102 As Decimal? Implements CR1.CR102, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element81
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property CR103 As String Implements CR1.CR103, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR103, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR1.CR103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1316).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1316
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1316).Value = value
                End If
            End Set
        End Property

        Friend Property CR104 As String Implements CR1.CR104, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR104, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR104, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1317).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1317
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1317).Value = value
                End If
            End Set
        End Property

        Friend Property CR105 As String Implements CR1.CR105, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR105, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR1.CR105, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR105, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR105
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element355
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR106 As Decimal? Implements CR1.CR106, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR106, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CR1.CR106, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR106, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR106
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

        Friend Property CR107 As String Implements CR1.CR107
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element166).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element166
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element166).Value = value
                End If
            End Set
        End Property

        Friend Property CR108 As String Implements CR1.CR108
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element166).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element166
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element166).Value = value
                End If
            End Set
        End Property

        Friend Property CR109 As String Implements CR1.CR109, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR109, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR109, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR109
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element352
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property CR110 As String Implements CR1.CR110, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CR1.CR110, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.CR1.CR110, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR1.CR110
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element352
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR1
            Dim rval As New CR1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR104 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR105 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CR106 = source.ToFloatValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CR107 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CR108 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CR109 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CR110 = source.ToStringValue(9)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Ambulance Certification</summary>
    '''<remarks>To supply information related to the ambulance service rendered to a patient</remarks>
    Public Interface CR1
        Inherits ISegment

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR101 As String

        '''<summary>Weight</summary>
        '''<remarks>CR102 is the weight of the patient at time of transport.</remarks>
        Property CR102 As Decimal?

        '''<summary>Ambulance Transport Code</summary>
        '''<remarks></remarks>
        Property CR103 As String

        '''<summary>Ambulance Transport Reason Code</summary>
        '''<remarks></remarks>
        Property CR104 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property CR105 As String

        '''<summary>Quantity</summary>
        '''<remarks>CR106 is the distance traveled during transport.</remarks>
        Property CR106 As Decimal?

        '''<summary>Address Information</summary>
        '''<remarks>CR107 is the address of origin.</remarks>
        Property CR107 As String

        '''<summary>Address Information</summary>
        '''<remarks>CR108 is the address of destination.</remarks>
        Property CR108 As String

        '''<summary>Description</summary>
        '''<remarks>CR109 is the purpose for the round trip ambulance service.</remarks>
        Property CR109 As String

        '''<summary>Description</summary>
        '''<remarks>CR110 is the purpose for the usage of a stretcher during ambulance service.</remarks>
        Property CR110 As String

    End Interface
End NameSpace