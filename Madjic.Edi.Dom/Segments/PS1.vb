Namespace Segments
    '''<summary>Purchase Service</summary>
    '''<remarks>To specify the information about services that are purchased</remarks>
    Partial Friend Class PS1_Obj
        Inherits Segment
        Implements PS1,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PS1
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("PS1")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element156)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PS101 As String Implements PS1.PS101, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PS1.PS101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element127
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property PS102 As Decimal? Implements PS1.PS102, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.PS1.PS102
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

        Friend Property PS103 As String Implements PS1.PS103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element156).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element156
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element156).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PS1
            Dim rval As New PS1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PS101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PS102 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PS103 = source.ToStringValue(2)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Purchase Service</summary>
    '''<remarks>To specify the information about services that are purchased</remarks>
    Public Interface PS1
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>PS101 is provider identification number.</remarks>
        Property PS101 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>PS102 is cost of the purchased service.</remarks>
        Property PS102 As Decimal?

        '''<summary>State or Province Code</summary>
        '''<remarks>PS103 is the state where the service is purchased.</remarks>
        Property PS103 As String

    End Interface
End NameSpace