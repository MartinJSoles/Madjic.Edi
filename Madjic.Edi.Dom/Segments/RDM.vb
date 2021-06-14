Namespace Segments
    '''<summary>Remittance Delivery Method</summary>
    '''<remarks>To identify remittance delivery when remittance is separate from payment</remarks>
    Partial Friend Class RDM_Obj
        Inherits Segment
        Implements RDM,
                   Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("RDM")
            Elements.AddRange({CType(Nothing, DataElements.Element756),
                                      CType(Nothing, DataElements.Element93),
                                      CType(Nothing, DataElements.Element364),
                                      CType(Nothing, DataElements.Composite.C040_Obj),
                                      CType(Nothing, DataElements.Composite.C040_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property RDM01 As String Implements RDM.RDM01, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM.RDM01, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM.RDM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element756).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element756
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element756).Value = value
                End If
            End Set
        End Property

        Friend Property RDM02 As String Implements RDM.RDM02, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM.RDM02, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM.RDM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element93).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element93
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element93).Value = value
                End If
            End Set
        End Property

        Friend Property RDM03 As String Implements RDM.RDM03, Transactions.Transaction820.Transaction820_A1.Segments.Loop1000A.RDM.RDM03, Transactions.Transaction835.Transaction835_W1.Segments.Loop1000B.RDM.RDM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element364).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element364
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element364).Value = value
                End If
            End Set
        End Property

        Friend Property RDM04 As DataElements.Composite.C040 Implements RDM.RDM04
            Get
                Return CType(Elements(3), DataElements.Composite.C040_Obj)
            End Get
            Set(value As DataElements.Composite.C040)
                Elements(3) = value
            End Set
        End Property

        Friend Property RDM05 As DataElements.Composite.C040 Implements RDM.RDM05
            Get
                Return CType(Elements(4), DataElements.Composite.C040_Obj)
            End Get
            Set(value As DataElements.Composite.C040)
                Elements(4) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As RDM
            Dim rval As New RDM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .RDM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .RDM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .RDM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C040_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C040_Obj.FromReader(source.ToStringValue(4), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Remittance Delivery Method</summary>
    '''<remarks>To identify remittance delivery when remittance is separate from payment</remarks>
    Public Interface RDM
        Inherits ISegment

        '''<summary>Report Transmission Code</summary>
        '''<remarks></remarks>
        Property RDM01 As String

        '''<summary>Name</summary>
        '''<remarks>RDM02 is used to contain the name of a third party processor if needed, who would be the first recipient of the remittance.</remarks>
        Property RDM02 As String

        '''<summary>Communication Number</summary>
        '''<remarks>RDM03 contains the operative communication number for the delivery method specified in RDM01 (i.e. fax phone number and mail address).</remarks>
        Property RDM03 As String

        '''<summary>Reference Identifier</summary>
        '''<remarks>RDM04 and RDM05 allow for additional room to convey further routing information beyond what is given in RDM03.</remarks>
        Property RDM04 As DataElements.Composite.C040

        '''<summary>Reference Identifier</summary>
        '''<remarks></remarks>
        Property RDM05 As DataElements.Composite.C040

    End Interface
End NameSpace