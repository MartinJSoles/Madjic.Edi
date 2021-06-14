Namespace Segments
    '''<summary>Extended Reference Information</summary>
    '''<remarks>To transmit identifying information as specified by the Reference Identification Qualifier</remarks>
    Partial Friend Class N9_Obj
        Inherits Segment
        Implements N9
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("N9")
            Elements.AddRange({CType(Nothing, DataElements.Element128),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element369),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element623),
                                      CType(Nothing, DataElements.Composite.C040_Obj)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property N901 As String Implements N9.N901
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element128).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element128
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element128).Value = value
                End If
            End Set
        End Property

        Friend Property N902 As String Implements N9.N902
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element127
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property N903 As String Implements N9.N903
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element369).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element369
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element369).Value = value
                End If
            End Set
        End Property

        Friend Property N904 As Date? Implements N9.N904
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element373).Value, Nothing)
            End Get
            Set(value As Date?)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element373
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element373).Value = value
                End If
            End Set
        End Property

        Friend Property N905 As TimeSpan? Implements N9.N905
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element337).Value, Nothing)
            End Get
            Set(value As TimeSpan?)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element337
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element337).Value = value
                End If
            End Set
        End Property

        Friend Property N906 As String Implements N9.N906
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element623).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element623
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element623).Value = value
                End If
            End Set
        End Property

        Friend Property N907 As DataElements.Composite.C040 Implements N9.N907
            Get
                Return CType(Elements(6), DataElements.Composite.C040_Obj)
            End Get
            Set(value As DataElements.Composite.C040)
                Elements(6) = value
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As N9
            Dim rval As New N9_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .N901 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .N902 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .N903 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .N904 = source.ToDateValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .N905 = source.ToTimeSpanValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .N906 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .Elements(6) = DataElements.Composite.C040_Obj.FromReader(source.ToStringValue(6), reader)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Extended Reference Information</summary>
    '''<remarks>To transmit identifying information as specified by the Reference Identification Qualifier</remarks>
    Public Interface N9
        Inherits ISegment

        '''<summary>Reference Identification Qualifier</summary>
        '''<remarks></remarks>
        Property N901 As String

        '''<summary>Reference Identification</summary>
        '''<remarks></remarks>
        Property N902 As String

        '''<summary>Free-form Description</summary>
        '''<remarks></remarks>
        Property N903 As String

        '''<summary>Date</summary>
        '''<remarks></remarks>
        Property N904 As Date?

        '''<summary>Time</summary>
        '''<remarks></remarks>
        Property N905 As Timespan?

        '''<summary>Time Code</summary>
        '''<remarks></remarks>
        Property N906 As String

        '''<summary>Reference Identifier</summary>
        '''<remarks></remarks>
        Property N907 As DataElements.Composite.C040

    End Interface
End NameSpace