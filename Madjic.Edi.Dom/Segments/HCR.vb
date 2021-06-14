Namespace Segments
    '''<summary>Health Care Services Review</summary>
    '''<remarks>To specify the outcome of a health care services review</remarks>
    Partial Friend Class HCR_Obj
        Inherits Segment
        Implements HCR,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR,
                   Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1})}

        Public Sub New()
            MyBase.New("HCR")
            Elements.AddRange({CType(Nothing, DataElements.Element306),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1271),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property HCR01 As String Implements HCR.HCR01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR.HCR01, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR.HCR01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element306).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element306
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element306).Value = value
                End If
            End Set
        End Property

        Friend Property HCR02 As String Implements HCR.HCR02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR.HCR02, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR.HCR02
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

        Friend Property HCR03 As String Implements HCR.HCR03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR.HCR03, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR.HCR03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1271).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1271
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1271).Value = value
                End If
            End Set
        End Property

        Friend Property HCR04 As String Implements HCR.HCR04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000E.HCR.HCR04, Transactions.Transaction278.Transaction278_A3.Segments.Loop2000F.HCR.HCR04
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

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As HCR
            Dim rval As New HCR_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .HCR01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .HCR02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .HCR03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .HCR04 = source.ToStringValue(3)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Health Care Services Review</summary>
    '''<remarks>To specify the outcome of a health care services review</remarks>
    Public Interface HCR
        Inherits ISegment

        '''<summary>Action Code</summary>
        '''<remarks></remarks>
        Property HCR01 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>HCR02 is the number assigned by the information source to this review outcome.</remarks>
        Property HCR02 As String

        '''<summary>Industry Code</summary>
        '''<remarks>HCR03 is the code assigned by the information source to identify the reason for the health care service review outcome indicated in HCR01.See Code Source 886</remarks>
        Property HCR03 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>HCR04 is the second surgical opinion indicator. A "Y" value indicates a second surgical opinion is required; an "N" value indicates a second surgical opinion is not required for this request.</remarks>
        Property HCR04 As String

    End Interface
End NameSpace