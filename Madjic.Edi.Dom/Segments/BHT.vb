Namespace Segments
    '''<summary>Beginning of Hierarchical Transaction</summary>
    '''<remarks>To define the business hierarchical structure of the transaction set and identify the business application purpose and reference data, i.e., number, date, and time</remarks>
    Partial Friend Class BHT_Obj
        Inherits Segment
        Implements BHT,
                   Transactions.Transaction270.Transaction270_B1.Segments.BHT,
                   Transactions.Transaction271.Transaction271_B1.Segments.BHT,
                   Transactions.Transaction277.Transaction277_A1.Segments.BHT,
                   Transactions.Transaction278.Transaction278_A1.Segments.BHT,
                   Transactions.Transaction278.Transaction278_A3.Segments.BHT,
                   Transactions.Transaction837.Transaction837_Q1.Segments.BHT,
                   Transactions.Transaction837.Transaction837_Q2.Segments.BHT,
                   Transactions.Transaction837.Transaction837_Q3.Segments.BHT
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2})}

        Public Sub New()
            MyBase.New("BHT")
            Elements.AddRange({CType(Nothing, DataElements.Element1005),
                                      CType(Nothing, DataElements.Element353),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element373),
                                      CType(Nothing, DataElements.Element337),
                                      CType(Nothing, DataElements.Element640)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property BHT01 As String Implements BHT.BHT01, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT01, Transactions.Transaction271.Transaction271_B1.Segments.BHT.BHT01, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT01, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT01, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT01, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT01, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT01, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element1005).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element1005
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element1005).Value = value
                End If
            End Set
        End Property

        Friend Property BHT02 As String Implements BHT.BHT02, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT02, Transactions.Transaction271.Transaction271_B1.Segments.BHT.BHT02, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT02, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT02, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT02, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT02, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT02, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element353).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element353
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element353).Value = value
                End If
            End Set
        End Property

        Friend Property BHT03 As String Implements BHT.BHT03, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT03, Transactions.Transaction271.Transaction271_B1.Segments.BHT.BHT03, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT03, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT03, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT03, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT03, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT03, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element127
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property BHT04 As Date? Implements BHT.BHT04, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT04, Transactions.Transaction271.Transaction271_B1.Segments.BHT.BHT04, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT04, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT04, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT04, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT04, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT04, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT04
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

        Friend Property BHT05 As TimeSpan? Implements BHT.BHT05, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT05, Transactions.Transaction271.Transaction271_B1.Segments.BHT.BHT05, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT05, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT05, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT05, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT05, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT05, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT05
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

        Friend Property BHT06 As String Implements BHT.BHT06, Transactions.Transaction270.Transaction270_B1.Segments.BHT.BHT06, Transactions.Transaction277.Transaction277_A1.Segments.BHT.BHT06, Transactions.Transaction278.Transaction278_A1.Segments.BHT.BHT06, Transactions.Transaction278.Transaction278_A3.Segments.BHT.BHT06, Transactions.Transaction837.Transaction837_Q1.Segments.BHT.BHT06, Transactions.Transaction837.Transaction837_Q2.Segments.BHT.BHT06, Transactions.Transaction837.Transaction837_Q3.Segments.BHT.BHT06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element640).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element640
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element640).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As BHT
            Dim rval As New BHT_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .BHT01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .BHT02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .BHT03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .BHT04 = source.ToDateValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .BHT05 = source.ToTimeSpanValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .BHT06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class
    '''<summary>Beginning of Hierarchical Transaction</summary>
    '''<remarks>To define the business hierarchical structure of the transaction set and identify the business application purpose and reference data, i.e., number, date, and time</remarks>
    Public Interface BHT
        Inherits ISegment

        '''<summary>Hierarchical Structure Code</summary>
        '''<remarks></remarks>
        Property BHT01 As String

        '''<summary>Transaction Set Purpose Code</summary>
        '''<remarks></remarks>
        Property BHT02 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>BHT03 is the number assigned by the originator to identify the transaction within the originator's business application system.</remarks>
        Property BHT03 As String

        '''<summary>Date</summary>
        '''<remarks>BHT04 is the date the transaction was created within the business application system.</remarks>
        Property BHT04 As Date?

        '''<summary>Time</summary>
        '''<remarks>BHT05 is the time the transaction was created within the business application system.</remarks>
        Property BHT05 As Timespan?

        '''<summary>Transaction Type Code</summary>
        '''<remarks></remarks>
        Property BHT06 As String

    End Interface
End NameSpace