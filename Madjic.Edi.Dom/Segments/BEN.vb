Namespace Segments
    '''<summary>Beneficiary or Owner Information</summary>
    '''<remarks>To supply beneficiary, co-participant, and owner information</remarks>
    Partial Friend Class BEN_Obj
        Inherits Segment
        Implements BEN

        Public Sub New()
            MyBase.New("BEN")
            Elements.AddRange({CType(Nothing, DataElements.Element1130),
                                      CType(Nothing, DataElements.Element954),
                                      CType(Nothing, DataElements.Element1069),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1187)})

            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property BEN01 As String Implements BEN.BEN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1130).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1130
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1130).Value = value
                End If
            End Set
        End Property

        Friend Property BEN02 As Decimal? Implements BEN.BEN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element954).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element954
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element954).Value = value
                End If
            End Set
        End Property

        Friend Property BEN03 As String Implements BEN.BEN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1069).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1069
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1069).Value = value
                End If
            End Set
        End Property

        Friend Property BEN04 As String Implements BEN.BEN04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1073
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property BEN05 As String Implements BEN.BEN05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1073
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property BEN06 As String Implements BEN.BEN06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1187).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1187
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1187).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As BEN
            Dim rval As New BEN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .BEN01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .BEN02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .BEN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .BEN04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .BEN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .BEN06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Beneficiary or Owner Information</summary>
    '''<remarks>To supply beneficiary, co-participant, and owner information</remarks>
    Public Interface BEN
        Inherits ISegment

        '''<summary>Primary or Contingent Code</summary>
        '''<remarks></remarks>
        Property BEN01 As String

        '''<summary>Percentage as Decimal</summary>
        '''<remarks>BEN02 is the percent of benefits that the beneficiary will receive.</remarks>
        Property BEN02 As Decimal?

        '''<summary>Individual Relationship Code</summary>
        '''<remarks></remarks>
        Property BEN03 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>BEN04 is the employee signature on file indicator. A "Y" value indicates the employee signature has been obtained and is on file; an "N" value indicates the employee signature has not been obtained.</remarks>
        Property BEN04 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>BEN05 is spouse signature on file indicator. A "Y" value indicates the spouse signature has been obtained and is on file; an "N" value indicates the spouse signature has not been obtained.</remarks>
        Property BEN05 As String

        '''<summary>Type of Account Code</summary>
        '''<remarks></remarks>
        Property BEN06 As String

    End Interface
End NameSpace