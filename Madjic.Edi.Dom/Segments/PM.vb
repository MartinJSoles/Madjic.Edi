Namespace Segments
    '''<summary>Electronic Funds Transfer Information</summary>
    '''<remarks>To supply information on the electronic funds transfer (EFT) method of payment</remarks>
    Partial Friend Class PM_Obj
        Inherits Segment
        Implements PM
        Private Shared ReadOnly _Rules As SyntaxRule() = {New SyntaxRuleAllRequired({1, 2, 3, 4})}

        Public Sub New()
            MyBase.New("PM")
            Elements.AddRange({CType(Nothing, DataElements.Element507),
                                      CType(Nothing, DataElements.Element508),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element1073),
                                      CType(Nothing, DataElements.Element569),
                                      CType(Nothing, DataElements.Element506)})

            SyntaxRules.AddRange(_Rules)
            Initialize()
        End Sub

        Partial Private Sub Initialize()

        End Sub

        Friend Property PM01 As String Implements PM.PM01
            Get
                Return If(Elements(0) IsNot Nothing, CType(Elements(0), DataElements.Element507).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(0) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(0) = New DataElements.Element507
                End If

                If Elements(0) IsNot Nothing Then
                    CType(Elements(0), DataElements.Element507).Value = value
                End If
            End Set
        End Property

        Friend Property PM02 As String Implements PM.PM02
            Get
                Return If(Elements(1) IsNot Nothing, CType(Elements(1), DataElements.Element508).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(1) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(1) = New DataElements.Element508
                End If

                If Elements(1) IsNot Nothing Then
                    CType(Elements(1), DataElements.Element508).Value = value
                End If
            End Set
        End Property

        Friend Property PM03 As String Implements PM.PM03
            Get
                Return If(Elements(2) IsNot Nothing, CType(Elements(2), DataElements.Element1073).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(2) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(2) = New DataElements.Element1073
                End If

                If Elements(2) IsNot Nothing Then
                    CType(Elements(2), DataElements.Element1073).Value = value
                End If
            End Set
        End Property

        Friend Property PM04 As String Implements PM.PM04
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

        Friend Property PM05 As String Implements PM.PM05
            Get
                Return If(Elements(4) IsNot Nothing, CType(Elements(4), DataElements.Element569).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(4) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(4) = New DataElements.Element569
                End If

                If Elements(4) IsNot Nothing Then
                    CType(Elements(4), DataElements.Element569).Value = value
                End If
            End Set
        End Property

        Friend Property PM06 As String Implements PM.PM06
            Get
                Return If(Elements(5) IsNot Nothing, CType(Elements(5), DataElements.Element506).Value, Nothing)
            End Get
            Set(value As String)
                If Elements(5) Is Nothing AndAlso value IsNot Nothing Then
                    Elements(5) = New DataElements.Element506
                End If

                If Elements(5) IsNot Nothing Then
                    CType(Elements(5), DataElements.Element506).Value = value
                End If
            End Set
        End Property

        Friend Shared Function FromGenericSegment(source As GenericSegment, reader As EdiReader.SegmentReader) As PM
            Dim rval As New PM_Obj

            With rval
                If source.Elements.Count > 0 Then
                    .PM01 = source.ToStringValue(0)
                End If
                If source.Elements.Count > 1 Then
                    .PM02 = source.ToStringValue(1)
                End If
                If source.Elements.Count > 2 Then
                    .PM03 = source.ToStringValue(2)
                End If
                If source.Elements.Count > 3 Then
                    .PM04 = source.ToStringValue(3)
                End If
                If source.Elements.Count > 4 Then
                    .PM05 = source.ToStringValue(4)
                End If
                If source.Elements.Count > 5 Then
                    .PM06 = source.ToStringValue(5)
                End If
            End With

            Return rval
        End Function

    End Class

    '''<summary>Electronic Funds Transfer Information</summary>
    '''<remarks>To supply information on the electronic funds transfer (EFT) method of payment</remarks>
    Public Interface PM
        Inherits ISegment

        '''<summary>(DFI) Identification Number</summary>
        '''<remarks>PM01 is the transit routing number of the receiving financial institution.</remarks>
        Property PM01 As String

        '''<summary>Account Number</summary>
        '''<remarks>PM02 is the electronic fund transfer recipient's account number.</remarks>
        Property PM02 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>PM03 is the authorization for electronic funds transfer indicator. A "Y" value indicates authorization has been granted to allow electronic funds transfer; an "N" value indicates no authorization has been granted for electronic funds transfer.</remarks>
        Property PM03 As String

        '''<summary>Yes/No Condition or Response Code</summary>
        '''<remarks>PM04 is the authorization signature for electronic funds transfer on file indicator. A "Y" value indicates that a signature has been obtained and is on file; an "N" value indicates a signature has not been obtained.</remarks>
        Property PM04 As String

        '''<summary>Account Number Qualifier</summary>
        '''<remarks>PM05 qualifies the account number indicated in PM02.</remarks>
        Property PM05 As String

        '''<summary>(DFI) ID Number Qualifier</summary>
        '''<remarks>PM06 qualifies the Depository Financial Institution (DFI) Identification Number indicated in PM01.</remarks>
        Property PM06 As String

    End Interface
End NameSpace