Namespace Segments
    '''<summary>Functional Group Response Trailer</summary>
    '''<remarks>To acknowledge acceptance or rejection of a functional group and report the number of included transaction sets from the original trailer, the accepted sets, and the received sets in this functional group</remarks>
    Partial Friend Class AK9_Obj
        Inherits Segment
        Implements AK9,
                   Transactions.Transaction999.Transaction999.Segments.AK9
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4})}

        Public Sub New()
            MyBase.New("AK9")
            Elements.AddRange({CType(Nothing, DataElements.Element715),
                                      CType(Nothing, DataElements.Element97),
                                      CType(Nothing, DataElements.Element123),
                                      CType(Nothing, DataElements.Element2),
                                      CType(Nothing, DataElements.Element716),
                                      CType(Nothing, DataElements.Element716),
                                      CType(Nothing, DataElements.Element716),
                                      CType(Nothing, DataElements.Element716),
                                      CType(Nothing, DataElements.Element716)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property AK901 As String Implements AK9.AK901, Transactions.Transaction999.Transaction999.Segments.AK9.AK901
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element715).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element715
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element715).Value = value
                End If
            End Set
        End Property

        Friend Property AK902 As Decimal? Implements AK9.AK902, Transactions.Transaction999.Transaction999.Segments.AK9.AK902
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element97).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element97
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element97).Value = value
                End If
            End Set
        End Property

        Friend Property AK903 As Decimal? Implements AK9.AK903, Transactions.Transaction999.Transaction999.Segments.AK9.AK903
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element123).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element123
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element123).Value = value
                End If
            End Set
        End Property

        Friend Property AK904 As Decimal? Implements AK9.AK904, Transactions.Transaction999.Transaction999.Segments.AK9.AK904
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element2).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element2
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element2).Value = value
                End If
            End Set
        End Property

        Friend Property AK905 As String Implements AK9.AK905, Transactions.Transaction999.Transaction999.Segments.AK9.AK905
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element716).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element716
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element716).Value = value
                End If
            End Set
        End Property

        Friend Property AK906 As String Implements AK9.AK906, Transactions.Transaction999.Transaction999.Segments.AK9.AK906
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element716).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element716
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element716).Value = value
                End If
            End Set
        End Property

        Friend Property AK907 As String Implements AK9.AK907, Transactions.Transaction999.Transaction999.Segments.AK9.AK907
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element716).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element716
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element716).Value = value
                End If
            End Set
        End Property

        Friend Property AK908 As String Implements AK9.AK908, Transactions.Transaction999.Transaction999.Segments.AK9.AK908
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element716).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element716
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element716).Value = value
                End If
            End Set
        End Property

        Friend Property AK909 As String Implements AK9.AK909, Transactions.Transaction999.Transaction999.Segments.AK9.AK909
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element716).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element716
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element716).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As AK9
            Dim rval As New AK9_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .AK901 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .AK902 = source.ToDecimalValue(1, 0)
                End If
                If source.Elements.Count > 2 Then
                    .AK903 = source.ToDecimalValue(2, 0)
                End If
                If source.Elements.Count > 3 Then
                    .AK904 = source.ToDecimalValue(3, 0)
                End If
                If source.Elements.Count > 4 Then
                    .AK905 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .AK906 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .AK907 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .AK908 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .AK909 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Functional Group Response Trailer</summary>
    '''<remarks>To acknowledge acceptance or rejection of a functional group and report the number of included transaction sets from the original trailer, the accepted sets, and the received sets in this functional group</remarks>
    Public Interface AK9
        Inherits ISegment

        '''<summary>Functional Group Acknowledgment Code</summary>
        '''<remarks></remarks>
        Property AK901 As String

        '''<summary>Number of Transaction Sets Included</summary>
        '''<remarks></remarks>
        Property AK902 As Decimal?

        '''<summary>Number of Received Transaction Sets</summary>
        '''<remarks></remarks>
        Property AK903 As Decimal?

        '''<summary>Number of Accepted Transaction Sets</summary>
        '''<remarks></remarks>
        Property AK904 As Decimal?

        '''<summary>Functional Group Syntax Error Code</summary>
        '''<remarks></remarks>
        Property AK905 As String

        '''<summary>Functional Group Syntax Error Code</summary>
        '''<remarks></remarks>
        Property AK906 As String

        '''<summary>Functional Group Syntax Error Code</summary>
        '''<remarks></remarks>
        Property AK907 As String

        '''<summary>Functional Group Syntax Error Code</summary>
        '''<remarks></remarks>
        Property AK908 As String

        '''<summary>Functional Group Syntax Error Code</summary>
        '''<remarks></remarks>
        Property AK909 As String

    End Interface
End NameSpace