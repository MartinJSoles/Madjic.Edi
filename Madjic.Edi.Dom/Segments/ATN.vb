Namespace Segments
    '''<summary>Attendance</summary>
    '''<remarks>To specify attendance information</remarks>
    Partial Friend Class ATN_Obj
        Inherits Segment
        Implements ATN
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("ATN")
            Elements.AddRange({CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element673),
                                      CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element1684),
                                      CType(Nothing, DataElements.Element352)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ATN01 As Decimal? Implements ATN.ATN01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element380
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property ATN02 As String Implements ATN.ATN02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element355
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property ATN03 As String Implements ATN.ATN03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element673).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element673
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element673).Value = value
                End If
            End Set
        End Property

        Friend Property ATN04 As String Implements ATN.ATN04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element594
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property ATN05 As String Implements ATN.ATN05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1684).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1684
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1684).Value = value
                End If
            End Set
        End Property

        Friend Property ATN06 As String Implements ATN.ATN06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element352).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element352
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element352).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ATN
            Dim rval As New ATN_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ATN01 = source.ToFloatValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ATN02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ATN03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .ATN04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .ATN05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .ATN06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Attendance</summary>
    '''<remarks>To specify attendance information</remarks>
    Public Interface ATN
        Inherits ISegment

        '''<summary>Quantity</summary>
        '''<remarks></remarks>
        Property ATN01 As Decimal?

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property ATN02 As String

        '''<summary>Quantity Qualifier</summary>
        '''<remarks></remarks>
        Property ATN03 As String

        '''<summary>Frequency Code</summary>
        '''<remarks></remarks>
        Property ATN04 As String

        '''<summary>Attendance Type Code</summary>
        '''<remarks></remarks>
        Property ATN05 As String

        '''<summary>Description</summary>
        '''<remarks></remarks>
        Property ATN06 As String

    End Interface
End NameSpace