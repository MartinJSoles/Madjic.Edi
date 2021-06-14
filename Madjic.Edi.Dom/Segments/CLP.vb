Namespace Segments
    '''<summary>Claim Level Data</summary>
    '''<remarks>To supply information common to all services of a claim</remarks>
    Partial Friend Class CLP_Obj
        Inherits Segment
        Implements CLP,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4})}

        Public Sub New()
            MyBase.New("CLP")
            Elements.AddRange({CType(Nothing, DataElements.Element1028),
                                      CType(Nothing, DataElements.Element1029),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element1032),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1331),
                                      CType(Nothing, DataElements.Element1325),
                                      CType(Nothing, DataElements.Element1352),
                                      CType(Nothing, DataElements.Element1354),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CLP01 As String Implements CLP.CLP01, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1028).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1028
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1028).Value = value
                End If
            End Set
        End Property

        Friend Property CLP02 As String Implements CLP.CLP02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1029).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1029
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1029).Value = value
                End If
            End Set
        End Property

        Friend Property CLP03 As Decimal? Implements CLP.CLP03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element782
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property CLP04 As Decimal? Implements CLP.CLP04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP04
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

        Friend Property CLP05 As Decimal? Implements CLP.CLP05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element782).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element782
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element782).Value = value
                End If
            End Set
        End Property

        Friend Property CLP06 As String Implements CLP.CLP06, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1032).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1032
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1032).Value = value
                End If
            End Set
        End Property

        Friend Property CLP07 As String Implements CLP.CLP07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element127
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property CLP08 As String Implements CLP.CLP08, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element1331).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element1331
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element1331).Value = value
                End If
            End Set
        End Property

        Friend Property CLP09 As String Implements CLP.CLP09, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1325).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1325
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1325).Value = value
                End If
            End Set
        End Property

        Friend Property CLP10 As String Implements CLP.CLP10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1352
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1352).Value = value
                End If
            End Set
        End Property

        Friend Property CLP11 As String Implements CLP.CLP11, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP11
            Get
                Return If(Elements(10) IsNot Nothing, CType(Elements(10), DataElements.Element1354).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(10) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(10) = New DataElements.Element1354
                End If

                If Elements(10) IsNot Nothing Then
                    CType(Elements(10), DataElements.Element1354).Value = value
                End If
            End Set
        End Property

        Friend Property CLP12 As Decimal? Implements CLP.CLP12, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element380
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CLP13 As Decimal? Implements CLP.CLP13, Transactions.Transaction835.Transaction835_W1.Segments.Loop2100.CLP.CLP13
            Get
                Return If(Elements(12) IsNot Nothing, CType(Elements(12), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(12) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(12) = New DataElements.Element954
                End If

                If Elements(12) IsNot Nothing Then
                    CType(Elements(12), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property CLP14 As String Implements CLP.CLP14
            Get
                Return If(Elements(13) IsNot Nothing, CType(Elements(13), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(13) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(13) = New DataElements.Element1073
                End If

                If Elements(13) IsNot Nothing Then
                    CType(Elements(13), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CLP
            Dim rval As New CLP_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CLP01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CLP02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CLP03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CLP04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CLP05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .CLP06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .CLP07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .CLP08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .CLP09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .CLP10 = source.ToStringValue(9)
                End If
                If source.Elements.Count > 10 Then
                    .CLP11 = source.ToStringValue(10)
                End If
                If source.Elements.Count > 11 Then
                    .CLP12 = source.ToFloatValue(11)
                End If
                If source.Elements.Count > 12 Then
                    .CLP13 = source.ToFloatValue(12)
                End If
                If source.Elements.Count > 13 Then
                    .CLP14 = source.ToStringValue(13)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Claim Level Data</summary>
    '''<remarks>To supply information common to all services of a claim</remarks>
    Public Interface CLP
        Inherits ISegment

        '''<summary>Claim Submitter's Identifier</summary>
        '''<remarks></remarks>
        Property CLP01 As String

        '''<summary>Claim Status Code</summary>
        '''<remarks></remarks>
        Property CLP02 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>CLP03 is the amount of submitted charges this claim.</remarks>
        Property CLP03 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>CLP04 is the amount paid this claim.</remarks>
        Property CLP04 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>CLP05 is the patient responsibility amount.</remarks>
        Property CLP05 As Decimal?

        '''<summary>Claim Filing Indicator Code</summary>
        '''<remarks></remarks>
        Property CLP06 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>CLP07 is the payer's internal control number.</remarks>
        Property CLP07 As String

        '''<summary>Facility Code Value</summary>
        '''<remarks></remarks>
        Property CLP08 As String

        '''<summary>Claim Frequency Type Code</summary>
        '''<remarks></remarks>
        Property CLP09 As String

        '''<summary>Patient Status Code</summary>
        '''<remarks></remarks>
        Property CLP10 As String

        '''<summary>Diagnosis Related Group (DRG) Code</summary>
        '''<remarks></remarks>
        Property CLP11 As String

        '''<summary>Quantity</summary>
        '''<remarks>CLP12 is the diagnosis-related group (DRG) weight.</remarks>
        Property CLP12 As Decimal?

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>CLP13 is the discharge fraction.</remarks>
        Property CLP13 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>CLP14 is the patient authorization to coordinate benefits. A "Y" indicates that the authorization exists; an "N" indicates that the authorization does not exist.</remarks>
        Property CLP14 As String

    End Interface
End NameSpace