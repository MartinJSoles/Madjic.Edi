Namespace Segments
    '''<summary>Context</summary>
    '''<remarks>Describes an event context in terms of the application or implementation contexts in force at the time the event occurred and the position in the EDI stream at which that context was activated</remarks>
    Partial Friend Class CTX_Obj
        Inherits Segment
        Implements CTX,
                   Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX,
                   Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("CTX")
            Elements.AddRange({CType(Nothing, DataElements.Composite.C998_Obj),
                                      CType(Nothing, DataElements.Element721),
                                      CType(Nothing, DataElements.Element719),
                                      CType(Nothing, DataElements.Element447),
                                      CType(Nothing, DataElements.Composite.C030_Obj),
                                      CType(Nothing, DataElements.Composite.C999_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CTX01 As DataElements.Composite.C998 Implements CTX.CTX01, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX01, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX01
            Get
                Return CType(Elements(0), DataElements.Composite.C998_Obj)
            End Get
            Set(value As DataElements.Composite.C998)
                Elements(0) = value
            End Set
        End Property

        Friend Property CTX02 As String Implements CTX.CTX02, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX02, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element721).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element721
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element721).Value = value
                End If
            End Set
        End Property

        Friend Property CTX03 As Decimal? Implements CTX.CTX03, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX03, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element719).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element719
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element719).Value = value
                End If
            End Set
        End Property

        Friend Property CTX04 As String Implements CTX.CTX04, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX04, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element447).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element447
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element447).Value = value
                End If
            End Set
        End Property

        Friend Property CTX05 As DataElements.Composite.C030 Implements CTX.CTX05, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX05, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX05
            Get
                Return CType(Elements(4), DataElements.Composite.C030_Obj)
            End Get
            Set(value As DataElements.Composite.C030)
                Elements(4) = value
            End Set
        End Property

        Friend Property CTX06 As DataElements.Composite.C999 Implements CTX.CTX06, Transactions.Transaction999.Transaction999.Segments.Loop2000.CTX.CTX06, Transactions.Transaction999.Transaction999.Segments.Loop3000.CTX.CTX06
            Get
                Return CType(Elements(5), DataElements.Composite.C999_Obj)
            End Get
            Set(value As DataElements.Composite.C999)
                Elements(5) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CTX
            Dim rval As New CTX_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .Elements(0) = DataElements.Composite.C998_Obj.FromReader(source.ToStringValue(0), reader)
                End If
                If source.Elements.Count > 1 Then
                    .CTX02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CTX03 = source.ToDecimalValue(2, 0)
                End If
                If source.Elements.Count > 3 Then
                    .CTX04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C030_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .Elements(5) = DataElements.Composite.C999_Obj.FromReader(source.ToStringValue(5), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Context</summary>
    '''<remarks>Describes an event context in terms of the application or implementation contexts in force at the time the event occurred and the position in the EDI stream at which that context was activated</remarks>
    Public Interface CTX
        Inherits ISegment

        '''<summary>Context Identification</summary>
        '''<remarks></remarks>
        Property CTX01 As DataElements.Composite.C998

        '''<summary>Segment ID Code</summary>
        '''<remarks></remarks>
        Property CTX02 As String

        '''<summary>Segment Position in Transaction Set</summary>
        '''<remarks></remarks>
        Property CTX03 As Decimal?

        '''<summary>Loop Identifier Code</summary>
        '''<remarks></remarks>
        Property CTX04 As String

        '''<summary>Position in Segment</summary>
        '''<remarks></remarks>
        Property CTX05 As DataElements.Composite.C030

        '''<summary>Reference in Segment</summary>
        '''<remarks></remarks>
        Property CTX06 As DataElements.Composite.C999

    End Interface
End NameSpace