Namespace Segments
    '''<summary>Claim Codes</summary>
    '''<remarks>To supply information specific to hospital claims</remarks>
    Partial Friend Class CL1_Obj
        Inherits Segment
        Implements CL1,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CL1

        Public Sub New()
            MyBase.New("CL1")
            Elements.AddRange({CType(Nothing, DataElements.Element1315),
                                      CType(Nothing, DataElements.Element1314),
                                      CType(Nothing, DataElements.Element1352),
                                      CType(Nothing, DataElements.Element1345)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CL101 As String Implements CL1.CL101, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1.CL101, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1.CL101, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CL1.CL101
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1315).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1315
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1315).Value = value
                End If
            End Set
        End Property

        Friend Property CL102 As String Implements CL1.CL102, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1.CL102, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1.CL102, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CL1.CL102
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1314).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1314
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1314).Value = value
                End If
            End Set
        End Property

        Friend Property CL103 As String Implements CL1.CL103, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1.CL103, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.CL1.CL103, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2300.CL1.CL103
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1352
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1352).Value = value
                End If
            End Set
        End Property

        Friend Property CL104 As String Implements CL1.CL104, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.CL1.CL104
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1345).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1345
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1345).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CL1
            Dim rval As New CL1_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CL101 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CL102 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .CL103 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .CL104 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Claim Codes</summary>
    '''<remarks>To supply information specific to hospital claims</remarks>
    Public Interface CL1
        Inherits ISegment

        '''<summary>Admission Type Code</summary>
        '''<remarks></remarks>
        Property CL101 As String

        '''<summary>Admission Source Code</summary>
        '''<remarks></remarks>
        Property CL102 As String

        '''<summary>Patient Status Code</summary>
        '''<remarks></remarks>
        Property CL103 As String

        '''<summary>Nursing Home Residential Status Code</summary>
        '''<remarks></remarks>
        Property CL104 As String

    End Interface
End NameSpace