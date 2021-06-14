Namespace Segments
    '''<summary>Home Health Treatment Plan Certification</summary>
    '''<remarks>To supply information related to the home health care plan of treatment and services</remarks>
    Partial Friend Class CR7_Obj
        Inherits Segment
        Implements CR7
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3})}

        Public Sub New()
            MyBase.New("CR7")
            Elements.AddRange({CType(Nothing, DataElements.Element921),
                                      CType(Nothing, DataElements.Element1470),
                                      CType(Nothing, DataElements.Element1470)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property CR701 As String Implements CR7.CR701
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element921).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element921
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element921).Value = value
                End If
            End Set
        End Property

        Friend Property CR702 As Decimal? Implements CR7.CR702
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1470
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Property CR703 As Decimal? Implements CR7.CR703
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1470).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1470
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1470).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As CR7
            Dim rval As New CR7_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .CR701 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .CR702 = source.ToDecimalValue(1, 0)
                End If
                If source.Elements.Count > 2 Then
                    .CR703 = source.ToDecimalValue(2, 0)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Home Health Treatment Plan Certification</summary>
    '''<remarks>To supply information related to the home health care plan of treatment and services</remarks>
    Public Interface CR7
        Inherits ISegment

        '''<summary>Discipline Type Code</summary>
        '''<remarks></remarks>
        Property CR701 As String

        '''<summary>Number</summary>
        '''<remarks>CR702 is the total visits on this bill rendered prior to the recertification "to" date.</remarks>
        Property CR702 As Decimal?

        '''<summary>Number</summary>
        '''<remarks>CR703 is the total visits projected during this certification period.</remarks>
        Property CR703 As Decimal?

    End Interface
End NameSpace