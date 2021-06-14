Namespace Segments
    '''<summary>Rate Amounts or Percents</summary>
    '''<remarks>To identify rate amounts or percents for a specific cost or other line item</remarks>
    Partial Friend Class RPA_Obj
        Inherits Segment
        Implements RPA
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("RPA")
            Elements.AddRange({CType(Nothing, DataElements.Element562),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element118),
                                      CType(Nothing, DataElements.Composite.C001_Obj),
                                      CType(Nothing, DataElements.Element954)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property RPA01 As String Implements RPA.RPA01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element562).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element562
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element562).Value = value
                End If
            End Set
        End Property

        Friend Property RPA02 As Decimal? Implements RPA.RPA02
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

        Friend Property RPA03 As Decimal? Implements RPA.RPA03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element118).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element118
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element118).Value = value
                End If
            End Set
        End Property

        Friend Property RPA04 As DataElements.Composite.C001 Implements RPA.RPA04
            Get
                Return CType(Elements(3), DataElements.Composite.C001_Obj)
            End Get
            Set(value As DataElements.Composite.C001)
                Elements(3) = value
            End Set
        End Property

        Friend Property RPA05 As Decimal? Implements RPA.RPA05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element954
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As RPA
            Dim rval As New RPA_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .RPA01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .RPA02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .RPA03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .Elements(3) = DataElements.Composite.C001_Obj.FromReader(source.ToStringValue(3), reader)
                End If
                If source.Elements.Count > 4 Then
                    .RPA05 = source.ToFloatValue(4)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Rate Amounts or Percents</summary>
    '''<remarks>To identify rate amounts or percents for a specific cost or other line item</remarks>
    Public Interface RPA
        Inherits ISegment

        '''<summary>Rate or Value Type Code</summary>
        '''<remarks></remarks>
        Property RPA01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks></remarks>
        Property RPA02 As Decimal?

        '''<summary>Rate</summary>
        '''<remarks></remarks>
        Property RPA03 As Decimal?

        '''<summary>Composite Unit of Measure</summary>
        '''<remarks></remarks>
        Property RPA04 As DataElements.Composite.C001

        '''<summary>Percentage as Decimal</summary>
        '''<remarks></remarks>
        Property RPA05 As Decimal?

    End Interface
End NameSpace