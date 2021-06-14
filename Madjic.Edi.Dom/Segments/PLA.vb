Namespace Segments
    '''<summary>Place or Location</summary>
    '''<remarks>To indicate action to be taken for the location specified and to qualify the location specified</remarks>
    Partial Friend Class PLA_Obj
        Inherits Segment
        Implements PLA,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("PLA")
            Elements.AddRange({CType(Nothing, DataElements.Element306),
                                      CType(Nothing, DataElements.Element98),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element1203)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PLA01 As String Implements PLA.PLA01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA.PLA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element306
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Property PLA02 As String Implements PLA.PLA02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA.PLA02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element98).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element98
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element98).Value = value
                End If
            End Set
        End Property

        Friend Property PLA03 As Date? Implements PLA.PLA03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA.PLA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element373
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property PLA04 As TimeSpan? Implements PLA.PLA04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element337
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property PLA05 As String Implements PLA.PLA05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2310.PLA.PLA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1203).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1203
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1203).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PLA
            Dim rval As New PLA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PLA01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PLA02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PLA03 = source.ToDateValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PLA04 = source.ToTimeSpanValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PLA05 = source.ToStringValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Place or Location</summary>
    '''<remarks>To indicate action to be taken for the location specified and to qualify the location specified</remarks>
    Public Interface PLA
        Inherits ISegment

        '''<summary>Action Code</summary>
        '''<remarks></remarks>
        Property PLA01 As String

        '''<summary>Entity Identifier Code</summary>
        '''<remarks></remarks>
        Property PLA02 As String

        '''<summary>Date</summary>
        '''<remarks>PLA03 is the effective date for the action identified in PLA01.</remarks>
        Property PLA03 As Date?

        '''<summary>Time</summary>
        '''<remarks>When used, PLA04 is the effective time for the action identified in PLA01.</remarks>
        Property PLA04 As Timespan?

        '''<summary>Maintenance Reason Code</summary>
        '''<remarks></remarks>
        Property PLA05 As String

    End Interface
End NameSpace