Namespace Segments
    '''<summary>Status Information</summary>
    '''<remarks>To report the status, required action, and paid information of a claim or service line</remarks>
    Partial Friend Class STC_Obj
        Inherits Segment
        Implements STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("STC")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C043_Obj),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element306),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element591),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element429),
                                      CType(Nothing, DataElements.Composite.C043_Obj),
                                      CType(Nothing, DataElements.Composite.C043_Obj),
                                      CType(Nothing, DataElements.Element933)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property STC01 As DataElements.Composite.C043 Implements STC.STC01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC.STC01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC01, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC.STC01
            Get
                Return CType(Elements(0), DataElements.Composite.C043_Obj)
            End Get
            Set(value As DataElements.Composite.C043)
                Elements(0) = value
            End Set
        End Property

        Private Property STC01_IFace As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC.STC01
            Get
                Return CType(STC01, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_01.C043)
                STC01 = value
            End Set
        End Property

        Private Property STC01_IFace_1 As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC.STC01
            Get
                Return CType(STC01, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_01.C043)
                STC01 = value
            End Set
        End Property

        Friend Property STC02 As Date? Implements STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC.STC02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element373
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property STC03 As String Implements STC.STC03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element306
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Property STC04 As Decimal? Implements STC.STC04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC04
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

        Friend Property STC05 As Decimal? Implements STC.STC05, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC05, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC05
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

        Friend Property STC06 As Date? Implements STC.STC06, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC06, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element373
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property STC07 As String Implements STC.STC07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element591).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element591
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element591).Value = value
                End If
            End Set
        End Property

        Friend Property STC08 As Date? Implements STC.STC08, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC08, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element373
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property STC09 As String Implements STC.STC09, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC09, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element429).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element429
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element429).Value = value
                End If
            End Set
        End Property

        Friend Property STC10 As DataElements.Composite.C043 Implements STC.STC10, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC10, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC.STC10, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC10, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC.STC10
            Get
                Return CType(Elements(9), DataElements.Composite.C043_Obj)
            End Get
            Set(value As DataElements.Composite.C043)
                Elements(9) = value
            End Set
        End Property

        Private Property STC10_IFace As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC.STC10
            Get
                Return CType(STC10, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_10.C043)
                STC10 = value
            End Set
        End Property

        Private Property STC10_IFace_1 As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC.STC10
            Get
                Return CType(STC10, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_10.C043)
                STC10 = value
            End Set
        End Property

        Friend Property STC11 As DataElements.Composite.C043 Implements STC.STC11, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200D.STC.STC11, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.STC.STC11, Transactions.Transaction277.Transaction277_A1.Segments.Loop2200E.STC.STC11, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.STC.STC11
            Get
                Return CType(Elements(10), DataElements.Composite.C043_Obj)
            End Get
            Set(value As DataElements.Composite.C043)
                Elements(10) = value
            End Set
        End Property

        Private Property STC11_IFace As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200B.STC.STC11
            Get
                Return CType(STC11, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200B.STC.STC_11.C043)
                STC11 = value
            End Set
        End Property

        Private Property STC11_IFace_1 As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.C043 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2200C.STC.STC11
            Get
                Return CType(STC11, Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.C043)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2200C.STC.STC_11.C043)
                STC11 = value
            End Set
        End Property

        Friend Property STC12 As String Implements STC.STC12
            Get
                Return If(Elements(11) IsNot Nothing, CType(Elements(11), DataElements.Element933).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(11) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(11) = New DataElements.Element933
                End If

                If Elements(11) IsNot Nothing Then
                    CType(Elements(11), DataElements.Element933).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As STC
            Dim rval As New STC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C043_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .STC02 = source.ToDateValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .STC03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .STC04 = source.ToFloatValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .STC05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .STC06 = source.ToDateValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .STC07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .STC08 = source.ToDateValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .STC09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .Elements(9) = DataElements.Composite.C043_Obj.FromReader(source.ToStringValue(9), reader)
                End If
                If source.Elements.Count > 10 Then
                    .Elements(10) = DataElements.Composite.C043_Obj.FromReader(source.ToStringValue(10), reader)
                End If
                If source.Elements.Count > 11 Then
                    .STC12 = source.ToStringValue(11)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Status Information</summary>
    '''<remarks>To report the status, required action, and paid information of a claim or service line</remarks>
    Public Interface STC
        Inherits ISegment

        '''<summary>Health Care Claim Status</summary>
        '''<remarks></remarks>
        Property STC01 As DataElements.Composite.C043

        '''<summary>Date</summary>
        '''<remarks>STC02 is the effective date of the status information.</remarks>
        Property STC02 As Date?

        '''<summary>Action Code</summary>
        '''<remarks></remarks>
        Property STC03 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>STC04 is the amount of original submitted charges.</remarks>
        Property STC04 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>STC05 is the amount paid.</remarks>
        Property STC05 As Decimal?

        '''<summary>Date</summary>
        '''<remarks>STC06 is the paid date.</remarks>
        Property STC06 As Date?

        '''<summary>Payment Method Code</summary>
        '''<remarks></remarks>
        Property STC07 As String

        '''<summary>Date</summary>
        '''<remarks>STC08 is the check issue date.</remarks>
        Property STC08 As Date?

        '''<summary>Check Number</summary>
        '''<remarks></remarks>
        Property STC09 As String

        '''<summary>Health Care Claim Status</summary>
        '''<remarks></remarks>
        Property STC10 As DataElements.Composite.C043

        '''<summary>Health Care Claim Status</summary>
        '''<remarks></remarks>
        Property STC11 As DataElements.Composite.C043

        '''<summary>Free-form Message Text</summary>
        '''<remarks>STC12 allows additional free-form status information.</remarks>
        Property STC12 As String

    End Interface
End NameSpace