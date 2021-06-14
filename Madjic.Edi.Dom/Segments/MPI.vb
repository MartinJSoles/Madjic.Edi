Namespace Segments
    '''<summary>Military Personnel Information</summary>
    '''<remarks>To report military service data</remarks>
    Partial Friend Class MPI_Obj
        Inherits Segment
        Implements MPI,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI,
                   Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({6, 7}),
                                                 New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("MPI")
            Elements.AddRange({CType(Nothing, DataElements.Element1201),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element1595),
                                      CType(Nothing, DataElements.Element352),
                                      CType(Nothing, DataElements.Element1596),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property MPI01 As String Implements MPI.MPI01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI01, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1201).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1201
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1201).Value = value
                End If
            End Set
        End Property

        Friend Property MPI02 As String Implements MPI.MPI02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI02, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element584).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element584
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element584).Value = value
                End If
            End Set
        End Property

        Friend Property MPI03 As String Implements MPI.MPI03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI03, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1595).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1595
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1595).Value = value
                End If
            End Set
        End Property

        Friend Property MPI04 As String Implements MPI.MPI04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI04, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element352
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Property MPI05 As String Implements MPI.MPI05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI05, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1596).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1596
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1596).Value = value
                End If
            End Set
        End Property

        Friend Property MPI06 As String Implements MPI.MPI06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI06, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1250
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property MPI07 As String Implements MPI.MPI07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100C.MPI.MPI07, Transactions.Transaction271.Transaction271_B1.Segments.Loop2100D.MPI.MPI07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1251
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As MPI
            Dim rval As New MPI_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .MPI01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .MPI02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .MPI03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .MPI04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .MPI05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .MPI06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .MPI07 = source.ToStringValue(6)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Military Personnel Information</summary>
    '''<remarks>To report military service data</remarks>
    Public Interface MPI
        Inherits ISegment

        '''<summary>Information Status Code</summary>
        '''<remarks></remarks>
        Property MPI01 As String

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property MPI02 As String

        '''<summary>Government Service Affiliation Code</summary>
        '''<remarks></remarks>
        Property MPI03 As String

        '''<summary>Description</summary>
        '''<remarks>MPI04 is the actual response to further identify the exact military unit.</remarks>
        Property MPI04 As String

        '''<summary>Military Service Rank Code</summary>
        '''<remarks></remarks>
        Property MPI05 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property MPI06 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>MPI07 indicates the date span of military service.</remarks>
        Property MPI07 As String

    End Interface
End NameSpace