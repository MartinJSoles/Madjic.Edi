Namespace Segments
    '''<summary>Other Health Insurance Information</summary>
    '''<remarks>To specify information associated with other health insurance coverage</remarks>
    Partial Friend Class OI_Obj
        Inherits Segment
        Implements OI,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.OI,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.OI,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.OI

        Public Sub New()
            MyBase.New("OI")
            Elements.AddRange({CType(Nothing, DataElements.Element1032),
                                      CType(Nothing, DataElements.Element1383),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1351),
                                      CType(Nothing, DataElements.Element1360),
                                      CType(Nothing, DataElements.Element1363)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property OI01 As String Implements OI.OI01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1032).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1032
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1032).Value = value
                End If
            End Set
        End Property

        Friend Property OI02 As String Implements OI.OI02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1383).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1383
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1383).Value = value
                End If
            End Set
        End Property

        Friend Property OI03 As String Implements OI.OI03, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.OI.OI03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.OI.OI03, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.OI.OI03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1073
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property OI04 As String Implements OI.OI04, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.OI.OI04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1351).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1351
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1351).Value = value
                End If
            End Set
        End Property

        Friend Property OI05 As String Implements OI.OI05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1360).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1360
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1360).Value = value
                End If
            End Set
        End Property

        Friend Property OI06 As String Implements OI.OI06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2320.OI.OI06, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2320.OI.OI06, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2320.OI.OI06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1363).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1363
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1363).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As OI
            Dim rval As New OI_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .OI01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .OI02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .OI03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .OI04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .OI05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .OI06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Other Health Insurance Information</summary>
    '''<remarks>To specify information associated with other health insurance coverage</remarks>
    Public Interface OI
        Inherits ISegment

        '''<summary>Claim Filing Indicator Code</summary>
        '''<remarks></remarks>
        Property OI01 As String

        '''<summary>Claim Submission Reason Code</summary>
        '''<remarks></remarks>
        Property OI02 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>OI03 is the assignment of benefits indicator. A "Y" value indicates insured or authorized person authorizes benefits to be assigned to the provider; an "N" value indicates benefits have not been assigned to the provider.</remarks>
        Property OI03 As String

        '''<summary>Patient Signature Source Code</summary>
        '''<remarks></remarks>
        Property OI04 As String

        '''<summary>Provider Agreement Code</summary>
        '''<remarks></remarks>
        Property OI05 As String

        '''<summary>Release of Information Code</summary>
        '''<remarks></remarks>
        Property OI06 As String

    End Interface
End NameSpace