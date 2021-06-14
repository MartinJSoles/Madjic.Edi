Namespace Segments
    '''<summary>Tooth Identification</summary>
    '''<remarks>To identify a tooth by number and, if applicable, one or more tooth surfaces</remarks>
    Partial Friend Class TOO_Obj
        Inherits Segment
        Implements TOO,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({1, 2})}

        Public Sub New()
            MyBase.New("TOO")
            Elements.AddRange({CType(Nothing, DataElements.Element1270),
                                      CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Composite.C005_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property TOO01 As String Implements TOO.TOO01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO.TOO01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO.TOO01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO.TOO01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1270).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1270
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1270).Value = value
                End If
            End Set
        End Property

        Friend Property TOO02 As String Implements TOO.TOO02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO.TOO02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO.TOO02, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO.TOO02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1271
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property TOO03 As DataElements.Composite.C005 Implements TOO.TOO03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.TOO.TOO03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.TOO.TOO03, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2400.TOO.TOO03
            Get
                Return CType(Elements(2), DataElements.Composite.C005_Obj)
            End Get
            Set(value As DataElements.Composite.C005)
                Elements(2) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As TOO
            Dim rval As New TOO_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .TOO01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .TOO02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .Elements(2) = DataElements.Composite.C005_Obj.FromReader(source.ToStringValue(2), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Tooth Identification</summary>
    '''<remarks>To identify a tooth by number and, if applicable, one or more tooth surfaces</remarks>
    Public Interface TOO
        Inherits ISegment

        '''<summary>Code List Qualifier Code</summary>
        '''<remarks></remarks>
        Property TOO01 As String

        '''<summary>Industry Code</summary>
        '''<remarks></remarks>
        Property TOO02 As String

        '''<summary>Tooth Surface</summary>
        '''<remarks></remarks>
        Property TOO03 As DataElements.Composite.C005

    End Interface
End NameSpace