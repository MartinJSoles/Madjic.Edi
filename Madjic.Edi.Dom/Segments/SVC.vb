Namespace Segments
    '''<summary>Service Information</summary>
    '''<remarks>To supply payment and control information to a provider for a particular service</remarks>
    Partial Friend Class SVC_Obj
        Inherits Segment
        Implements SVC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC,
                   Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC,
                   Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("SVC")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element234),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Composite.C003_Obj),
                                      CType(Nothing, DataElements.Element380)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SVC01 As DataElements.Composite.C003 Implements SVC.SVC01
            Get
                Return CType(Elements(0), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(0) = value
            End Set
        End Property

        Private Property SVC01_IFace As Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.C003 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC.SVC01
            Get
                Return CType(SVC01, Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.C003)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2220D.SVC.SVC_01.C003)
                SVC01 = value
            End Set
        End Property

        Private Property SVC01_IFace_1 As Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.C003 Implements Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC.SVC01
            Get
                Return CType(SVC01, Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.C003)
            End Get
            Set(value As Transactions.Transaction277.Transaction277_A1.Composites.Loop2220E.SVC.SVC_01.C003)
                SVC01 = value
            End Set
        End Property

        Private Property SVC01_IFace_2 As Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_01.C003 Implements Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC01
            Get
                Return CType(SVC01, Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_01.C003)
            End Get
            Set(value As Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_01.C003)
                SVC01 = value
            End Set
        End Property

        Friend Property SVC02 As Decimal? Implements SVC.SVC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC.SVC02, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC.SVC02, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC02
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

        Friend Property SVC03 As Decimal? Implements SVC.SVC03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC.SVC03, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC.SVC03, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC03
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

        Friend Property SVC04 As String Implements SVC.SVC04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC.SVC04, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC.SVC04, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element234).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element234
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element234).Value = value
                End If
            End Set
        End Property

        Friend Property SVC05 As Decimal? Implements SVC.SVC05, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element380
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property SVC06 As DataElements.Composite.C003 Implements SVC.SVC06
            Get
                Return CType(Elements(5), DataElements.Composite.C003_Obj)
            End Get
            Set(value As DataElements.Composite.C003)
                Elements(5) = value
            End Set
        End Property

        Private Property SVC06_IFace As Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_06.C003 Implements Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC06
            Get
                Return CType(SVC06, Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_06.C003)
            End Get
            Set(value As Transactions.Transaction835.Transaction835_W1.Composites.Loop2110.SVC.SVC_06.C003)
                SVC06 = value
            End Set
        End Property

        Friend Property SVC07 As Decimal? Implements SVC.SVC07, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220D.SVC.SVC07, Transactions.Transaction277.Transaction277_A1.Segments.Loop2220E.SVC.SVC07, Transactions.Transaction835.Transaction835_W1.Segments.Loop2110.SVC.SVC07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element380
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SVC
            Dim rval As New SVC_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .SVC02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SVC03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SVC04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SVC05 = source.ToFloatValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .Elements(5) = DataElements.Composite.C003_Obj.FromReader(source.ToStringValue(5), reader)
                End If
                If source.Elements.Count > 6 Then
                    .SVC07 = source.ToFloatValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Service Information</summary>
    '''<remarks>To supply payment and control information to a provider for a particular service</remarks>
    Public Interface SVC
        Inherits ISegment

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks>SVC01 is the medical procedure upon which adjudication is based.</remarks>
        Property SVC01 As DataElements.Composite.C003

        '''<summary>Monetary Amount</summary>
        '''<remarks>SVC02 is the submitted service charge.</remarks>
        Property SVC02 As Decimal?

        '''<summary>Monetary Amount</summary>
        '''<remarks>SVC03 is the amount paid this service.</remarks>
        Property SVC03 As Decimal?

        '''<summary>Product/Service ID</summary>
        '''<remarks>SVC04 is the National Uniform Billing Committee Revenue Code.</remarks>
        Property SVC04 As String

        '''<summary>Quantity</summary>
        '''<remarks>SVC05 is the paid units of service.</remarks>
        Property SVC05 As Decimal?

        '''<summary>Composite Medical Procedure Identifier</summary>
        '''<remarks>SVC06 is the original submitted medical procedure.</remarks>
        Property SVC06 As DataElements.Composite.C003

        '''<summary>Quantity</summary>
        '''<remarks>SVC07 is the original submitted units of service.</remarks>
        Property SVC07 As Decimal?

    End Interface
End NameSpace