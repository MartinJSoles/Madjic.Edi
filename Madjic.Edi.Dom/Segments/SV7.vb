Namespace Segments
    '''<summary>Drug Adjudication</summary>
    '''<remarks>To specify the claim service detail for drug services that have been adjudicated</remarks>
    Partial Friend Class SV7_Obj
        Inherits Segment
        Implements SV7
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({4, 5})}

        Public Sub New()
            MyBase.New("SV7")
            Elements.AddRange({CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element127),
                                      CType(Nothing, DataElements.Element1355),
                                      CType(Nothing, DataElements.Element1207),
                                      CType(Nothing, DataElements.Element750),
                                      CType(Nothing, DataElements.Element1073)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property SV701 As String Implements SV7.SV701
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element127).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element127
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element127).Value = value
                End If
            End Set
        End Property

        Friend Property SV702 As String Implements SV7.SV702
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

        Friend Property SV703 As String Implements SV7.SV703
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1355).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1355
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1355).Value = value
                End If
            End Set
        End Property

        Friend Property SV704 As String Implements SV7.SV704
            Get
                Return If(Elements(3) IsNot Nothing, CType(Elements(3), DataElements.Element1207).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(3) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(3) = New DataElements.Element1207
                End If

                If Elements(3) IsNot Nothing Then
                    CType(Elements(3), DataElements.Element1207).Value = value
                End If
            End Set
        End Property

        Friend Property SV705 As String Implements SV7.SV705
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element750).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element750
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element750).Value = value
                End If
            End Set
        End Property

        Friend Property SV706 As String Implements SV7.SV706
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element1073
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As SV7
            Dim rval As New SV7_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .SV701 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .SV702 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .SV703 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .SV704 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .SV705 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .SV706 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Drug Adjudication</summary>
    '''<remarks>To specify the claim service detail for drug services that have been adjudicated</remarks>
    Public Interface SV7
        Inherits ISegment

        '''<summary>Reference Identification</summary>
        '''<remarks>SV701 is an internal processing identification number.</remarks>
        Property SV701 As String

        '''<summary>Reference Identification</summary>
        '''<remarks>SV702 is the number assigned to the doctor who wrote the prescription.</remarks>
        Property SV702 As String

        '''<summary>Prescription Denial Override Code</summary>
        '''<remarks></remarks>
        Property SV703 As String

        '''<summary>Coverage Level Code</summary>
        '''<remarks>This code is used to indicate or verify the patient's benefit coverage level at the time the claim was adjudicated.</remarks>
        Property SV704 As String

        '''<summary>Product/Process Characteristic Code</summary>
        '''<remarks>SV705 describes the legal status (characteristic) of the drug being dispensed.</remarks>
        Property SV705 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>SV706 is the Drug Utilization Review (DUR) alert indicator. A "Y" indicates a DUR alert was issued; an "N" indicates DUR processing occurred but no alert was issued.</remarks>
        Property SV706 As String

    End Interface
End NameSpace