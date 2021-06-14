Namespace Segments
    '''<summary>Durable Medical Equipment Certification</summary>
    '''<remarks>To supply information regarding a physician's certification for durable medical equipment</remarks>
    Partial Friend Class CR3_Obj
        Inherits Segment
        Implements CR3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({2, 3})}

        Public Sub New()
            MyBase.New("CR3")
            Elements.AddRange({CType(Nothing, DataElements.Element1322),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element1335),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR301 As String Implements CR3.CR301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3.CR301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1322).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1322
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1322).Value = value
                End If
            End Set
        End Property

        Friend Property CR302 As String Implements CR3.CR302, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3.CR302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element355
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property CR303 As Decimal? Implements CR3.CR303, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.CR3.CR303
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property CR304 As String Implements CR3.CR304
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1335).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1335
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1335).Value = value
                End If
            End Set
        End Property

        Friend Property CR305 As String Implements CR3.CR305
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR3
            Dim rval As New CR3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR301 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR302 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CR303 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CR304 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .CR305 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Durable Medical Equipment Certification</summary>
    '''<remarks>To supply information regarding a physician's certification for durable medical equipment</remarks>
    Public Interface CR3
        Inherits ISegment

        '''<summary>Certification Type Code</summary>
        '''<remarks></remarks>
        Property CR301 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks>CR302 and CR303 specify the time period covered by this certification.</remarks>
        Property CR302 As String

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property CR303 As Decimal?

        '''<summary>Insulin Dependent Code</summary>
        '''<remarks></remarks>
        Property CR304 As String

        '''<summary>Description</summary>
        '''<remarks>CR305 is the prognosis of the patient.</remarks>
        Property CR305 As String

    End Interface
End NameSpace