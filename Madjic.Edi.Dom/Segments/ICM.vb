Namespace Segments
    '''<summary>Individual Income</summary>
    '''<remarks>To supply information to determine benefit eligibility, deductibles, and retirement and investment contributions</remarks>
    Partial Friend Class ICM_Obj
        Inherits Segment
        Implements ICM,
                   Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("ICM")
            Elements.AddRange({CType(Nothing, DataElements.Element594),
                                      CType(Nothing, DataElements.Element782),
                                      CType(Nothing, DataElements.Element380),
                                      CType(Nothing, DataElements.Element310),
                                      CType(Nothing, DataElements.Element1214),
                                      CType(Nothing, DataElements.Element100)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property ICM01 As String Implements ICM.ICM01, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM.ICM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element594).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element594
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element594).Value = value
                End If
            End Set
        End Property

        Friend Property ICM02 As Decimal? Implements ICM.ICM02, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM.ICM02
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

        Friend Property ICM03 As Decimal? Implements ICM.ICM03, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM.ICM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element380).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element380
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element380).Value = value
                End If
            End Set
        End Property

        Friend Property ICM04 As String Implements ICM.ICM04, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM.ICM04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element310).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element310
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element310).Value = value
                End If
            End Set
        End Property

        Friend Property ICM05 As String Implements ICM.ICM05, Transactions.Transaction834.Transaction834_A1.Segments.Loop2100A.ICM.ICM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1214).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1214
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1214).Value = value
                End If
            End Set
        End Property

        Friend Property ICM06 As String Implements ICM.ICM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element100).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element100
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element100).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As ICM
            Dim rval As New ICM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .ICM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .ICM02 = source.ToFloatValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .ICM03 = source.ToFloatValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .ICM04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .ICM05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .ICM06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Individual Income</summary>
    '''<remarks>To supply information to determine benefit eligibility, deductibles, and retirement and investment contributions</remarks>
    Public Interface ICM
        Inherits ISegment

        '''<summary>Frequency Code</summary>
        '''<remarks>ICM01 is the frequency at which an individual's wages are paid.</remarks>
        Property ICM01 As String

        '''<summary>Monetary Amount</summary>
        '''<remarks>ICM02 is the yearly wages amount.</remarks>
        Property ICM02 As Decimal?

        '''<summary>Quantity</summary>
        '''<remarks>ICM03 is the weekly hours.</remarks>
        Property ICM03 As Decimal?

        '''<summary>Location Identifier</summary>
        '''<remarks>ICM04 is the employer location qualifier such as a department number.</remarks>
        Property ICM04 As String

        '''<summary>Salary Grade</summary>
        '''<remarks></remarks>
        Property ICM05 As String

        '''<summary>Currency Code</summary>
        '''<remarks></remarks>
        Property ICM06 As String

    End Interface
End NameSpace