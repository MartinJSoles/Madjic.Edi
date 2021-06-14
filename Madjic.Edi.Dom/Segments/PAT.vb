Namespace Segments
    '''<summary>Patient Information</summary>
    '''<remarks>To supply patient information</remarks>
    Partial Friend Class PAT_Obj
        Inherits Segment
        Implements PAT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.PAT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.PAT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRulePaired({5, 6}),
                                                 New SyntaxRulePaired({7, 8})}

        Public Sub New()
            MyBase.New("PAT")
            Elements.AddRange({CType(Nothing, DataElements.Element1069),
                                      CType(Nothing, DataElements.Element1384),
                                      CType(Nothing, DataElements.Element584),
                                      CType(Nothing, DataElements.Element1220),
                                      CType(Nothing, DataElements.Element1250),
                                      CType(Nothing, DataElements.Element1251),
                                      CType(Nothing, DataElements.Element355),
                                      CType(Nothing, DataElements.Element81),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PAT01 As String Implements PAT.PAT01, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT01, Transactions.Transaction837.Transaction837_Q2.Segments.Loop2000C.PAT.PAT01, Transactions.Transaction837.Transaction837_Q3.Segments.Loop2000C.PAT.PAT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1069).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1069
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1069).Value = value
                End If
            End Set
        End Property

        Friend Property PAT02 As String Implements PAT.PAT02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element1384).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element1384
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element1384).Value = value
                End If
            End Set
        End Property

        Friend Property PAT03 As String Implements PAT.PAT03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element584).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element584
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element584).Value = value
                End If
            End Set
        End Property

        Friend Property PAT04 As String Implements PAT.PAT04
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1220).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1220
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1220).Value = value
                End If
            End Set
        End Property

        Friend Property PAT05 As String Implements PAT.PAT05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT.PAT05, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element1250).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element1250
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element1250).Value = value
                End If
            End Set
        End Property

        Friend Property PAT06 As String Implements PAT.PAT06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT.PAT06, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1251).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1251
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1251).Value = value
                End If
            End Set
        End Property

        Friend Property PAT07 As String Implements PAT.PAT07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT.PAT07, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT07
            Get
                Return If(Elements(6) IsNot Nothing, CType(Elements(6), DataElements.Element355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(6) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(6) = New DataElements.Element355
                End If

                If Elements(6) IsNot Nothing Then
                    CType(Elements(6), DataElements.Element355).Value = value
                End If
            End Set
        End Property

        Friend Property PAT08 As Decimal? Implements PAT.PAT08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT.PAT08, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT08
            Get
                Return If(Elements(7) IsNot Nothing, CType(Elements(7), DataElements.Element81).Value, Nothing)
            End Get
            Set(value As Decimal?)
                If Elements(7) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(7) = New DataElements.Element81
                End If

                If Elements(7) IsNot Nothing Then
                    CType(Elements(7), DataElements.Element81).Value = value
                End If
            End Set
        End Property

        Friend Property PAT09 As String Implements PAT.PAT09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000B.PAT.PAT09, Transactions.Transaction837.Transaction837_Q1.Segments.Loop2000C.PAT.PAT09
            Get
                Return If(Elements(8) IsNot Nothing, CType(Elements(8), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(8) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(8) = New DataElements.Element1073
                End If

                If Elements(8) IsNot Nothing Then
                    CType(Elements(8), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PAT
            Dim rval As New PAT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PAT01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PAT02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PAT03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PAT04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PAT05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PAT06 = source.ToStringValue(5)
                End If
                If source.Elements.Count > 6 Then
                    .PAT07 = source.ToStringValue(6)
                End If
                If source.Elements.Count > 7 Then
                    .PAT08 = source.ToFloatValue(7)
                End If
                If source.Elements.Count > 8 Then
                    .PAT09 = source.ToStringValue(8)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Patient Information</summary>
    '''<remarks>To supply patient information</remarks>
    Public Interface PAT
        Inherits ISegment

        '''<summary>Individual Relationship Code</summary>
        '''<remarks></remarks>
        Property PAT01 As String

        '''<summary>Patient Location Code</summary>
        '''<remarks></remarks>
        Property PAT02 As String

        '''<summary>Employment Status Code</summary>
        '''<remarks></remarks>
        Property PAT03 As String

        '''<summary>Student Status Code</summary>
        '''<remarks></remarks>
        Property PAT04 As String

        '''<summary>Date Time Period Format Qualifier</summary>
        '''<remarks></remarks>
        Property PAT05 As String

        '''<summary>Date Time Period</summary>
        '''<remarks>PAT06 is the date of death.</remarks>
        Property PAT06 As String

        '''<summary>Unit or Basis for Measurement Code</summary>
        '''<remarks></remarks>
        Property PAT07 As String

        '''<summary>Weight</summary>
        '''<remarks>PAT08 is the patient's weight.</remarks>
        Property PAT08 As Decimal?

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>PAT09 indicates whether the patient is pregnant or not pregnant. Code "Y" indicates the patient is pregnant; code "N" indicates the patient is not pregnant.</remarks>
        Property PAT09 As String

    End Interface
End NameSpace