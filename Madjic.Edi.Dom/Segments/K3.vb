Namespace Segments
    '''<summary>File Information</summary>
    '''<remarks>To transmit a fixed-format record or matrix contents</remarks>
    Partial Friend Class K3_Obj
        Inherits Segment
        Implements K3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.K3,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.K3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.K3,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.K3,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.K3
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("K3")
            Elements.AddRange({CType(Nothing, DataElements.Element449),
                                      CType(Nothing, DataElements.Element1333),
                                      CType(Nothing, DataElements.Composite.C001_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property K301 As String Implements K3.K301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2300.K3.K301, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2400.K3.K301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2300.K3.K301, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.K3.K301, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.K3.K301
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element449).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element449
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element449).Value = value
                End If
            End Set
        End Property

        Friend Property K302 As String Implements K3.K302
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1333).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1333
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1333).Value = value
                End If
            End Set
        End Property

        Friend Property K303 As DataElements.Composite.C001 Implements K3.K303
            Get
                Return CType(Elements(2), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(2) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As K3
            Dim rval As New K3_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .K301 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .K302 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(2), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>File Information</summary>
    '''<remarks>To transmit a fixed-format record or matrix contents</remarks>
    Public Interface K3
        Inherits ISegment

        '''<summary>Fixed Format Information</summary>
        '''<remarks></remarks>
        Property K301 As String

        '''<summary>Record Format Code</summary>
        '''<remarks>The default for K302 is content.</remarks>
        Property K302 As String

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks>K303 identifies the value of the index.</remarks>
        Property K303 As DataElements.Composite.C001

    End Interface
End NameSpace