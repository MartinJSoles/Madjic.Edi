Namespace Segments
    '''<summary>Health Care Services Review Information</summary>
    '''<remarks>To specify health care services review information</remarks>
    Partial Friend Class UM_Obj
        Inherits Segment
        Implements UM,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM,
                   Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("UM")
            Elements.AddRange({CType(Nothing, DataElements.Element1525),
                                      CType(Nothing, DataElements.Element1322),
                                      CType(Nothing, DataElements.Element1365),
                                      CType(Nothing, DataElements.Composite.C023_Obj),
                                      CType(Nothing, DataElements.Composite.C024_Obj),
                                      CType(Nothing, DataElements.Element1338),
                                      CType(Nothing, DataElements.Element1213),
                                      CType(Nothing, DataElements.Element923),
                                      CType(Nothing, DataElements.Element1363),
                                      CType(Nothing, DataElements.Element1514)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property UM01 As String Implements UM.UM01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM01, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM.UM01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM.UM01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM.UM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1525).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1525
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1525).Value = value
                End If
            End Set
        End Property

        Friend Property UM02 As String Implements UM.UM02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM02, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM.UM02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM.UM02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM.UM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1322).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1322
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1322).Value = value
                End If
            End Set
        End Property

        Friend Property UM03 As String Implements UM.UM03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM03, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM.UM03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM.UM03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM.UM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1365).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1365
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1365).Value = value
                End If
            End Set
        End Property

        Friend Property UM04 As DataElements.Composite.C023 Implements UM.UM04
            Get
                Return CType(Elements(3), DataElements.Composite.C023_Obj)
            End Get
            Set(value As DataElements.Composite.C023)
                Elements(3) = value
            End Set
        End Property

        Private Property UM04_IFace As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM04
            Get
                Return CType(UM04, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000E.UM.UM_04.C023)
                UM04 = value
            End Set
        End Property

        Private Property UM04_IFace_1 As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023 Implements Transactions.Transaction278.Transaction278_A1.Segments.Loop2000F.UM.UM04
            Get
                Return CType(UM04, Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A1.Composites.Loop2000F.UM.UM_04.C023)
                UM04 = value
            End Set
        End Property

        Private Property UM04_IFace_2 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04.C023 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM.UM04
            Get
                Return CType(UM04, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04.C023)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000E.UM.UM_04.C023)
                UM04 = value
            End Set
        End Property

        Private Property UM04_IFace_3 As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04.C023 Implements Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.UM.UM04
            Get
                Return CType(UM04, Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04.C023)
            End Get
            Set(value As Transactions.Transaction278.Transaction278_A3.Composites.Loop2000F.UM.UM_04.C023)
                UM04 = value
            End Set
        End Property

        Friend Property UM05 As DataElements.Composite.C024 Implements UM.UM05, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM05
            Get
                Return CType(Elements(4), DataElements.Composite.C024_Obj)
            End Get
            Set(value As DataElements.Composite.C024)
                Elements(4) = value
            End Set
        End Property

        Friend Property UM06 As String Implements UM.UM06, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM06, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.UM.UM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1338).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1338
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1338).Value = value
                End If
            End Set
        End Property

        Friend Property UM07 As String Implements UM.UM07, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element1213).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element1213
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element1213).Value = value
                End If
            End Set
        End Property

        Friend Property UM08 As String Implements UM.UM08, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element923).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element923
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element923).Value = value
                End If
            End Set
        End Property

        Friend Property UM09 As String Implements UM.UM09, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1363).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1363
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1363).Value = value
                End If
            End Set
        End Property

        Friend Property UM10 As String Implements UM.UM10, Transactions.Transaction278.Transaction278_A1.Segments.Loop2000E.UM.UM10
            Get
                Return If(Elements(9) IsNot Nothing, CType(Elements(9), DataElements.Element1514).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(9) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(9) = New DataElements.Element1514
                End If

                If Elements(9) IsNot Nothing Then
                    CType(Elements(9), DataElements.Element1514).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As UM
            Dim rval As New UM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .UM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .UM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .UM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C023_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .Elements(4) = DataElements.Composite.C024_Obj.FromReader(source.ToStringValue(4), reader)
                End If
                If source.Elements.Count > 5 Then
                    .UM06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .UM07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .UM08 = source.ToStringValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .UM09 = source.ToStringValue(8)
                End If
                If source.Elements.Count > 9 Then
                    .UM10 = source.ToStringValue(9)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Care Services Review Information</summary>
    '''<remarks>To specify health care services review information</remarks>
    Public Interface UM
        Inherits ISegment

        '''<summary>Request Category Code</summary>
        '''<remarks></remarks>
        Property UM01 As String

        '''<summary>Certification Type Code</summary>
        '''<remarks></remarks>
        Property UM02 As String

        '''<summary>Service Type Code</summary>
        '''<remarks></remarks>
        Property UM03 As String

        '''<summary>Health Care Service Location Information</summary>
        '''<remarks></remarks>
        Property UM04 As DataElements.Composite.C023

        '''<summary>Related Causes Information</summary>
        '''<remarks></remarks>
        Property UM05 As DataElements.Composite.C024

        '''<summary>Level of Service Code</summary>
        '''<remarks></remarks>
        Property UM06 As String

        '''<summary>Current Health Condition Code</summary>
        '''<remarks></remarks>
        Property UM07 As String

        '''<summary>Prognosis Code</summary>
        '''<remarks></remarks>
        Property UM08 As String

        '''<summary>Release of Information Code</summary>
        '''<remarks></remarks>
        Property UM09 As String

        '''<summary>Delay Reason Code</summary>
        '''<remarks></remarks>
        Property UM10 As String

    End Interface
End NameSpace